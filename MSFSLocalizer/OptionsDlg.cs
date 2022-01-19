using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSFSLocalizer
{
    public partial class OptionsDlg : Form
    {
        public Config Config;
        public OptionsDlg(Config aConfig)
        {
            Config = aConfig;
            InitializeComponent();
        }
        private void OptionsDlg_Load(object sender, EventArgs e)
        {
            tbName.Text = Config.Name;
            tbDefaultString.Text = Config.DefaultString;
            cbAutoCopyToAll.Checked = Config.AutoCopyToAll;
            cbAutoSort.Checked = Config.AutoSort;
            if (!string.IsNullOrEmpty(Config.PrimaryLanguage))
            {
                int idx = cbxLanguages.Items.IndexOf(Config.PrimaryLanguage);
                cbxLanguages.SelectedIndex = idx;
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Config.Name = tbName.Text;
            Config.DefaultString = tbDefaultString.Text;
            Config.AutoCopyToAll = cbAutoCopyToAll.Checked;
            Config.PrimaryLanguage = cbxLanguages.SelectedItem.ToString();
            Config.AutoSort = cbAutoSort.Checked;
            Close();
            DialogResult = DialogResult.OK;
        }

        private void bClearRecentProjects_Click(object sender, EventArgs e)
        {
            Config.RecentProjects.Clear();
        }

        private void bWindowPosCapture_Click(object sender, EventArgs e)
        {
            Config.WindowX = Owner.Location.X;
            Config.WindowY = Owner.Location.Y;
            Config.WindowW = Owner.Size.Width;
            Config.WindowH = Owner.Size.Height;
        }
        private void bWindowPosReset_Click(object sender, EventArgs e)
        {
            Config.WindowX = 0;
            Config.WindowY = 0;
            Config.WindowW = 0;
            Config.WindowH = 0;
        }
    }
}
