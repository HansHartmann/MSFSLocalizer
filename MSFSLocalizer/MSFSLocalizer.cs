using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MSFSLocalizer
{
    public partial class MSFSLocalizer : Form
    {
        private Config config;
        private LocalizationFile locFile;
        private bool inhibitCopyToAll = false;
        private bool isDirty = false;
        private bool flashDirty = false;
        private List<string> Languages;

        public MSFSLocalizer()
        {
            InitializeComponent();
            config = new Config();
            LoadConfig();
            locFile = new LocalizationFile();
            isDirty = false;
            Languages = new List<string>();
        }

        private void MSFSLocalizer_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(config.LastProject))
                LoadJson(config.LastProject);
            CheckForTranslations();
            BuildGlobals();
            BuildTree();
            BuildRecentProjectList();
        }

        private void MSFSLocalizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult res = MessageBox.Show("The current file is not saved. Do you want to exit anyway?", "File not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = res == DialogResult.No;
            }
        }

        private void MSFSLocalizer_Shown(object sender, EventArgs e)
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            string copyright = ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            string author = ((AssemblyCompanyAttribute)attributes[0]).Company;

            tsslInfo.Text = Application.ProductName + " " + Application.ProductVersion + " - " + copyright + " " + author;
        }

        private void miFileNew_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                DialogResult res = MessageBox.Show("The current file is not saved. Do you want to create a new file anyway?", "File not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
            }

            locFile = new LocalizationFile();
            locFile.Languages.Add("en-US");
            BuildGlobals();
            BuildTree();
            isDirty = false;
        }

        private void miFileOpen_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                DialogResult res = MessageBox.Show("The current file is not saved. Do you want open another file anyway?", "File not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
            }

            if (!string.IsNullOrEmpty(config.LastProject))
                ofdOpen.FileName = config.LastProject;
            if (ofdOpen.ShowDialog() == DialogResult.OK)
                OpenFile(ofdOpen.FileName);
        }

        private void miFileRecentProjects_Click(object sender, EventArgs e)
        {
            string fname = (sender as ToolStripMenuItem).Text;
            OpenFile(fname);
        }

        private void OpenFile(string fname)
        {
            if (!File.Exists(fname))
                return;
            LoadJson(fname);
            BuildGlobals();
            BuildTree();
            config.LastProject = fname;
            config.AddToRecentProjects(fname);
            BuildRecentProjectList();
            SaveConfig();
            isDirty = false;
        }

        private void miFileSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(config.LastProject))
            {
                miFileSaveAs_Click(sender, e);
                return;
            }

            SaveJson();
        }

        private void miFileSaveAs_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                config.LastProject = sfdSave.FileName;
                config.AddToRecentProjects(sfdSave.FileName);
                BuildRecentProjectList();
                SaveConfig();
            }
            else
                return;

            SaveJson();
        }

        private void miFileOptions_Click(object sender, EventArgs e)
        {
            OptionsDlg dlg = new OptionsDlg(config);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                config = dlg.Config;
                SaveConfig();
            }
        }

        private void miFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool LoadJson(string filename)
        {
            locFile = new LocalizationFile();
            try
            {
                using (StreamReader file = File.OpenText(filename))
                {
                    using (JsonTextReader jtr = new JsonTextReader(file))
                    {
                        JObject obj = (JObject)JToken.ReadFrom(jtr);
                        locFile.Version = (string)obj["LocalisationFile"]["Version"];
                        locFile.UUID = (string)obj["LocalisationFile"]["UUID"];
                        JArray langlist = (JArray)obj["LocalisationFile"]["Languages"];
                        Languages.Clear();
                        foreach (JValue lang in langlist)
                        {
                            string s = lang.ToString();
                            locFile.Languages.Add(s);
                            Languages.Add(s);
                        }
                        JObject strlist = (JObject)obj["LocalisationFile"]["Strings"];
                        foreach (JProperty str in strlist.Children())
                        {
                            LocalizationString ls = new LocalizationString();
                            ls.Name = str.Name;
                            string basepath = "LocalisationFile.Strings." + str.Name + ".";
                            ls.UUID = (string)obj["LocalisationFile"]["Strings"][str.Name]["UUID"];
                            ls.LastModifiedBy = (string)obj["LocalisationFile"]["Strings"][str.Name]["LastModifiedBy"];
                            ls.LastModifiedDate = (string)obj["LocalisationFile"]["Strings"][str.Name]["LastModifiedDate"];
                            ls.LocalizationStatus = (string)obj["LocalisationFile"]["Strings"][str.Name]["LocalizationStatus"];
                            foreach (string lang in langlist)
                            {
                                LocalizationContent cont = new LocalizationContent();
                                cont.Language = lang;
                                try
                                {
                                    cont.Content = (string)obj["LocalisationFile"]["Strings"][str.Name]["Languages"][lang]["Text"];
                                    cont.LocalizationStatus = (string)obj["LocalisationFile"]["Strings"][str.Name]["Languages"][lang]["LocalizationStatus"];
                                }
                                catch (Exception)
                                {
                                    // No content exists for this language. Leave content property empty and move on
                                }
                                ls.Content.Add(cont);
                            }
                            locFile.Strings.Add(ls);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while parsing the localization file" + Environment.NewLine + ex.ToString(),
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CheckForTranslations()
        {
            if (!config.AutoCopyToAll)
                return;

            bool translated = false;
            foreach (LocalizationString ls in locFile.Strings)
            {
                List<string> languages = new List<string>();
                foreach(LocalizationContent lc in ls.Content)
                {
                    if (languages.Count > 0)
                    {
                        foreach (string lang in languages)
                        {
                            if (lang != lc.Content)
                            {
                                translated = true;
                                break;
                            }
                            languages.Add(lc.Content);
                        }
                    }
                    else
                        languages.Add(lc.Content);
                    if (translated)
                        break;
                }
                if (translated)
                    break;
            }

            if (translated)
            {
                config.AutoCopyToAll = false;
                MessageBox.Show("String translations have been found in the current file. Automatic copying to other languages has been disabled.", "Copy to all languages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool SaveJson()
        {
            string CR = Environment.NewLine;
            try
            {
                string json = "{ " + CR + "\"LocalisationFile\": { " + CR;
                json += Prop("Version") + Q(locFile.Version) + "," + CR;
                json += Prop("UUID") + Q(locFile.UUID) + "," + CR;
                json += Prop("Languages") + "[" + CR;
                int cnt = 0;
                foreach (string l in Languages)
                {
                    cnt++;
                    json += Q(l);
                    if (cnt < Languages.Count)
                        json += ",";
                    json += CR;
                }
                json += "],";
                json += Prop("Strings") + "{" + CR;
                cnt = 0;
                foreach (LocalizationString s in locFile.Strings)
                {
                    cnt++;
                    json += Prop(s.Name) + " {" + CR;
                    json += Prop("UUID") + Q(s.UUID) + "," + CR;
                    json += Prop("LastModifiedBy") + Q(s.LastModifiedBy) + "," + CR;
                    json += Prop("LastModifiedDate") + Q(s.LastModifiedDate) + "," + CR;
                    json += Prop("LocalizationStatus") + Q(s.LocalizationStatus) + "," + CR;
                    json += Prop("Languages") + "{" + CR;
                    int cntCont = 0;
                    foreach (LocalizationContent c in s.Content)
                    {
                        cntCont++;
                        json += Prop(c.Language) + "{" + CR;
                        json += Prop("Text") + Q(c.Content) + "," + CR;
                        json += Prop("LocalizationStatus") + Q(c.LocalizationStatus) + CR;
                        if (cntCont < s.Content.Count)
                            json += "}," + CR; // End Language
                        else
                            json += "}" + CR; // End LastLanguage
                    }
                    json += "}" + CR; // End Languages
                    if (cnt < locFile.Strings.Count)
                        json += "}," + CR; // End String Entry
                    else
                        json += "}" + CR; // End String Entry
                }
                json += "}" + CR; // End Strings
                json += "}" + CR; // End LocalisationFile
                json += "}" + CR; // End outer bracket

                using (StreamWriter sw = new StreamWriter(config.LastProject))
                {
                    sw.WriteLine(json);
                }

                isDirty = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured on saving the localization file" + Environment.NewLine + ex.ToString(),
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string Q(string s)
        {
            return "\"" + s + "\"";
        }

        private string Prop(string s)
        {
            return Q(s) + ": ";
        }

        private void BuildGlobals()
        {
            tbVersion.Text = locFile.Version;
            tbUUID.Text = locFile.UUID;

            cbxLanguage.Items.Clear();
            foreach (string lang in locFile.Languages)
            {
                cbxLanguage.Items.Add(lang);
            }
            if (cbxLanguage.Items.Count > 0)
                cbxLanguage.SelectedIndex = 0;
        }

        private void BuildTree()
        {
            tvData.Nodes.Clear();
            tvData.BeginUpdate();
            foreach (LocalizationString ls in locFile.Strings)
            {
                TreeNode tn = tvData.Nodes.Add(ls.Name);
                tn.Tag = ls;
            }
            tvData.EndUpdate();

            if (tvData.Nodes.Count > 0)
                tvData.SelectedNode = tvData.Nodes[0];
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContent();
        }

        private void tvData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SetContent();
        }

        private void tvData_DoubleClick(object sender, EventArgs e)
        {
            bStringRename_Click(sender, e);
        }

        private void SetContent()
        {
            if (tvData.SelectedNode == null)
                return;

            TreeNode tn = tvData.SelectedNode;
            LocalizationString ls = tn.Tag as LocalizationString;
            tbUUIDCont.Text = ls.UUID;
            tbModName.Text = ls.LastModifiedBy;
            DateTime dt;
            if (DateTime.TryParse(ls.LastModifiedDate, out dt))
                dtpModDate.Value = dt;
            else
                dtpModDate.Value = DateTime.Now;
            cbxStatus.Text = ls.LocalizationStatus;
            inhibitCopyToAll = true;
            foreach (LocalizationContent lc in ls.Content)
            {
                if (lc.Language == cbxLanguage.Text)
                    tbContent.Text = lc.Content;
            }
            inhibitCopyToAll = false;
        }

        private void SaveContent(bool allLanguages = false)
        {
            if (tvData.SelectedNode == null)
                return;

            if (config.AutoCopyToAll)
                allLanguages = true;

            TreeNode tn = tvData.SelectedNode;
            LocalizationString ls = tn.Tag as LocalizationString;
            ls.UUID = tbUUIDCont.Text;
            ls.LastModifiedBy = tbModName.Text;
            ls.LastModifiedDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            ls.LocalizationStatus = cbxStatus.Text;
            foreach (LocalizationContent lc in ls.Content)
            {
                if (allLanguages || lc.Language == cbxLanguage.Text)
                {
                    lc.Content = tbContent.Text;
                }
            }
            isDirty = true;
        }

        private void bAddString_Click(object sender, EventArgs e)
        {
            StringNameDlg dlg = new StringNameDlg("", config);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            string name = dlg.NewName;
            TreeNode tn = FindStringName(name);
            if (tn != null)
            {
                MessageBox.Show(string.Format("A string with the name '{0}' already exists!", name));
                tvData.SelectedNode = tn;
                tvData.Focus();
                return;
            }

            LocalizationString ls = new LocalizationString();
            ls.Name = name;
            string basepath = "LocalisationFile.Strings." + name + ".";
            Guid g = Guid.NewGuid();
            ls.UUID = g.ToString();
            ls.LastModifiedBy = config.Name;
            ls.LastModifiedDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            ls.LocalizationStatus = "Work in Progress";
            foreach (string lang in Languages)
            {
                LocalizationContent cont = new LocalizationContent();
                cont.Language = lang;
                cont.Content = "";
                ls.Content.Add(cont);
            }
            locFile.Strings.Add(ls);
            tn = tvData.Nodes.Add(ls.Name);
            tn.Tag = ls;
            tvData.SelectedNode = tn;
            tvData.Focus();
            isDirty = true;
        }

        private void bDeleteString_Click(object sender, EventArgs e)
        {
            if (tvData.SelectedNode == null)
                return;

            TreeNode tn = tvData.SelectedNode;
            LocalizationString ls = tn.Tag as LocalizationString;
            DialogResult res = MessageBox.Show(string.Format("Do you really want to delete the string '{0}' including all languages?", ls.Name), "Delete string?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            tn.Nodes.Remove(tn);
            isDirty = true;
        }

        private void bDuplicateString_Click(object sender, EventArgs e)
        {
            if (tvData.SelectedNode == null)
                return;

            TreeNode tn = tvData.SelectedNode;
            LocalizationString lsSrc = tn.Tag as LocalizationString;

            StringNameDlg dlg = new StringNameDlg(lsSrc.Name + "_COPY", config);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            string name = dlg.NewName;
            TreeNode tnExists = FindStringName(name);
            if (tnExists != null)
            {
                MessageBox.Show(string.Format("A string with the name '{0}' already exists!", name));
                tvData.SelectedNode = tnExists;
                tvData.Focus();
                return;
            }

            LocalizationString ls = lsSrc.DeepClone();
            ls.Name = name;
            Guid g = Guid.NewGuid();
            ls.UUID = g.ToString();

            locFile.Strings.Add(ls);
            tn = tvData.Nodes.Add(ls.Name);
            tn.Tag = ls;
            tvData.SelectedNode = tn;
            tvData.Focus();
            isDirty = true;
        }

        private void bStringRename_Click(object sender, EventArgs e)
        {
            if (tvData.SelectedNode == null)
                return;

            TreeNode tn = tvData.SelectedNode;
            LocalizationString ls = tn.Tag as LocalizationString;

            StringNameDlg dlg = new StringNameDlg(ls.Name, config);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            TreeNode tnDupl = FindStringName(dlg.NewName);
            if (tnDupl != null && tnDupl != tn)
            {
                MessageBox.Show(string.Format("A string with the name '{0}' already exists!", dlg.NewName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tvData.SelectedNode = tnDupl;
                tvData.Focus();
                return;
            }

            ls.Name = dlg.NewName;
            tn.Text = dlg.NewName;
            isDirty = true;
        }
        private void bStringsSort_Click(object sender, EventArgs e)
        {
            tvData.Sort();
        }

        private void bSetUUID_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            tbUUID.Text = g.ToString();
            isDirty = true;
        }

        private void bSetUUIDCont_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            tbUUIDCont.Text = g.ToString();
            isDirty = true;
        }

        private void bSetUserDate_Click(object sender, EventArgs e)
        {
            tbModName.Text = config.Name;
            dtpModDate.Value = DateTime.Now;
            isDirty = true;
        }

        private TreeNode FindStringName(string name)
        {
            foreach (TreeNode tn in tvData.Nodes)
            {
                LocalizationString ls = tn.Tag as LocalizationString;
                if (ls.Name == name)
                    return tn;
            }

            return null;
        }

        private void bSaveString_Click(object sender, EventArgs e)
        {
            SaveContent();
        }

        private void bRevertString_Click(object sender, EventArgs e)
        {
            SetContent();
        }

        private void bCopyAll_Click(object sender, EventArgs e)
        {
            SaveContent(true);
        }

        private bool LoadConfig()
        {
            try
            {
                string fname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MSFSLocalizer.xml");
                if (File.Exists(fname))
                    config.FromXML(fname);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Configuration could not be loaded" + Environment.NewLine + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SaveConfig()
        {
            try
            {
                string fname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MSFSLocalizer.xml");
                using (StreamWriter sw = new StreamWriter(fname))
                {
                    string s = config.ToXML();
                    sw.WriteLine(s);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Configuration could not be saved" + Environment.NewLine + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void tmrDirty_Tick(object sender, EventArgs e)
        {
            if (isDirty)
            {
                flashDirty = !flashDirty;

                if (flashDirty)
                    Text = "MSFS Localizer - *** NOT SAVED ***";
                else
                    Text = "MSFS Localizer";
            }
            else
            {
                Text = "MSFS Localizer";
            }

        }

        private void BuildRecentProjectList()
        {
            ClearRecentProjectList();

            miFileSep2.Visible = config.RecentProjects.Count != 0;
            int cnt = 0;
            foreach (string rp in config.RecentProjects)
            {
                ToolStripMenuItem mi = new ToolStripMenuItem(rp, null, miFileRecentProjects_Click);
                mi.Tag = "RecentProject";
                miFile.DropDownItems.Insert(5 + cnt, mi);
                cnt++;
            }
        }

        private void ClearRecentProjectList()
        {
            int cnt = miFile.DropDownItems.Count;
            for (int i = cnt - 1; i >= 0; i--)
            {
                ToolStripMenuItem mi = miFile.DropDownItems[i] as ToolStripMenuItem;
                if (mi != null && mi.Tag != null && mi.Tag.ToString() == "RecentProject")
                {
                    miFile.DropDownItems.RemoveAt(i);
                }
            }
        }

        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            if (config.AutoCopyToAll && !inhibitCopyToAll)
            {
                SaveContent(true);
            }
        }
    }
}
