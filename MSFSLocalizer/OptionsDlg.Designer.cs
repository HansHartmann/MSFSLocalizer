namespace MSFSLocalizer
{
    partial class OptionsDlg
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDefaultString = new System.Windows.Forms.TextBox();
            this.bClearMRU = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutoCopyToAll = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLanguages = new System.Windows.Forms.ComboBox();
            this.cbAutoSort = new System.Windows.Forms.CheckBox();
            this.bWindowPosCapture = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bWindowPosReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(239, 25);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(468, 29);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "(used for \"Last Modified By\" field)";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(1047, 22);
            this.bOK.Margin = new System.Windows.Forms.Padding(6);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(171, 42);
            this.bOK.TabIndex = 5;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(1047, 76);
            this.bCancel.Margin = new System.Windows.Forms.Padding(6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(171, 42);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Default String Name";
            // 
            // tbDefaultString
            // 
            this.tbDefaultString.Location = new System.Drawing.Point(239, 66);
            this.tbDefaultString.Margin = new System.Windows.Forms.Padding(6);
            this.tbDefaultString.Name = "tbDefaultString";
            this.tbDefaultString.Size = new System.Drawing.Size(468, 29);
            this.tbDefaultString.TabIndex = 4;
            // 
            // bClearMRU
            // 
            this.bClearMRU.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClearMRU.Location = new System.Drawing.Point(239, 107);
            this.bClearMRU.Margin = new System.Windows.Forms.Padding(6);
            this.bClearMRU.Name = "bClearMRU";
            this.bClearMRU.Size = new System.Drawing.Size(171, 42);
            this.bClearMRU.TabIndex = 7;
            this.bClearMRU.Text = "Clear";
            this.bClearMRU.UseVisualStyleBackColor = true;
            this.bClearMRU.Click += new System.EventHandler(this.bClearRecentProjects_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recent Files List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Languages";
            // 
            // cbAutoCopyToAll
            // 
            this.cbAutoCopyToAll.AutoSize = true;
            this.cbAutoCopyToAll.Location = new System.Drawing.Point(239, 159);
            this.cbAutoCopyToAll.Name = "cbAutoCopyToAll";
            this.cbAutoCopyToAll.Size = new System.Drawing.Size(498, 29);
            this.cbAutoCopyToAll.TabIndex = 10;
            this.cbAutoCopyToAll.Text = "Automatically copy entered text to all other languages";
            this.cbAutoCopyToAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(239, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(781, 85);
            this.label6.TabIndex = 11;
            this.label6.Text = "WARNING: \r\nThis function is only intended to initially fill all languages when cr" +
    "eating a new file. Do NOT use with any files that already contain translations!!" +
    "!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Master Language";
            // 
            // cbxLanguages
            // 
            this.cbxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguages.FormattingEnabled = true;
            this.cbxLanguages.Items.AddRange(new object[] {
            "en-US",
            "fr-FR",
            "de-DE",
            "es-ES",
            "it-IT",
            "nl-NL",
            "pl-PL",
            "pt-BR",
            "ru-RU",
            "ja-JP"});
            this.cbxLanguages.Location = new System.Drawing.Point(239, 290);
            this.cbxLanguages.Name = "cbxLanguages";
            this.cbxLanguages.Size = new System.Drawing.Size(185, 32);
            this.cbxLanguages.TabIndex = 13;
            // 
            // cbAutoSort
            // 
            this.cbAutoSort.AutoSize = true;
            this.cbAutoSort.Location = new System.Drawing.Point(239, 328);
            this.cbAutoSort.Name = "cbAutoSort";
            this.cbAutoSort.Size = new System.Drawing.Size(286, 29);
            this.cbAutoSort.TabIndex = 14;
            this.cbAutoSort.Text = "Automatically Sort String List";
            this.cbAutoSort.UseVisualStyleBackColor = true;
            // 
            // bWindowPosCapture
            // 
            this.bWindowPosCapture.Location = new System.Drawing.Point(239, 366);
            this.bWindowPosCapture.Margin = new System.Windows.Forms.Padding(6);
            this.bWindowPosCapture.Name = "bWindowPosCapture";
            this.bWindowPosCapture.Size = new System.Drawing.Size(171, 42);
            this.bWindowPosCapture.TabIndex = 15;
            this.bWindowPosCapture.Text = "Capture";
            this.bWindowPosCapture.UseVisualStyleBackColor = true;
            this.bWindowPosCapture.Click += new System.EventHandler(this.bWindowPosCapture_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sorting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 375);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Window Position";
            // 
            // bWindowPosReset
            // 
            this.bWindowPosReset.Location = new System.Drawing.Point(422, 366);
            this.bWindowPosReset.Margin = new System.Windows.Forms.Padding(6);
            this.bWindowPosReset.Name = "bWindowPosReset";
            this.bWindowPosReset.Size = new System.Drawing.Size(171, 42);
            this.bWindowPosReset.TabIndex = 18;
            this.bWindowPosReset.Text = "Reset";
            this.bWindowPosReset.UseVisualStyleBackColor = true;
            this.bWindowPosReset.Click += new System.EventHandler(this.bWindowPosReset_Click);
            // 
            // OptionsDlg
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1236, 428);
            this.Controls.Add(this.bWindowPosReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bWindowPosCapture);
            this.Controls.Add(this.cbAutoSort);
            this.Controls.Add(this.cbxLanguages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAutoCopyToAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bClearMRU);
            this.Controls.Add(this.tbDefaultString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDefaultString;
        private System.Windows.Forms.Button bClearMRU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAutoCopyToAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLanguages;
        private System.Windows.Forms.CheckBox cbAutoSort;
        private System.Windows.Forms.Button bWindowPosCapture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bWindowPosReset;
    }
}