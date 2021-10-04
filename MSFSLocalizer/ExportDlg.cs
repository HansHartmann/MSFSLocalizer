using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSFSLocalizer
{
    public partial class ExportDlg : Form
    {
        private LocalizationFile locFile;
        private List<string> Languages;
        private string PrimaryLang;

        public ExportDlg(LocalizationFile aLocFile, List<string> aLanguages, string aPrimaryLang)
        {
            InitializeComponent();
            locFile = aLocFile;
            Languages = aLanguages;
            PrimaryLang = aPrimaryLang;
        }

        private void ExportDlg_Load(object sender, EventArgs e)
        {
            foreach (string lang in Languages)
            {
                if (lang != PrimaryLang)
                    clbxLanguages.Items.Add(lang);
            }
        }

        private void bFileSel_Click(object sender, EventArgs e)
        {
            if (tbBaseFileName.TextLength > 0)
                sfdExport.FileName = tbBaseFileName.Text;
            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                tbBaseFileName.Text = sfdExport.FileName;
            }
        }

        private void bSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbxLanguages.Items.Count; i++)
                clbxLanguages.SetItemChecked(i, true);
        }

        private void bSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbxLanguages.Items.Count; i++)
                clbxLanguages.SetItemChecked(i, false);
        }

        private bool CheckCanSave()
        {
            bool dirExists = tbBaseFileName.TextLength > 0 && Directory.Exists(Path.GetDirectoryName(tbBaseFileName.Text));
            bool langSel = clbxLanguages.CheckedItems.Count > 0;

            return dirExists && langSel;
        }
        private void bOK_Click(object sender, EventArgs e)
        {
            if (!CheckCanSave())
            {
                MessageBox.Show("A file name and at least one language need to be selected before exporting!", "Export for Translation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool error = false;
            foreach (string lang in clbxLanguages.CheckedItems)
            {
                string fName = Path.GetDirectoryName(tbBaseFileName.Text) +
                    Path.DirectorySeparatorChar +
                    Path.GetFileNameWithoutExtension(tbBaseFileName.Text) + "_" + lang +
                    Path.GetExtension(tbBaseFileName.Text);
                if (!locFile.ExportCSV(fName, lang, PrimaryLang))
                    error = true;
            }

            if (error)
                return;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
