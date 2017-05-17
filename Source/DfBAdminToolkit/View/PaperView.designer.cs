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
            this.buttonEx_PaperCreatePaper = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBoxPaper = new System.Windows.Forms.TextBox();
            this.buttonEx_PaperLoadFromCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_PaperLoadPaper = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_PaperMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnPaper_PaperName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_PaperId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Owner = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_CreatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_LastUpdatedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_LastEditor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPaper_Revision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_PaperPermsExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperSetPaperSyncSetting = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_PaperSetPaperStatus = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.radioButton_Active = new System.Windows.Forms.RadioButton();
            this.radioButtonNoSync = new System.Windows.Forms.RadioButton();
            this.radioButtonSync = new System.Windows.Forms.RadioButton();
            this.radioButton_Archived = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_TeamFolders.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.SuspendLayout();
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
            this.tableLayoutPanel_TeamFolders.Name = "tableLayoutPanel_TeamFolders";
            this.tableLayoutPanel_TeamFolders.RowCount = 4;
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TeamFolders.Size = new System.Drawing.Size(713, 435);
            this.tableLayoutPanel_TeamFolders.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamFoldersCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Size = new System.Drawing.Size(707, 64);
            this.tableLayoutPanel_TeamFoldersCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersAccessToken
            // 
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.label_TeamFoldersAccessToken, 0, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_PaperAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(391, 1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(315, 25);
            this.tableLayoutPanel_TeamFoldersAccessToken.TabIndex = 0;
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
            this.textBox_PaperAccessToken.Size = new System.Drawing.Size(219, 22);
            this.textBox_PaperAccessToken.TabIndex = 1;
            this.textBox_PaperAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_PaperCreatePaper, 2, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.textBoxPaper, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_PaperLoadFromCSV, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(310, 31);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // buttonEx_PaperCreatePaper
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
            this.buttonEx_PaperCreatePaper.ColorTable = office2010White1;
            this.buttonEx_PaperCreatePaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_PaperCreatePaper.Location = new System.Drawing.Point(199, 5);
            this.buttonEx_PaperCreatePaper.Name = "buttonEx_PaperCreatePaper";
            this.buttonEx_PaperCreatePaper.Size = new System.Drawing.Size(108, 23);
            this.buttonEx_PaperCreatePaper.TabIndex = 7;
            this.buttonEx_PaperCreatePaper.Text = "Create Paper Docs(s)";
            this.buttonEx_PaperCreatePaper.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_PaperCreatePaper.UseVisualStyleBackColor = true;
            // 
            // textBoxPaper
            // 
            this.textBoxPaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPaper.Location = new System.Drawing.Point(3, 6);
            this.textBoxPaper.Name = "textBoxPaper";
            this.textBoxPaper.Size = new System.Drawing.Size(154, 22);
            this.textBoxPaper.TabIndex = 8;
            // 
            // buttonEx_PaperLoadFromCSV
            // 
            this.buttonEx_PaperLoadFromCSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_PaperLoadFromCSV.Location = new System.Drawing.Point(163, 5);
            this.buttonEx_PaperLoadFromCSV.Name = "buttonEx_PaperLoadFromCSV";
            this.buttonEx_PaperLoadFromCSV.Size = new System.Drawing.Size(30, 23);
            this.buttonEx_PaperLoadFromCSV.TabIndex = 9;
            this.buttonEx_PaperLoadFromCSV.Text = "...";
            this.buttonEx_PaperLoadFromCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93534F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_PaperLoadPaper, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(393, 30);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(311, 31);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_PaperLoadPaper
            // 
            this.buttonEx_PaperLoadPaper.ColorTable = office2010White1;
            this.buttonEx_PaperLoadPaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_PaperLoadPaper.Location = new System.Drawing.Point(162, 4);
            this.buttonEx_PaperLoadPaper.Name = "buttonEx_PaperLoadPaper";
            this.buttonEx_PaperLoadPaper.Size = new System.Drawing.Size(146, 24);
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
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(707, 311);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
            // 
            // objectListView_PaperMembers
            // 
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_PaperName);
            this.objectListView_PaperMembers.AllColumns.Add(this.olvColumnPaper_PaperId);
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
            this.objectListView_PaperMembers.Location = new System.Drawing.Point(3, 3);
            this.objectListView_PaperMembers.Name = "objectListView_PaperMembers";
            this.objectListView_PaperMembers.ShowGroups = false;
            this.objectListView_PaperMembers.Size = new System.Drawing.Size(701, 305);
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
            this.olvColumnPaper_PaperId.DisplayIndex = 2;
            this.olvColumnPaper_PaperId.MinimumWidth = 100;
            this.olvColumnPaper_PaperId.Text = "PaperId";
            this.olvColumnPaper_PaperId.Width = 100;
            // 
            // olvColumnPaper_Status
            // 
            this.olvColumnPaper_Status.AspectName = "Status";
            this.olvColumnPaper_Status.DisplayIndex = 1;
            this.olvColumnPaper_Status.MinimumWidth = 50;
            this.olvColumnPaper_Status.Text = "Status";
            this.olvColumnPaper_Status.Width = 50;
            // 
            // olvColumnPaper_Owner
            // 
            this.olvColumnPaper_Owner.AspectName = "Owner";
            this.olvColumnPaper_Owner.MaximumWidth = 100;
            this.olvColumnPaper_Owner.Text = "Owner";
            this.olvColumnPaper_Owner.Width = 100;
            // 
            // olvColumnPaper_CreatedDate
            // 
            this.olvColumnPaper_CreatedDate.AspectName = "CreatedDate";
            this.olvColumnPaper_CreatedDate.MaximumWidth = 80;
            this.olvColumnPaper_CreatedDate.Text = "CreatedDate";
            this.olvColumnPaper_CreatedDate.Width = 80;
            // 
            // olvColumnPaper_LastUpdatedDate
            // 
            this.olvColumnPaper_LastUpdatedDate.AspectName = "LastUpdatedDate";
            this.olvColumnPaper_LastUpdatedDate.MaximumWidth = 100;
            this.olvColumnPaper_LastUpdatedDate.Text = "LastUpdatedDate";
            this.olvColumnPaper_LastUpdatedDate.Width = 100;
            // 
            // olvColumnPaper_LastEditor
            // 
            this.olvColumnPaper_LastEditor.AspectName = "LastEditor";
            this.olvColumnPaper_LastEditor.MaximumWidth = 100;
            this.olvColumnPaper_LastEditor.Text = "LastEditor";
            this.olvColumnPaper_LastEditor.Width = 100;
            // 
            // olvColumnPaper_Revision
            // 
            this.olvColumnPaper_Revision.AspectName = "Revision";
            this.olvColumnPaper_Revision.MaximumWidth = 80;
            this.olvColumnPaper_Revision.Text = "Revision";
            this.olvColumnPaper_Revision.Width = 80;
            // 
            // tableLayoutPanel_TeamFoldersProvisionCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnCount = 9;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperPermsExportToCSV, 8, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperExportToCSV, 7, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperSetPaperSyncSetting, 4, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_PaperSetPaperStatus, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Active, 1, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButtonNoSync, 6, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButtonSync, 5, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Archived, 2, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Location = new System.Drawing.Point(3, 397);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Name = "tableLayoutPanel_TeamFoldersProvisionCommandGroup";
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Size = new System.Drawing.Size(707, 36);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_PaperPermsExportToCSV
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
            this.buttonEx_PaperPermsExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_PaperPermsExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperPermsExportToCSV.Location = new System.Drawing.Point(624, 3);
            this.buttonEx_PaperPermsExportToCSV.Name = "buttonEx_PaperPermsExportToCSV";
            this.buttonEx_PaperPermsExportToCSV.Size = new System.Drawing.Size(101, 30);
            this.buttonEx_PaperPermsExportToCSV.TabIndex = 13;
            this.buttonEx_PaperPermsExportToCSV.Text = "Export Paper Members";
            this.buttonEx_PaperPermsExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperPermsExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_PaperExportToCSV
            // 
            this.buttonEx_PaperExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_PaperExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperExportToCSV.Location = new System.Drawing.Point(468, 3);
            this.buttonEx_PaperExportToCSV.Name = "buttonEx_PaperExportToCSV";
            this.buttonEx_PaperExportToCSV.Size = new System.Drawing.Size(150, 30);
            this.buttonEx_PaperExportToCSV.TabIndex = 12;
            this.buttonEx_PaperExportToCSV.Text = "Export Paper Docs";
            this.buttonEx_PaperExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_PaperSetPaperSyncSetting
            // 
            this.buttonEx_PaperSetPaperSyncSetting.ColorTable = office2010Blue1;
            this.buttonEx_PaperSetPaperSyncSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperSetPaperSyncSetting.Location = new System.Drawing.Point(264, 3);
            this.buttonEx_PaperSetPaperSyncSetting.Name = "buttonEx_PaperSetPaperSyncSetting";
            this.buttonEx_PaperSetPaperSyncSetting.Size = new System.Drawing.Size(114, 30);
            this.buttonEx_PaperSetPaperSyncSetting.TabIndex = 11;
            this.buttonEx_PaperSetPaperSyncSetting.Text = "Change Sync Setting";
            this.buttonEx_PaperSetPaperSyncSetting.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperSetPaperSyncSetting.UseVisualStyleBackColor = true;
            this.buttonEx_PaperSetPaperSyncSetting.Visible = false;
            // 
            // buttonEx_PaperSetPaperStatus
            // 
            this.buttonEx_PaperSetPaperStatus.ColorTable = office2010Blue1;
            this.buttonEx_PaperSetPaperStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_PaperSetPaperStatus.Location = new System.Drawing.Point(3, 3);
            this.buttonEx_PaperSetPaperStatus.Name = "buttonEx_PaperSetPaperStatus";
            this.buttonEx_PaperSetPaperStatus.Size = new System.Drawing.Size(90, 30);
            this.buttonEx_PaperSetPaperStatus.TabIndex = 8;
            this.buttonEx_PaperSetPaperStatus.Text = "Change Status";
            this.buttonEx_PaperSetPaperStatus.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_PaperSetPaperStatus.UseVisualStyleBackColor = true;
            // 
            // radioButton_Active
            // 
            this.radioButton_Active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Active.AutoSize = true;
            this.radioButton_Active.Location = new System.Drawing.Point(99, 9);
            this.radioButton_Active.Name = "radioButton_Active";
            this.radioButton_Active.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Active.TabIndex = 9;
            this.radioButton_Active.TabStop = true;
            this.radioButton_Active.Text = "Active";
            this.radioButton_Active.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoSync
            // 
            this.radioButtonNoSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonNoSync.AutoSize = true;
            this.radioButtonNoSync.Location = new System.Drawing.Point(447, 9);
            this.radioButtonNoSync.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNoSync.Name = "radioButtonNoSync";
            this.radioButtonNoSync.Size = new System.Drawing.Size(16, 17);
            this.radioButtonNoSync.TabIndex = 5;
            this.radioButtonNoSync.TabStop = true;
            this.radioButtonNoSync.Text = "No Sync";
            this.radioButtonNoSync.UseVisualStyleBackColor = true;
            this.radioButtonNoSync.Visible = false;
            // 
            // radioButtonSync
            // 
            this.radioButtonSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSync.AutoSize = true;
            this.radioButtonSync.Location = new System.Drawing.Point(383, 9);
            this.radioButtonSync.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSync.Name = "radioButtonSync";
            this.radioButtonSync.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSync.TabIndex = 4;
            this.radioButtonSync.TabStop = true;
            this.radioButtonSync.Text = "Sync";
            this.radioButtonSync.UseVisualStyleBackColor = true;
            this.radioButtonSync.Visible = false;
            // 
            // radioButton_Archived
            // 
            this.radioButton_Archived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Archived.AutoSize = true;
            this.radioButton_Archived.Location = new System.Drawing.Point(163, 9);
            this.radioButton_Archived.Name = "radioButton_Archived";
            this.radioButton_Archived.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Archived.TabIndex = 10;
            this.radioButton_Archived.TabStop = true;
            this.radioButton_Archived.Text = "Archived";
            this.radioButton_Archived.UseVisualStyleBackColor = true;
            // 
            // PaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaperView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_TeamFolders.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.PerformLayout();
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
        private ButtonEx buttonEx_PaperSetPaperStatus;
        private ButtonEx buttonEx_PaperCreatePaper;
        private System.Windows.Forms.TextBox textBoxPaper;
        private System.Windows.Forms.RadioButton radioButton_Active;
        private System.Windows.Forms.RadioButton radioButton_Archived;
        private System.Windows.Forms.RadioButton radioButtonSync;
        private System.Windows.Forms.RadioButton radioButtonNoSync;
        private ButtonEx buttonEx_PaperSetPaperSyncSetting;
        private ButtonEx buttonEx_PaperExportToCSV;
        private System.Windows.Forms.Button buttonEx_PaperLoadFromCSV;
        private ButtonEx buttonEx_PaperPermsExportToCSV;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_Owner;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_CreatedDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_LastUpdatedDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_LastEditor;
        private BrightIdeasSoftware.OLVColumn olvColumnPaper_Revision;
    }
}