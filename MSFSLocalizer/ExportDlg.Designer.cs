
namespace MSFSLocalizer
{
    partial class ExportDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbBaseFileName = new System.Windows.Forms.TextBox();
            this.bFileSel = new System.Windows.Forms.Button();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.clbxLanguages = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSelectAll = new System.Windows.Forms.Button();
            this.bSelectNone = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base File Name";
            // 
            // tbBaseFileName
            // 
            this.tbBaseFileName.Location = new System.Drawing.Point(174, 21);
            this.tbBaseFileName.Name = "tbBaseFileName";
            this.tbBaseFileName.ReadOnly = true;
            this.tbBaseFileName.Size = new System.Drawing.Size(445, 29);
            this.tbBaseFileName.TabIndex = 1;
            // 
            // bFileSel
            // 
            this.bFileSel.Location = new System.Drawing.Point(628, 15);
            this.bFileSel.Margin = new System.Windows.Forms.Padding(6);
            this.bFileSel.Name = "bFileSel";
            this.bFileSel.Size = new System.Drawing.Size(45, 42);
            this.bFileSel.TabIndex = 6;
            this.bFileSel.Text = "...";
            this.bFileSel.UseVisualStyleBackColor = true;
            this.bFileSel.Click += new System.EventHandler(this.bFileSel_Click);
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "CSV";
            this.sfdExport.Filter = "Comma-separated Values (*.csv)|*.csv";
            this.sfdExport.Title = "Export for Translation";
            // 
            // clbxLanguages
            // 
            this.clbxLanguages.CheckOnClick = true;
            this.clbxLanguages.FormattingEnabled = true;
            this.clbxLanguages.Location = new System.Drawing.Point(174, 66);
            this.clbxLanguages.Name = "clbxLanguages";
            this.clbxLanguages.Size = new System.Drawing.Size(445, 524);
            this.clbxLanguages.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Languages";
            // 
            // bSelectAll
            // 
            this.bSelectAll.Location = new System.Drawing.Point(174, 599);
            this.bSelectAll.Margin = new System.Windows.Forms.Padding(6);
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.Size = new System.Drawing.Size(171, 42);
            this.bSelectAll.TabIndex = 9;
            this.bSelectAll.Text = "Select All";
            this.bSelectAll.UseVisualStyleBackColor = true;
            this.bSelectAll.Click += new System.EventHandler(this.bSelectAll_Click);
            // 
            // bSelectNone
            // 
            this.bSelectNone.Location = new System.Drawing.Point(448, 599);
            this.bSelectNone.Margin = new System.Windows.Forms.Padding(6);
            this.bSelectNone.Name = "bSelectNone";
            this.bSelectNone.Size = new System.Drawing.Size(171, 42);
            this.bSelectNone.TabIndex = 10;
            this.bSelectNone.Text = "Select None";
            this.bSelectNone.UseVisualStyleBackColor = true;
            this.bSelectNone.Click += new System.EventHandler(this.bSelectNone_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(713, 69);
            this.bCancel.Margin = new System.Windows.Forms.Padding(6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(171, 42);
            this.bCancel.TabIndex = 12;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(713, 15);
            this.bOK.Margin = new System.Windows.Forms.Padding(6);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(171, 42);
            this.bOK.TabIndex = 11;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // ExportDlg
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(907, 657);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bSelectNone);
            this.Controls.Add(this.bSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbxLanguages);
            this.Controls.Add(this.bFileSel);
            this.Controls.Add(this.tbBaseFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export for Translation";
            this.Load += new System.EventHandler(this.ExportDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBaseFileName;
        private System.Windows.Forms.Button bFileSel;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.CheckedListBox clbxLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSelectAll;
        private System.Windows.Forms.Button bSelectNone;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
    }
}