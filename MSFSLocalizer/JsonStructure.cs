using System;
using System.Collections.Generic;

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
            foreach (string s  in Languages)
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
