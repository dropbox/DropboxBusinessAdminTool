namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class PaperView
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
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            DfBAdminToolkit.Common.Component.Office2010Blue office2010Blue1 = new DfBAdminToolkit.Common.Component.Office2010Blue();
            this.tableLayoutPanel_Paper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPaperCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_PaperAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_TeamFoldersAccessToken = new System.Windows.Forms.Label();
            this.textBox_PaperAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_PaperLoadGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_PaperLoadPaper = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.legacyWarningLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.legacyWarningLabel = new System.Windows.Forms.Label();
            this.legacyWarningLink = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel_PaperMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_PaperMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnPaper_PaperName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_PaperId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_FolderPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Owner = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_CreatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_LastUpdatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_LastEditor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Revision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_PaperCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_ExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperDownloadFolder = new System.Windows.Forms.Button();
            this.textBoxPaper = new System.Windows.Forms.TextBox();
            this.buttonEx_PaperDelete = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperDownload = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.radioButton_Permanent = new System.Windows.Forms.RadioButton();
            this.radioButton_Archive = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_Paper.SuspendLayout();
            this.tableLayoutPanelPaperCommandGroup.SuspendLayout();
            this.tableLayoutPanel_PaperAccessToken.SuspendLayout();
            this.tableLayoutPanel_PaperLoadGroup.SuspendLayout();
            this.legacyWarningLayoutPanel.SuspendLayout();
            this.tableLayoutPanel_PaperMembersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_PaperMembers)).BeginInit();
            this.tableLayoutPanel_PaperCommandGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Paper
            // 
            this.tableLayoutPanel_Paper.ColumnCount = 1;
            this.tableLayoutPanel_Paper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Paper.Controls.Add(this.tableLayoutPanelPaperCommandGroup, 0, 0);
            this.tableLayoutPanel_Paper.Controls.Add(this.tableLayoutPanel_PaperMembersGroup, 0, 2);
            this.tableLayoutPanel_Paper.Controls.Add(this.tableLayoutPanel_PaperCommandGroup, 0, 3);
            this.tableLayoutPanel_Paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Paper.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_Paper.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Paper.Name = "tableLayoutPanel_Paper";
            this.tableLayoutPanel_Paper.RowCount = 4;
            this.tableLayoutPanel_Paper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel_Paper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_Paper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Paper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Paper.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_Paper.TabIndex = 1;
            // 
            // tableLayoutPanelPaperCommandGroup
            // 
            this.tableLayoutPanelPaperCommandGroup.ColumnCount = 3;
            this.tableLayoutPanelPaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanelPaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPaperCommandGroup.Controls.Add(this.tableLayoutPanel_PaperAccessToken, 2, 0);
            this.tableLayoutPanelPaperCommandGroup.Controls.Add(this.tableLayoutPanel_PaperLoadGroup, 2, 1);
            this.tableLayoutPanelPaperCommandGroup.Controls.Add(this.legacyWarningLayoutPanel, 0, 0);
            this.tableLayoutPanelPaperCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaperCommandGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPaperCommandGroup.Name = "tableLayoutPanelPaperCommandGroup";
            this.tableLayoutPanelPaperCommandGroup.RowCount = 2;
            this.tableLayoutPanelPaperCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelPaperCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPaperCommandGroup.Size = new System.Drawing.Size(1064, 64);
            this.tableLayoutPanelPaperCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_PaperAccessToken
            // 
            this.tableLayoutPanel_PaperAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_PaperAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_PaperAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaperAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_PaperAccessToken.Controls.Add(this.label_TeamFoldersAccessToken, 0, 0);
            this.tableLayoutPanel_PaperAccessToken.Controls.Add(this.textBox_PaperAccessToken, 1, 0);
            this.tableLayoutPanel_PaperAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_PaperAccessToken.Location = new System.Drawing.Point(566, 1);
            this.tableLayoutPanel_PaperAccessToken.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_PaperAccessToken.Name = "tableLayoutPanel_PaperAccessToken";
            this.tableLayoutPanel_PaperAccessToken.RowCount = 1;
            this.tableLayoutPanel_PaperAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaperAccessToken.Size = new System.Drawing.Size(497, 25);
            this.tableLayoutPanel_PaperAccessToken.TabIndex = 0;
            // 
            // label_TeamFoldersAccessToken
            // 
            this.label_TeamFoldersAccessToken.AutoSize = true;
            this.label_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TeamFoldersAccessToken.Location = new System.Drawing.Point(3, 0);
            this.label_TeamFoldersAccessToken.Name = "label_TeamFoldersAccessToken";
            this.label_TeamFoldersAccessToken.Size = new System.Drawing.Size(84, 25);
            this.label_TeamFoldersAccessToken.TabIndex = 0;
            this.label_TeamFoldersAccessToken.Text = "Access Token";
            this.label_TeamFoldersAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_TeamFoldersAccessToken.Visible = false;
            // 
            // textBox_PaperAccessToken
            // 
            this.textBox_PaperAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PaperAccessToken.FileFilter = null;
            this.textBox_PaperAccessToken.Location = new System.Drawing.Point(93, 3);
            this.textBox_PaperAccessToken.Name = "textBox_PaperAccessToken";
            this.textBox_PaperAccessToken.Size = new System.Drawing.Size(401, 22);
            this.textBox_PaperAccessToken.TabIndex = 1;
            this.textBox_PaperAccessToken.Visible = false;
            // 
            // tableLayoutPanel_PaperLoadGroup
            // 
            this.tableLayoutPanel_PaperLoadGroup.ColumnCount = 3;
            this.tableLayoutPanel_PaperLoadGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93534F));
            this.tableLayoutPanel_PaperLoadGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel_PaperLoadGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel_PaperLoadGroup.Controls.Add(this.buttonEx_PaperLoadPaper, 2, 0);
            this.tableLayoutPanel_PaperLoadGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_PaperLoadGroup.Location = new System.Drawing.Point(568, 30);
            this.tableLayoutPanel_PaperLoadGroup.Name = "tableLayoutPanel_PaperLoadGroup";
            this.tableLayoutPanel_PaperLoadGroup.RowCount = 1;
            this.tableLayoutPanel_PaperLoadGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_PaperLoadGroup.Size = new System.Drawing.Size(493, 31);
            this.tableLayoutPanel_PaperLoadGroup.TabIndex = 3;
            // 
            // buttonEx_PaperLoadPaper
            // 
            office2010White1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010White1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010White1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010White1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010White1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            office2010White1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            office2010White1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010White1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010White1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.TextColor = System.Drawing.Color.Black;
            this.buttonEx_PaperLoadPaper.ColorTable = office2010White1;
            this.buttonEx_PaperLoadPaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_PaperLoadPaper.Location = new System.Drawing.Point(256, 4);
            this.buttonEx_PaperLoadPaper.Name = "buttonEx_PaperLoadPaper";
            this.buttonEx_PaperLoadPaper.Size = new System.Drawing.Size(234, 24);
            this.buttonEx_PaperLoadPaper.TabIndex = 4;
            this.buttonEx_PaperLoadPaper.Text = "Load Paper Docs";
            this.buttonEx_PaperLoadPaper.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_PaperLoadPaper.UseVisualStyleBackColor = true;
            // 
            // legacyWarningLayoutPanel
            // 
            this.legacyWarningLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.legacyWarningLayoutPanel.Controls.Add(this.legacyWarningLabel);
            this.legacyWarningLayoutPanel.Controls.Add(this.legacyWarningLink);
            this.legacyWarningLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.legacyWarningLayoutPanel.Name = "legacyWarningLayoutPanel";
            this.tableLayoutPanelPaperCommandGroup.SetRowSpan(this.legacyWarningLayoutPanel, 2);
            this.legacyWarningLayoutPanel.Size = new System.Drawing.Size(493, 58);
            this.legacyWarningLayoutPanel.TabIndex = 4;
            // 
            // legacyWarningLabel
            // 
            this.legacyWarningLabel.AutoSize = true;
            this.legacyWarningLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.legacyWarningLabel.ForeColor = System.Drawing.Color.Black;
            this.legacyWarningLabel.Location = new System.Drawing.Point(3, 0);
            this.legacyWarningLabel.Name = "legacyWarningLabel";
            this.legacyWarningLabel.Size = new System.Drawing.Size(376, 21);
            this.legacyWarningLabel.TabIndex = 0;
            this.legacyWarningLabel.Text = "⚠ Paper content may appear in the team content tab.";
            this.legacyWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // legacyWarningLink
            // 
            this.legacyWarningLink.AutoSize = true;
            this.legacyWarningLink.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.legacyWarningLink.Location = new System.Drawing.Point(3, 21);
            this.legacyWarningLink.Name = "legacyWarningLink";
            this.legacyWarningLink.Size = new System.Drawing.Size(174, 21);
            this.legacyWarningLink.TabIndex = 1;
            this.legacyWarningLink.TabStop = true;
            this.legacyWarningLink.Text = "Click here for more info";
            this.legacyWarningLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.legacyWarningLink_LinkClicked);
            // 
            // tableLayoutPanel_PaperMembersGroup
            // 
            this.tableLayoutPanel_PaperMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_PaperMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaperMembersGroup.Controls.Add(this.objectListView_PaperMembers, 0, 0);
            this.tableLayoutPanel_PaperMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_PaperMembersGroup.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel_PaperMembersGroup.Name = "tableLayoutPanel_PaperMembersGroup";
            this.tableLayoutPanel_PaperMembersGroup.RowCount = 1;
            this.tableLayoutPanel_PaperMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaperMembersGroup.Size = new System.Drawing.Size(1064, 545);
            this.tableLayoutPanel_PaperMembersGroup.TabIndex = 1;
            // 
            // objectListView_PaperMembers
            // 
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_PaperName);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_PaperId);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_FolderPath);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_Status);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_Owner);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_CreatedDate);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_LastUpdatedDate);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_LastEditor);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_Revision);
            this.objectListView_PaperMembers.CellEditUseWholeCell = false;
            this.objectListView_PaperMembers.CheckBoxes = true;
            this.objectListView_PaperMembers.CheckedAspectName = "IsChecked";
            this.objectListView_PaperMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnPaper_PaperName,
            this.olvColumnPaper_PaperId,
            this.olvColumnPaper_FolderPath,
            this.olvColumnPaper_Status,
            this.olvColumnPaper_Owner,
            this.olvColumnPaper_CreatedDate,
            this.olvColumnPaper_LastUpdatedDate,
            this.olvColumnPaper_LastEditor,
            this.olvColumnPaper_Revision});
            this.objectListView_PaperMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_PaperMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_PaperMembers.EmptyListMsg = "No Result";
            this.objectListView_PaperMembers.FullRowSelect = true;
            this.objectListView_PaperMembers.HasCollapsibleGroups = false;
            this.objectListView_PaperMembers.HideSelection = false;
            this.objectListView_PaperMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_PaperMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_PaperMembers.Location = new System.Drawing.Point(3, 3);
            this.objectListView_PaperMembers.Name = "objectListView_PaperMembers";
            this.objectListView_PaperMembers.ShowGroups = false;
            this.objectListView_PaperMembers.Size = new System.Drawing.Size(1058, 539);
            this.objectListView_PaperMembers.TabIndex = 1;
            this.objectListView_PaperMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_PaperMembers.UseNotifyPropertyChanged = true;
            this.objectListView_PaperMembers.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnPaper_PaperName
            // 
            this.olvColumnPaper_PaperName.AspectName = "PaperName";
            this.olvColumnPaper_PaperName.HeaderCheckBox = true;
            this.olvColumnPaper_PaperName.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnPaper_PaperName.Hideable = false;
            this.olvColumnPaper_PaperName.MinimumWidth = 150;
            this.olvColumnPaper_PaperName.Text = "PaperName";
            this.olvColumnPaper_PaperName.Width = 150;
            // 
            // olvColumnPaper_PaperId
            // 
            this.olvColumnPaper_PaperId.AspectName = "PaperId";
            this.olvColumnPaper_PaperId.MinimumWidth = 100;
            this.olvColumnPaper_PaperId.Text = "PaperId";
            this.olvColumnPaper_PaperId.Width = 100;
            // 
            // olvColumnPaper_FolderPath
            // 
            this.olvColumnPaper_FolderPath.AspectName = "FolderPath";
            this.olvColumnPaper_FolderPath.MinimumWidth = 75;
            this.olvColumnPaper_FolderPath.Text = "FolderPath";
            this.olvColumnPaper_FolderPath.Width = 75;
            // 
            // olvColumnPaper_Status
            // 
            this.olvColumnPaper_Status.AspectName = "Status";
            this.olvColumnPaper_Status.MinimumWidth = 50;
            this.olvColumnPaper_Status.Text = "Status";
            this.olvColumnPaper_Status.Width = 50;
            // 
            // olvColumnPaper_Owner
            // 
            this.olvColumnPaper_Owner.AspectName = "Owner";
            this.olvColumnPaper_Owner.MaximumWidth = 120;
            this.olvColumnPaper_Owner.Text = "Owner";
            this.olvColumnPaper_Owner.Width = 120;
            // 
            // olvColumnPaper_CreatedDate
            // 
            this.olvColumnPaper_CreatedDate.AspectName = "CreatedDate";
            this.olvColumnPaper_CreatedDate.MaximumWidth = 110;
            this.olvColumnPaper_CreatedDate.Text = "CreatedDate";
            this.olvColumnPaper_CreatedDate.Width = 110;
            // 
            // olvColumnPaper_LastUpdatedDate
            // 
            this.olvColumnPaper_LastUpdatedDate.AspectName = "LastUpdatedDate";
            this.olvColumnPaper_LastUpdatedDate.MaximumWidth = 110;
            this.olvColumnPaper_LastUpdatedDate.Text = "LastUpdatedDate";
            this.olvColumnPaper_LastUpdatedDate.Width = 110;
            // 
            // olvColumnPaper_LastEditor
            // 
            this.olvColumnPaper_LastEditor.AspectName = "LastEditor";
            this.olvColumnPaper_LastEditor.MaximumWidth = 120;
            this.olvColumnPaper_LastEditor.Text = "LastEditor";
            this.olvColumnPaper_LastEditor.Width = 120;
            // 
            // olvColumnPaper_Revision
            // 
            this.olvColumnPaper_Revision.AspectName = "Revision";
            this.olvColumnPaper_Revision.MaximumWidth = 60;
            this.olvColumnPaper_Revision.Text = "Revision";
            // 
            // tableLayoutPanel_PaperCommandGroup
            // 
            this.tableLayoutPanel_PaperCommandGroup.ColumnCount = 10;
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel_PaperCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.buttonEx_ExportToCSV, 8, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.buttonEx_PaperDownloadFolder, 2, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.textBoxPaper, 1, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.buttonEx_PaperDelete, 4, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.buttonEx_PaperDownload, 0, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.radioButton_Permanent, 6, 0);
            this.tableLayoutPanel_PaperCommandGroup.Controls.Add(this.radioButton_Archive, 5, 0);
            this.tableLayoutPanel_PaperCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_PaperCommandGroup.Location = new System.Drawing.Point(3, 631);
            this.tableLayoutPanel_PaperCommandGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_PaperCommandGroup.Name = "tableLayoutPanel_PaperCommandGroup";
            this.tableLayoutPanel_PaperCommandGroup.RowCount = 1;
            this.tableLayoutPanel_PaperCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_PaperCommandGroup.Size = new System.Drawing.Size(1064, 36);
            this.tableLayoutPanel_PaperCommandGroup.TabIndex = 3;
            // 
            // buttonEx_ExportToCSV
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.buttonEx_ExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_ExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_ExportToCSV.Location = new System.Drawing.Point(587, 3);
            this.buttonEx_ExportToCSV.Name = "buttonEx_ExportToCSV";
            this.buttonEx_ExportToCSV.Size = new System.Drawing.Size(95, 30);
            this.buttonEx_ExportToCSV.TabIndex = 14;
            this.buttonEx_ExportToCSV.Text = "Export To CSV";
            this.buttonEx_ExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_ExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_PaperDownloadFolder
            // 
            this.buttonEx_PaperDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_PaperDownloadFolder.Location = new System.Drawing.Point(261, 9);
            this.buttonEx_PaperDownloadFolder.Name = "buttonEx_PaperDownloadFolder";
            this.buttonEx_PaperDownloadFolder.Size = new System.Drawing.Size(25, 18);
            this.buttonEx_PaperDownloadFolder.TabIndex = 13;
            this.buttonEx_PaperDownloadFolder.Text = "...";
            this.buttonEx_PaperDownloadFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxPaper
            // 
            this.textBoxPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaper.Location = new System.Drawing.Point(96, 7);
            this.textBoxPaper.Name = "textBoxPaper";
            this.textBoxPaper.Size = new System.Drawing.Size(159, 22);
            this.textBoxPaper.TabIndex = 12;
            // 
            // buttonEx_PaperDelete
            // 
            this.buttonEx_PaperDelete.ColorTable = office2010Blue1;
            this.buttonEx_PaperDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperDelete.Location = new System.Drawing.Point(303, 3);
            this.buttonEx_PaperDelete.Name = "buttonEx_PaperDelete";
            this.buttonEx_PaperDelete.Size = new System.Drawing.Size(67, 30);
            this.buttonEx_PaperDelete.TabIndex = 11;
            this.buttonEx_PaperDelete.Text = "Delete Docs";
            this.buttonEx_PaperDelete.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEx_PaperDownload
            // 
            this.buttonEx_PaperDownload.ColorTable = office2010Blue1;
            this.buttonEx_PaperDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperDownload.Location = new System.Drawing.Point(3, 3);
            this.buttonEx_PaperDownload.Name = "buttonEx_PaperDownload";
            this.buttonEx_PaperDownload.Size = new System.Drawing.Size(87, 30);
            this.buttonEx_PaperDownload.TabIndex = 8;
            this.buttonEx_PaperDownload.Text = "Download Docs";
            this.buttonEx_PaperDownload.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperDownload.UseVisualStyleBackColor = true;
            // 
            // radioButton_Permanent
            // 
            this.radioButton_Permanent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Permanent.AutoSize = true;
            this.radioButton_Permanent.Location = new System.Drawing.Point(446, 9);
            this.radioButton_Permanent.Name = "radioButton_Permanent";
            this.radioButton_Permanent.Size = new System.Drawing.Size(86, 17);
            this.radioButton_Permanent.TabIndex = 9;
            this.radioButton_Permanent.TabStop = true;
            this.radioButton_Permanent.Text = "Permanent";
            this.radioButton_Permanent.UseVisualStyleBackColor = true;
            // 
            // radioButton_Archive
            // 
            this.radioButton_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Archive.AutoSize = true;
            this.radioButton_Archive.Location = new System.Drawing.Point(376, 9);
            this.radioButton_Archive.Name = "radioButton_Archive";
            this.radioButton_Archive.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Archive.TabIndex = 10;
            this.radioButton_Archive.TabStop = true;
            this.radioButton_Archive.Text = "Archived";
            this.radioButton_Archive.UseVisualStyleBackColor = true;
            // 
            // PaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_Paper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaperView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_Paper.ResumeLayout(false);
            this.tableLayoutPanelPaperCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_PaperAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_PaperAccessToken.PerformLayout();
            this.tableLayoutPanel_PaperLoadGroup.ResumeLayout(false);
            this.legacyWarningLayoutPanel.ResumeLayout(false);
            this.legacyWarningLayoutPanel.PerformLayout();
            this.tableLayoutPanel_PaperMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_PaperMembers)).EndInit();
            this.tableLayoutPanel_PaperCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_PaperCommandGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Paper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaperCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PaperAccessToken;
        private System.Windows.Forms.Label label_TeamFoldersAccessToken;
        private TextBoxEx textBox_PaperAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PaperMembersGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_PaperMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_PaperName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PaperCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_PaperLoadGroup;
        private ButtonEx buttonEx_PaperLoadPaper;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_Status;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_PaperId;
        private ButtonEx buttonEx_PaperDownload;
        private System.Windows.Forms.RadioButton radioButton_Permanent;
        private System.Windows.Forms.RadioButton radioButton_Archive;
        private ButtonEx buttonEx_PaperDelete;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_Owner;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_CreatedDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_LastUpdatedDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_LastEditor;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_Revision;
        private System.Windows.Forms.Button buttonEx_PaperDownloadFolder;
        private System.Windows.Forms.TextBox textBoxPaper;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_FolderPath;
        private ButtonEx buttonEx_ExportToCSV;
        private System.Windows.Forms.FlowLayoutPanel legacyWarningLayoutPanel;
        private System.Windows.Forms.Label legacyWarningLabel;
        private System.Windows.Forms.LinkLabel legacyWarningLink;
    }
}