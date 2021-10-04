using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MSFSLocalizer
{
    [Serializable]
    public class Config
    {
        [XmlElementAttribute("Name")]
        public string Name { get; set; }
        [XmlElementAttribute("DefaultString")]
        public string DefaultString { get; set; }
        [XmlElementAttribute("LastProject")]
        public string LastProject { get; set; }
        [XmlElementAttribute("AutoCopyToAll")]
        public bool AutoCopyToAll { get; set; }
        [XmlElementAttribute("PrimaryLanguage")]
        public string PrimaryLanguage { get; set; }
        [XmlElementAttribute("RecentProjects")]
        public List<string> RecentProjects;

        public Config()
        {
            Name = "Default User";
            DefaultString = "AIRCRAFT.TOOLTIPS.";
            RecentProjects = new List<string>();
        }

        public string ToXML()
        {
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer ser = new XmlSerializer(this.GetType());
                MemoryStream memStrm = new MemoryStream();
                UTF8Encoding utf8e = new UTF8Encoding();
                using (XmlTextWriter xml = new XmlTextWriter(memStrm, utf8e))
                {
                    //ser.Serialize(xml, this);
                    xml.WriteStartDocument();
                    xml.WriteStartElement("Config");
                    xml.WriteElementString("Name", Name);
                    xml.WriteElementString("DefaultString", DefaultString);
                    xml.WriteElementString("LastProject", LastProject);
                    xml.WriteElementString("AutoCopyToAll", Convert.ToString(AutoCopyToAll));
                    xml.WriteElementString("PrimaryLanguage", PrimaryLanguage);
                    xml.WriteStartElement("RecentProjects");
                    xml.WriteWhitespace("\n");
                    int idx = 0;
                    foreach (string r in RecentProjects)
                    {
                        xml.WriteElementString("RecentProjects." + idx.ToString(), r);
                        idx++;
                    }
                    xml.WriteEndElement();
                    xml.WriteEndElement();
                    xml.WriteEndDocument();
                }

                byte[] utf8EncodedData = memStrm.ToArray();
                return utf8e.GetString(utf8EncodedData);
            }
        }

        public void FromXML(string fname)
        {
            RecentProjects.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(fname);
            XmlNode xnRoot = doc.LastChild;
            foreach (XmlNode xn in xnRoot.ChildNodes)
            {
                if (xn.Name == "Name")
                    Name = xn.InnerText;
                if (xn.Name == "DefaultString")
                    DefaultString = xn.InnerText;
                if (xn.Name == "LastProject")
                    LastProject = xn.InnerText;
                if (xn.Name == "AutoCopyToAll")
                    AutoCopyToAll = Convert.ToBoolean(xn.InnerText);
                if (xn.Name == "PrimaryLanguage")
                    PrimaryLanguage = xn.InnerText;
                if (xn.Name == "RecentProjects")
                {
                    foreach (XmlNode xnRP in xn.ChildNodes)
                    {
                        RecentProjects.Add(xnRP.InnerText);
                    }
                }
            }
        }

        public void AddToRecentProjects(string fname)
        {
            int idx = RecentProjects.IndexOf(fname);
            if (idx != -1)
                RecentProjects.RemoveAt(idx);
            RecentProjects.Insert(0, fname);
        }
    }
}
