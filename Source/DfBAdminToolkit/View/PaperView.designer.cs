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
            this.tableLayoutPanel_TeamFolders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_TeamFoldersAccessToken = new System.Windows.Forms.Label();
            this.textBox_PaperAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_PaperLoadPaper = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_PaperDownloadFolder = new System.Windows.Forms.Button();
            this.textBoxPaper = new System.Windows.Forms.TextBox();
            this.buttonEx_PaperDelete = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperDownload = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.radioButton_Permanent = new System.Windows.Forms.RadioButton();
            this.radioButton_Archive = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_TeamFolders.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersMembersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_PaperMembers)).BeginInit();
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_TeamFolders
            // 
            this.tableLayoutPanel_TeamFolders.ColumnCount = 1;
            this.tableLayoutPanel_TeamFolders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersCommandGroup, 0, 0);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersMembersGroup, 0, 2);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersProvisionCommandGroup, 0, 3);
            this.tableLayoutPanel_TeamFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFolders.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_TeamFolders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TeamFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFolders.Name = "tableLayoutPanel_TeamFolders";
            this.tableLayoutPanel_TeamFolders.RowCount = 4;
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_TeamFolders.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_TeamFolders.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamFoldersCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Size = new System.Drawing.Size(1062, 98);
            this.tableLayoutPanel_TeamFoldersCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersAccessToken
            // 
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.label_TeamFoldersAccessToken, 0, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_PaperAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(588, 2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(472, 38);
            this.tableLayoutPanel_TeamFoldersAccessToken.TabIndex = 0;
            // 
            // label_TeamFoldersAccessToken
            // 
            this.label_TeamFoldersAccessToken.AutoSize = true;
            this.label_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TeamFoldersAccessToken.Location = new System.Drawing.Point(4, 0);
            this.label_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TeamFoldersAccessToken.Name = "label_TeamFoldersAccessToken";
            this.label_TeamFoldersAccessToken.Size = new System.Drawing.Size(127, 38);
            this.label_TeamFoldersAccessToken.TabIndex = 0;
            this.label_TeamFoldersAccessToken.Text = "Access Token";
            this.label_TeamFoldersAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_TeamFoldersAccessToken.Visible = false;
            // 
            // textBox_PaperAccessToken
            // 
            this.textBox_PaperAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PaperAccessToken.FileFilter = null;
            this.textBox_PaperAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_PaperAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_PaperAccessToken.Name = "textBox_PaperAccessToken";
            this.textBox_PaperAccessToken.Size = new System.Drawing.Size(329, 22);
            this.textBox_PaperAccessToken.TabIndex = 1;
            this.textBox_PaperAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(4, 47);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(467, 46);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93534F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_PaperLoadPaper, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(590, 47);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(468, 46);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
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
            this.buttonEx_PaperLoadPaper.Location = new System.Drawing.Point(244, 6);
            this.buttonEx_PaperLoadPaper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_PaperLoadPaper.Name = "buttonEx_PaperLoadPaper";
            this.buttonEx_PaperLoadPaper.Size = new System.Drawing.Size(220, 37);
            this.buttonEx_PaperLoadPaper.TabIndex = 4;
            this.buttonEx_PaperLoadPaper.Text = "Load Paper Docs";
            this.buttonEx_PaperLoadPaper.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_PaperLoadPaper.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersMembersGroup
            // 
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Controls.Add(this.objectListView_PaperMembers, 0, 0);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(1062, 477);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
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
            this.objectListView_PaperMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_PaperMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_PaperMembers.Location = new System.Drawing.Point(4, 5);
            this.objectListView_PaperMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_PaperMembers.Name = "objectListView_PaperMembers";
            this.objectListView_PaperMembers.ShowGroups = false;
            this.objectListView_PaperMembers.Size = new System.Drawing.Size(1054, 467);
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
            // tableLayoutPanel_TeamFoldersProvisionCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnCount = 9;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperDownloadFolder, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.textBoxPaper, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperDelete, 4, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperDownload, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Permanent, 6, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Archive, 5, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Location = new System.Drawing.Point(4, 610);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Name = "tableLayoutPanel_TeamFoldersProvisionCommandGroup";
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Size = new System.Drawing.Size(1062, 56);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_PaperDownloadFolder
            // 
            this.buttonEx_PaperDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_PaperDownloadFolder.Location = new System.Drawing.Point(407, 14);
            this.buttonEx_PaperDownloadFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_PaperDownloadFolder.Name = "buttonEx_PaperDownloadFolder";
            this.buttonEx_PaperDownloadFolder.Size = new System.Drawing.Size(39, 28);
            this.buttonEx_PaperDownloadFolder.TabIndex = 13;
            this.buttonEx_PaperDownloadFolder.Text = "...";
            this.buttonEx_PaperDownloadFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxPaper
            // 
            this.textBoxPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaper.Location = new System.Drawing.Point(160, 17);
            this.textBoxPaper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPaper.Name = "textBoxPaper";
            this.textBoxPaper.Size = new System.Drawing.Size(239, 22);
            this.textBoxPaper.TabIndex = 12;
            // 
            // buttonEx_PaperDelete
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
            this.buttonEx_PaperDelete.ColorTable = office2010Blue1;
            this.buttonEx_PaperDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperDelete.Location = new System.Drawing.Point(471, 5);
            this.buttonEx_PaperDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_PaperDelete.Name = "buttonEx_PaperDelete";
            this.buttonEx_PaperDelete.Size = new System.Drawing.Size(107, 46);
            this.buttonEx_PaperDelete.TabIndex = 11;
            this.buttonEx_PaperDelete.Text = "Delete Docs";
            this.buttonEx_PaperDelete.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEx_PaperDownload
            // 
            this.buttonEx_PaperDownload.ColorTable = office2010Blue1;
            this.buttonEx_PaperDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperDownload.Location = new System.Drawing.Point(4, 5);
            this.buttonEx_PaperDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_PaperDownload.Name = "buttonEx_PaperDownload";
            this.buttonEx_PaperDownload.Size = new System.Drawing.Size(148, 46);
            this.buttonEx_PaperDownload.TabIndex = 8;
            this.buttonEx_PaperDownload.Text = "Download Docs";
            this.buttonEx_PaperDownload.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperDownload.UseVisualStyleBackColor = true;
            // 
            // radioButton_Permanent
            // 
            this.radioButton_Permanent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Permanent.AutoSize = true;
            this.radioButton_Permanent.Location = new System.Drawing.Point(698, 19);
            this.radioButton_Permanent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Permanent.Name = "radioButton_Permanent";
            this.radioButton_Permanent.Size = new System.Drawing.Size(128, 17);
            this.radioButton_Permanent.TabIndex = 9;
            this.radioButton_Permanent.TabStop = true;
            this.radioButton_Permanent.Text = "Permanent";
            this.radioButton_Permanent.UseVisualStyleBackColor = true;
            // 
            // radioButton_Archive
            // 
            this.radioButton_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Archive.AutoSize = true;
            this.radioButton_Archive.Location = new System.Drawing.Point(586, 19);
            this.radioButton_Archive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Archive.Name = "radioButton_Archive";
            this.radioButton_Archive.Size = new System.Drawing.Size(104, 17);
            this.radioButton_Archive.TabIndex = 10;
            this.radioButton_Archive.TabStop = true;
            this.radioButton_Archive.Text = "Archived";
            this.radioButton_Archive.UseVisualStyleBackColor = true;
            // 
            // PaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaperView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_TeamFolders.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_PaperMembers)).EndInit();
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersAccessToken;
        private System.Windows.Forms.Label label_TeamFoldersAccessToken;
        private TextBoxEx textBox_PaperAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMembersGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_PaperMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_PaperName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersSendEmailGroup;
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
    }
}