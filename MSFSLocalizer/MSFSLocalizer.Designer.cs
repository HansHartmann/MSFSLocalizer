namespace MSFSLocalizer
{
    partial class MSFSLocalizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSFSLocalizer));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miTranslation = new System.Windows.Forms.ToolStripMenuItem();
            this.miTranslationEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miTranslationExport = new System.Windows.Forms.ToolStripMenuItem();
            this.miTranslationImport = new System.Windows.Forms.ToolStripMenuItem();
            this.scPanels = new System.Windows.Forms.SplitContainer();
            this.pnlTree = new System.Windows.Forms.Panel();
            this.tvData = new System.Windows.Forms.TreeView();
            this.csMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsContextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContextDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContextRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContextSort = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bStringsSort = new System.Windows.Forms.Button();
            this.bDuplicateString = new System.Windows.Forms.Button();
            this.bStringRename = new System.Windows.Forms.Button();
            this.bDeleteString = new System.Windows.Forms.Button();
            this.bAddString = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxContent = new System.Windows.Forms.GroupBox();
            this.bCopyAll = new System.Windows.Forms.Button();
            this.bRevertString = new System.Windows.Forms.Button();
            this.bSaveString = new System.Windows.Forms.Button();
            this.bSetUserDate = new System.Windows.Forms.Button();
            this.bSetUUIDCont = new System.Windows.Forms.Button();
            this.tbUUIDCont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpModDate = new System.Windows.Forms.DateTimePicker();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxGlobal = new System.Windows.Forms.GroupBox();
            this.bSetUUID = new System.Windows.Forms.Button();
            this.tbUUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.tmrDirty = new System.Windows.Forms.Timer(this.components);
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).BeginInit();
            this.scPanels.Panel1.SuspendLayout();
            this.scPanels.Panel2.SuspendLayout();
            this.scPanels.SuspendLayout();
            this.pnlTree.SuspendLayout();
            this.csMenu.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.gbxContent.SuspendLayout();
            this.gbxGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miTranslation});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.msMenu.Size = new System.Drawing.Size(2171, 42);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileNew,
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAs,
            this.miFileSep1,
            this.miFileSep2,
            this.miFileOptions,
            this.toolStripMenuItem2,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(62, 34);
            this.miFile.Text = "&File";
            // 
            // miFileNew
            // 
            this.miFileNew.Name = "miFileNew";
            this.miFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miFileNew.Size = new System.Drawing.Size(341, 40);
            this.miFileNew.Text = "&New";
            this.miFileNew.Click += new System.EventHandler(this.miFileNew_Click);
            // 
            // miFileOpen
            // 
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFileOpen.Size = new System.Drawing.Size(341, 40);
            this.miFileOpen.Text = "&Open";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSave
            // 
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miFileSave.Size = new System.Drawing.Size(341, 40);
            this.miFileSave.Text = "&Save";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.miFileSaveAs.Size = new System.Drawing.Size(341, 40);
            this.miFileSaveAs.Text = "Save &as...";
            this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
            // 
            // miFileSep1
            // 
            this.miFileSep1.Name = "miFileSep1";
            this.miFileSep1.Size = new System.Drawing.Size(338, 6);
            // 
            // miFileSep2
            // 
            this.miFileSep2.Name = "miFileSep2";
            this.miFileSep2.Size = new System.Drawing.Size(338, 6);
            // 
            // miFileOptions
            // 
            this.miFileOptions.Name = "miFileOptions";
            this.miFileOptions.Size = new System.Drawing.Size(341, 40);
            this.miFileOptions.Text = "O&ptions";
            this.miFileOptions.Click += new System.EventHandler(this.miFileOptions_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(338, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(341, 40);
            this.miFileExit.Text = "E&xit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // miTranslation
            // 
            this.miTranslation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTranslationEdit,
            this.toolStripMenuItem1,
            this.miTranslationExport,
            this.miTranslationImport});
            this.miTranslation.Name = "miTranslation";
            this.miTranslation.Size = new System.Drawing.Size(131, 34);
            this.miTranslation.Text = "&Translation";
            // 
            // miTranslationEdit
            // 
            this.miTranslationEdit.Name = "miTranslationEdit";
            this.miTranslationEdit.Size = new System.Drawing.Size(328, 40);
            this.miTranslationEdit.Text = "&Add Language";
            this.miTranslationEdit.Click += new System.EventHandler(this.miTranslationEdit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(325, 6);
            // 
            // miTranslationExport
            // 
            this.miTranslationExport.Name = "miTranslationExport";
            this.miTranslationExport.Size = new System.Drawing.Size(328, 40);
            this.miTranslationExport.Text = "E&xport for Translation";
            this.miTranslationExport.Click += new System.EventHandler(this.miTranslationExport_Click);
            // 
            // miTranslationImport
            // 
            this.miTranslationImport.Name = "miTranslationImport";
            this.miTranslationImport.Size = new System.Drawing.Size(328, 40);
            this.miTranslationImport.Text = "I&mport Translation";
            this.miTranslationImport.Click += new System.EventHandler(this.miTranslationImport_Click);
            // 
            // scPanels
            // 
            this.scPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPanels.Location = new System.Drawing.Point(0, 42);
            this.scPanels.Margin = new System.Windows.Forms.Padding(6);
            this.scPanels.Name = "scPanels";
            // 
            // scPanels.Panel1
            // 
            this.scPanels.Panel1.Controls.Add(this.pnlTree);
            this.scPanels.Panel1.Controls.Add(this.pnlButtons);
            // 
            // scPanels.Panel2
            // 
            this.scPanels.Panel2.Controls.Add(this.StatusStrip);
            this.scPanels.Panel2.Controls.Add(this.gbxContent);
            this.scPanels.Panel2.Controls.Add(this.gbxGlobal);
            this.scPanels.Size = new System.Drawing.Size(2171, 1363);
            this.scPanels.SplitterDistance = 720;
            this.scPanels.SplitterWidth = 7;
            this.scPanels.TabIndex = 2;
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.tvData);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTree.Location = new System.Drawing.Point(0, 57);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(720, 1306);
            this.pnlTree.TabIndex = 2;
            // 
            // tvData
            // 
            this.tvData.ContextMenuStrip = this.csMenu;
            this.tvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvData.FullRowSelect = true;
            this.tvData.HideSelection = false;
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Margin = new System.Windows.Forms.Padding(6);
            this.tvData.Name = "tvData";
            this.tvData.Size = new System.Drawing.Size(720, 1306);
            this.tvData.TabIndex = 0;
            this.tvData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvData_AfterSelect);
            this.tvData.DoubleClick += new System.EventHandler(this.tvData_DoubleClick);
            // 
            // csMenu
            // 
            this.csMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.csMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsContextAdd,
            this.tsContextDelete,
            this.tsContextDuplicate,
            this.tsContextRename,
            this.tsContextSort});
            this.csMenu.Name = "csMenu";
            this.csMenu.Size = new System.Drawing.Size(175, 184);
            // 
            // tsContextAdd
            // 
            this.tsContextAdd.Name = "tsContextAdd";
            this.tsContextAdd.Size = new System.Drawing.Size(174, 36);
            this.tsContextAdd.Text = "Add";
            this.tsContextAdd.Click += new System.EventHandler(this.bAddString_Click);
            // 
            // tsContextDelete
            // 
            this.tsContextDelete.Name = "tsContextDelete";
            this.tsContextDelete.Size = new System.Drawing.Size(174, 36);
            this.tsContextDelete.Text = "Delete";
            this.tsContextDelete.Click += new System.EventHandler(this.bDeleteString_Click);
            // 
            // tsContextDuplicate
            // 
            this.tsContextDuplicate.Name = "tsContextDuplicate";
            this.tsContextDuplicate.Size = new System.Drawing.Size(174, 36);
            this.tsContextDuplicate.Text = "Duplicate";
            this.tsContextDuplicate.Click += new System.EventHandler(this.bDuplicateString_Click);
            // 
            // tsContextRename
            // 
            this.tsContextRename.Name = "tsContextRename";
            this.tsContextRename.Size = new System.Drawing.Size(174, 36);
            this.tsContextRename.Text = "Rename";
            this.tsContextRename.Click += new System.EventHandler(this.bStringRename_Click);
            // 
            // tsContextSort
            // 
            this.tsContextSort.Name = "tsContextSort";
            this.tsContextSort.Size = new System.Drawing.Size(174, 36);
            this.tsContextSort.Text = "Sort";
            this.tsContextSort.Click += new System.EventHandler(this.bStringsSort_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.bStringsSort);
            this.pnlButtons.Controls.Add(this.bDuplicateString);
            this.pnlButtons.Controls.Add(this.bStringRename);
            this.pnlButtons.Controls.Add(this.bDeleteString);
            this.pnlButtons.Controls.Add(this.bAddString);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(720, 57);
            this.pnlButtons.TabIndex = 1;
            // 
            // bStringsSort
            // 
            this.bStringsSort.Location = new System.Drawing.Point(523, 6);
            this.bStringsSort.Margin = new System.Windows.Forms.Padding(6);
            this.bStringsSort.Name = "bStringsSort";
            this.bStringsSort.Size = new System.Drawing.Size(115, 42);
            this.bStringsSort.TabIndex = 13;
            this.bStringsSort.Text = "&Sort";
            this.bStringsSort.UseVisualStyleBackColor = true;
            this.bStringsSort.Click += new System.EventHandler(this.bStringsSort_Click);
            // 
            // bDuplicateString
            // 
            this.bDuplicateString.Location = new System.Drawing.Point(269, 6);
            this.bDuplicateString.Margin = new System.Windows.Forms.Padding(6);
            this.bDuplicateString.Name = "bDuplicateString";
            this.bDuplicateString.Size = new System.Drawing.Size(115, 42);
            this.bDuplicateString.TabIndex = 12;
            this.bDuplicateString.Text = "D&uplicate";
            this.bDuplicateString.UseVisualStyleBackColor = true;
            this.bDuplicateString.Click += new System.EventHandler(this.bDuplicateString_Click);
            // 
            // bStringRename
            // 
            this.bStringRename.Location = new System.Drawing.Point(396, 6);
            this.bStringRename.Margin = new System.Windows.Forms.Padding(6);
            this.bStringRename.Name = "bStringRename";
            this.bStringRename.Size = new System.Drawing.Size(115, 42);
            this.bStringRename.TabIndex = 11;
            this.bStringRename.Text = "&Rename";
            this.bStringRename.UseVisualStyleBackColor = true;
            this.bStringRename.Click += new System.EventHandler(this.bStringRename_Click);
            // 
            // bDeleteString
            // 
            this.bDeleteString.Location = new System.Drawing.Point(142, 6);
            this.bDeleteString.Margin = new System.Windows.Forms.Padding(6);
            this.bDeleteString.Name = "bDeleteString";
            this.bDeleteString.Size = new System.Drawing.Size(115, 42);
            this.bDeleteString.TabIndex = 10;
            this.bDeleteString.Text = "&Delete";
            this.bDeleteString.UseVisualStyleBackColor = true;
            this.bDeleteString.Click += new System.EventHandler(this.bDeleteString_Click);
            // 
            // bAddString
            // 
            this.bAddString.Location = new System.Drawing.Point(15, 6);
            this.bAddString.Margin = new System.Windows.Forms.Padding(6);
            this.bAddString.Name = "bAddString";
            this.bAddString.Size = new System.Drawing.Size(115, 42);
            this.bAddString.TabIndex = 9;
            this.bAddString.Text = "&Add";
            this.bAddString.UseVisualStyleBackColor = true;
            this.bAddString.Click += new System.EventHandler(this.bAddString_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.StatusStrip.Location = new System.Drawing.Point(0, 1341);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1444, 22);
            this.StatusStrip.TabIndex = 6;
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 13);
            // 
            // gbxContent
            // 
            this.gbxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxContent.Controls.Add(this.bCopyAll);
            this.gbxContent.Controls.Add(this.bRevertString);
            this.gbxContent.Controls.Add(this.bSaveString);
            this.gbxContent.Controls.Add(this.bSetUserDate);
            this.gbxContent.Controls.Add(this.bSetUUIDCont);
            this.gbxContent.Controls.Add(this.tbUUIDCont);
            this.gbxContent.Controls.Add(this.label8);
            this.gbxContent.Controls.Add(this.cbxStatus);
            this.gbxContent.Controls.Add(this.cbxLanguage);
            this.gbxContent.Controls.Add(this.label6);
            this.gbxContent.Controls.Add(this.label1);
            this.gbxContent.Controls.Add(this.dtpModDate);
            this.gbxContent.Controls.Add(this.tbContent);
            this.gbxContent.Controls.Add(this.label5);
            this.gbxContent.Controls.Add(this.label2);
            this.gbxContent.Controls.Add(this.tbModName);
            this.gbxContent.Controls.Add(this.label4);
            this.gbxContent.Location = new System.Drawing.Point(6, 170);
            this.gbxContent.Margin = new System.Windows.Forms.Padding(6);
            this.gbxContent.Name = "gbxContent";
            this.gbxContent.Padding = new System.Windows.Forms.Padding(6);
            this.gbxContent.Size = new System.Drawing.Size(1373, 1171);
            this.gbxContent.TabIndex = 5;
            this.gbxContent.TabStop = false;
            this.gbxContent.Text = "Content";
            // 
            // bCopyAll
            // 
            this.bCopyAll.Location = new System.Drawing.Point(564, 175);
            this.bCopyAll.Margin = new System.Windows.Forms.Padding(6);
            this.bCopyAll.Name = "bCopyAll";
            this.bCopyAll.Size = new System.Drawing.Size(138, 42);
            this.bCopyAll.TabIndex = 17;
            this.bCopyAll.Text = "&Copy to All";
            this.bCopyAll.UseVisualStyleBackColor = true;
            this.bCopyAll.Click += new System.EventHandler(this.bCopyAll_Click);
            // 
            // bRevertString
            // 
            this.bRevertString.Location = new System.Drawing.Point(1243, 89);
            this.bRevertString.Margin = new System.Windows.Forms.Padding(6);
            this.bRevertString.Name = "bRevertString";
            this.bRevertString.Size = new System.Drawing.Size(138, 42);
            this.bRevertString.TabIndex = 16;
            this.bRevertString.Text = "Revert";
            this.bRevertString.UseVisualStyleBackColor = true;
            this.bRevertString.Click += new System.EventHandler(this.bRevertString_Click);
            // 
            // bSaveString
            // 
            this.bSaveString.Location = new System.Drawing.Point(1243, 31);
            this.bSaveString.Margin = new System.Windows.Forms.Padding(6);
            this.bSaveString.Name = "bSaveString";
            this.bSaveString.Size = new System.Drawing.Size(138, 42);
            this.bSaveString.TabIndex = 15;
            this.bSaveString.Text = "&Save";
            this.bSaveString.UseVisualStyleBackColor = true;
            this.bSaveString.Click += new System.EventHandler(this.bSaveString_Click);
            // 
            // bSetUserDate
            // 
            this.bSetUserDate.Location = new System.Drawing.Point(864, 79);
            this.bSetUserDate.Margin = new System.Windows.Forms.Padding(6);
            this.bSetUserDate.Name = "bSetUserDate";
            this.bSetUserDate.Size = new System.Drawing.Size(138, 42);
            this.bSetUserDate.TabIndex = 14;
            this.bSetUserDate.Text = "Set";
            this.bSetUserDate.UseVisualStyleBackColor = true;
            this.bSetUserDate.Click += new System.EventHandler(this.bSetUserDate_Click);
            // 
            // bSetUUIDCont
            // 
            this.bSetUUIDCont.Location = new System.Drawing.Point(864, 31);
            this.bSetUUIDCont.Margin = new System.Windows.Forms.Padding(6);
            this.bSetUUIDCont.Name = "bSetUUIDCont";
            this.bSetUUIDCont.Size = new System.Drawing.Size(138, 42);
            this.bSetUUIDCont.TabIndex = 9;
            this.bSetUUIDCont.Text = "Set";
            this.bSetUUIDCont.UseVisualStyleBackColor = true;
            this.bSetUUIDCont.Click += new System.EventHandler(this.bSetUUIDCont_Click);
            // 
            // tbUUIDCont
            // 
            this.tbUUIDCont.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUUIDCont.Location = new System.Drawing.Point(231, 35);
            this.tbUUIDCont.Margin = new System.Windows.Forms.Padding(6);
            this.tbUUIDCont.Name = "tbUUIDCont";
            this.tbUUIDCont.Size = new System.Drawing.Size(618, 27);
            this.tbUUIDCont.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "UUID";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Complete",
            "Translation Needed",
            "Work in Progress"});
            this.cbxStatus.Location = new System.Drawing.Point(231, 134);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(321, 32);
            this.cbxStatus.TabIndex = 11;
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Location = new System.Drawing.Point(231, 181);
            this.cbxLanguage.Margin = new System.Windows.Forms.Padding(6);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(321, 32);
            this.cbxLanguage.TabIndex = 1;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Localization Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language";
            // 
            // dtpModDate
            // 
            this.dtpModDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpModDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModDate.Location = new System.Drawing.Point(463, 84);
            this.dtpModDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpModDate.Name = "dtpModDate";
            this.dtpModDate.Size = new System.Drawing.Size(270, 29);
            this.dtpModDate.TabIndex = 9;
            this.dtpModDate.Value = new System.DateTime(2020, 11, 5, 19, 22, 27, 0);
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(231, 225);
            this.tbContent.Margin = new System.Windows.Forms.Padding(6);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContent.Size = new System.Drawing.Size(1111, 946);
            this.tbContent.TabIndex = 3;
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "at";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(231, 85);
            this.tbModName.Margin = new System.Windows.Forms.Padding(6);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(180, 29);
            this.tbModName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Modified By";
            // 
            // gbxGlobal
            // 
            this.gbxGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGlobal.Controls.Add(this.bSetUUID);
            this.gbxGlobal.Controls.Add(this.tbUUID);
            this.gbxGlobal.Controls.Add(this.label7);
            this.gbxGlobal.Controls.Add(this.tbVersion);
            this.gbxGlobal.Controls.Add(this.label3);
            this.gbxGlobal.Location = new System.Drawing.Point(6, 6);
            this.gbxGlobal.Margin = new System.Windows.Forms.Padding(6);
            this.gbxGlobal.Name = "gbxGlobal";
            this.gbxGlobal.Padding = new System.Windows.Forms.Padding(6);
            this.gbxGlobal.Size = new System.Drawing.Size(1373, 153);
            this.gbxGlobal.TabIndex = 4;
            this.gbxGlobal.TabStop = false;
            this.gbxGlobal.Text = "Global Data";
            // 
            // bSetUUID
            // 
            this.bSetUUID.Location = new System.Drawing.Point(864, 94);
            this.bSetUUID.Margin = new System.Windows.Forms.Padding(6);
            this.bSetUUID.Name = "bSetUUID";
            this.bSetUUID.Size = new System.Drawing.Size(138, 42);
            this.bSetUUID.TabIndex = 8;
            this.bSetUUID.Text = "Set";
            this.bSetUUID.UseVisualStyleBackColor = true;
            this.bSetUUID.Click += new System.EventHandler(this.bSetUUID_Click);
            // 
            // tbUUID
            // 
            this.tbUUID.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUUID.Location = new System.Drawing.Point(231, 98);
            this.tbUUID.Margin = new System.Windows.Forms.Padding(6);
            this.tbUUID.Name = "tbUUID";
            this.tbUUID.Size = new System.Drawing.Size(618, 27);
            this.tbUUID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "UUID";
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(231, 50);
            this.tbVersion.Margin = new System.Windows.Forms.Padding(6);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(180, 29);
            this.tbVersion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version";
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "LOC";
            this.ofdOpen.Filter = "Localization File (*.loc)|*.loc|All Files (*.*)|*.*";
            this.ofdOpen.Title = "Open Localization File";
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "LOC";
            this.sfdSave.Filter = "Localization File (*.loc)|*.loc";
            this.sfdSave.Title = "Save Localization File";
            // 
            // tmrDirty
            // 
            this.tmrDirty.Enabled = true;
            this.tmrDirty.Interval = 250;
            this.tmrDirty.Tick += new System.EventHandler(this.tmrDirty_Tick);
            // 
            // ofdImport
            // 
            this.ofdImport.DefaultExt = "CSV";
            this.ofdImport.Filter = "Comma-separated Value (*.csv)|*.csv";
            this.ofdImport.Title = "Import Translation File";
            // 
            // MSFSLocalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2171, 1405);
            this.Controls.Add(this.scPanels);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MSFSLocalizer";
            this.Text = "MSFS Localizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSFSLocalizer_FormClosing);
            this.Load += new System.EventHandler(this.MSFSLocalizer_Load);
            this.Shown += new System.EventHandler(this.MSFSLocalizer_Shown);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.scPanels.Panel1.ResumeLayout(false);
            this.scPanels.Panel2.ResumeLayout(false);
            this.scPanels.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).EndInit();
            this.scPanels.ResumeLayout(false);
            this.pnlTree.ResumeLayout(false);
            this.csMenu.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.gbxContent.ResumeLayout(false);
            this.gbxContent.PerformLayout();
            this.gbxGlobal.ResumeLayout(false);
            this.gbxGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileNew;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator miFileSep1;
        private System.Windows.Forms.ToolStripMenuItem miFileOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.SplitContainer scPanels;
        private System.Windows.Forms.TreeView tvData;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxContent;
        private System.Windows.Forms.GroupBox gbxGlobal;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpModDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUUIDCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUUID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bSetUUIDCont;
        private System.Windows.Forms.Button bSetUUID;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Button bSetUserDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button bDeleteString;
        private System.Windows.Forms.Button bAddString;
        private System.Windows.Forms.Button bStringRename;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Button bRevertString;
        private System.Windows.Forms.Button bSaveString;
        private System.Windows.Forms.Button bCopyAll;
        private System.Windows.Forms.Button bDuplicateString;
        private System.Windows.Forms.Timer tmrDirty;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripSeparator miFileSep2;
        private System.Windows.Forms.Button bStringsSort;
        private System.Windows.Forms.ContextMenuStrip csMenu;
        private System.Windows.Forms.ToolStripMenuItem tsContextDelete;
        private System.Windows.Forms.ToolStripMenuItem tsContextAdd;
        private System.Windows.Forms.ToolStripMenuItem tsContextDuplicate;
        private System.Windows.Forms.ToolStripMenuItem tsContextRename;
        private System.Windows.Forms.ToolStripMenuItem tsContextSort;
        private System.Windows.Forms.ToolStripMenuItem miTranslation;
        private System.Windows.Forms.ToolStripMenuItem miTranslationEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miTranslationExport;
        private System.Windows.Forms.ToolStripMenuItem miTranslationImport;
        private System.Windows.Forms.OpenFileDialog ofdImport;
    }
}

