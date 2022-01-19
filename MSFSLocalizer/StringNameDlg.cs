using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSFSLocalizer
{
    public partial class StringNameDlg : Form
    {
        public string NewName { get; private set; }
        public bool AppendTitleAction { get; private set; }

        public StringNameDlg(string previousName, Config aCfg, bool HideTitleAction = false)
        {
            InitializeComponent();

            NewName = previousName;
            if (string.IsNullOrEmpty(previousName))
                previousName = aCfg.DefaultString;
            tbStringName.Text = previousName;
            tbStringName.SelectionStart = tbStringName.Text.Length;

            if (HideTitleAction)
            {
                cbTitleAction.Visible = false;
                AppendTitleAction = false;
            }    
            else
            {
                cbTitleAction.Visible = true;
                cbTitleAction.Checked = aCfg.AppendTitleAction;
                AppendTitleAction = aCfg.AppendTitleAction;

            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStringName.Text))
            {
                MessageBox.Show("The string name must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewName = tbStringName.Text.Trim();
            AppendTitleAction = cbTitleAction.Checked;
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
