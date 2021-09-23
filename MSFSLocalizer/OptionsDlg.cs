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
            Close();
            DialogResult = DialogResult.OK;
        }

        private void bClearRecentProjects_Click(object sender, EventArgs e)
        {
            Config.RecentProjects.Clear();
        }
    }
}
