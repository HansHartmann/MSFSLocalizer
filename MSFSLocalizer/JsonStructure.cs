using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MSFSLocalizer
{
    public static class Extensions
    {
        public static List<T> GetClone<T>(this List<T> source)
        {
            return source.GetRange(0, source.Count);
        }
    }

    public class LocalizationFile
    {
        public string Version { get; set; }
        public string UUID { get; set; }
        public List<string> Languages { get; set; }
        public List<LocalizationString> Strings { get; set; }

        public LocalizationFile()
        {
            Version = "";
            UUID = "";
            Languages = new List<string>();
            Strings = new List<LocalizationString>();
        }

        public LocalizationFile DeepClone()
        {
            LocalizationFile lf = new LocalizationFile();
            lf.Version = Version;
            lf.UUID = UUID;
            foreach (string s in Languages)
            {
                lf.Languages.Add(s);
            }
            foreach (LocalizationString ls in Strings)
            {
                LocalizationString lsNew = ls.DeepClone();
                lf.Strings.Add(lsNew);
            }
            return lf;
        }

        public bool AddLanguage(string aLCID, bool aCopyPrimary, string aPrimaryLang)
        {
            try
            {
                foreach (LocalizationString ls in Strings)
                {
                    string textPrimary = "";
                    if (aCopyPrimary)
                    {
                        foreach (LocalizationContent lcPrimary in ls.Content)
                        {
                            if (lcPrimary.Language.ToLower() == aPrimaryLang.ToLower())
                                textPrimary = lcPrimary.Content;
                        }
                    }

                    LocalizationContent lc = new LocalizationContent();
                    lc.Language = aLCID;
                    lc.Content = aCopyPrimary ? textPrimary : "";
                    lc.LocalizationStatus = "Translation Needed";
                    ls.Content.Add(lc);
                }

                Languages.Add(aLCID);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while adding language: {0}", ex.ToString()), "Add language", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExportCSV(string aFileName, string aLanguage, string aPrimaryLang)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(aFileName))
                {
                    string header = string.Format("Tooltip Name;{0};{1}", aPrimaryLang, aLanguage);
                    sw.WriteLine(header);
                    foreach (LocalizationString ls in Strings)
                    {
                        string textPrimary = "";
                        foreach (LocalizationContent lc in ls.Content)
                        {
                            if (lc.Language.ToLower() == aPrimaryLang.ToLower())
                                textPrimary = lc.Content;
                        }

                        foreach (LocalizationContent lc in ls.Content)
                        {
                            if (lc.Language.ToLower() == aLanguage.ToLower())
                            {
                                string line = string.Format("\"{0}\";\"{1}\";\"{2}\"", ls.Name, textPrimary, lc.Content);
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while creating export file '{0}': {1}", Path.GetFileName(aFileName), ex.ToString()), "Export to CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ImportCSV(string aFileName)
        {
            try
            {
                List<string> lines = new List<string>();
                using (StreamReader sr = new StreamReader(aFileName))
                {
                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());
                    }
                }

                // No lines or just header? Don't bother!
                if (lines.Count <= 1)
                {
                    MessageBox.Show(string.Format("'{0}' contains no data! Import process cancelled!", Path.GetFileName(aFileName)), "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                List<LocalizationString> strList = new List<LocalizationString>();
                foreach (LocalizationString ls in Strings)
                    strList.Add(ls.DeepClone());

                // Check first, the header line, for languages
                string[] fields = lines[0].Split(new char[] { ';' });
                string selLang = fields[2];

                for (int i = 1; i < lines.Count; i++)
                {
                    fields = lines[i].Split(new char[] { ';' });
                    string name = fields[0];
                    string trans = fields[2];
                    name = RemoveQuotes(name);
                    trans = RemoveQuotes(trans);
                    // Remove " from beginning and end if present
                    if (trans.StartsWith("\""))
                        trans = trans.Remove(0, 1);
                    if (name.EndsWith("\""))
                        name = name.Remove(name.Length);
                    if (!string.IsNullOrEmpty(name))
                    {
                        LocalizationString ls = strList.Find(x => x.Name.ToLower() == name.ToLower());
                        if (ls == null)
                        {
                            bool cancel = MessageBox.Show(string.Format("{0} could not be found in the current file!", name), "Import from CSV", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Abort;
                            if (cancel)
                                return false;
                        }
                        else
                        {
                            LocalizationContent lc = ls.Content.Find(x => x.Language.ToLower() == selLang.ToLower());
                            if (lc == null)
                            {
                                bool cancel = MessageBox.Show(string.Format("Language {0} not present for text '{1}'!", selLang, name), "Import from CSV", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Abort;
                                if (cancel)
                                    return false;
                            }
                            else
                            {
                                lc.Content = trans;
                            }
                        }
                    }
                }

                Strings.Clear();
                foreach (LocalizationString ls in strList)
                    Strings.Add(ls.DeepClone());

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while importing CSV file '{0}': {1}", Path.GetFileName(aFileName), ex.ToString()), "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        private string RemoveQuotes(string s)
        {
            if (s.StartsWith("\""))
                s = s.Remove(0, 1);
            if (s.EndsWith("\""))
                s = s.Remove(s.Length - 1);
            return s;
        }
    }

    [Serializable]
    public class LocalizationString
    {
        public string Name { get; set; }
        public string UUID { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedDate { get; set; }
        public string LocalizationStatus { get; set; }
        public List<LocalizationContent> Content { get; set; }

        public LocalizationString()
        {
            Name = "";
            UUID = "";
            LastModifiedBy = "";
            LastModifiedDate = "";
            LocalizationStatus = "";
            Content = new List<LocalizationContent>();
        }

        public LocalizationString DeepClone()
        {
            LocalizationString ls = new LocalizationString();
            ls.Name = Name;
            ls.UUID = UUID;
            ls.LastModifiedBy = LastModifiedBy;
            ls.LastModifiedDate = LastModifiedDate;
            ls.LocalizationStatus = LocalizationStatus;
            foreach (LocalizationContent lc in Content)
            {
                LocalizationContent lcNew = lc.DeepClone();
                ls.Content.Add(lcNew);
            }

            return ls;
        }
    }

    public class LocalizationContent
    {
        public string Language { get; set; }
        public string Content { get; set; }
        public string LocalizationStatus { get; set; }

        public LocalizationContent()
        {
            Language = "";
            Content = "";
            LocalizationStatus = "";
        }

        public LocalizationContent DeepClone()
        {
            LocalizationContent lc = new LocalizationContent();
            lc.Language = Language;
            lc.Content = Content;
            lc.LocalizationStatus = LocalizationStatus;
            return lc;
        }
    }
}
