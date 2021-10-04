using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSFSLocalizer
{
    public partial class LanguageDlg : Form
    {
        public string SelLCID = "";
        public bool CopyEnUS = false;
        private List<string> languages;

        public LanguageDlg(List<string> aLanguages)
        {
            InitializeComponent();

            languages = aLanguages;
        }

        private void LanguageDlg_Load(object sender, EventArgs e)
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo ci in cultures)
            {
                if (ci.IetfLanguageTag.IndexOf("-") == 2 && ci.IetfLanguageTag.Length == 5 && languages.IndexOf(ci.IetfLanguageTag) == -1)
                {
                    cbxLCID.Items.Add(ci.IetfLanguageTag);
                }
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (cbxLCID.Text.Length == 0)
            {
                MessageBox.Show("No language code selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (languages.IndexOf(cbxLCID.Text) != -1)
            {
                MessageBox.Show(string.Format("The language {0} already exists in the current file!", cbxLCID.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelLCID = cbxLCID.Text;
            CopyEnUS = cbCopyEnUS.Checked;

            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
