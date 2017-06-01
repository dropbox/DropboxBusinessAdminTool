namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class TeamAuditingView
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
            DfBAdminToolkit.Common.Component.Office2010White office2010White3 = new DfBAdminToolkit.Common.Component.Office2010White();
            DfBAdminToolkit.Common.Component.Office2010Blue office2010Blue3 = new DfBAdminToolkit.Common.Component.Office2010Blue();
            this.tableLayoutPanel_TeamFolders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_TeamFoldersAccessToken = new System.Windows.Forms.Label();
            this.textBox_TeamAuditingAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTeamAuditing = new System.Windows.Forms.TextBox();
            this.buttonEx_TeamAuditingLoadFromCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamAuditingLoadTeamEvents = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox_EventCategory = new System.Windows.Forms.ComboBox();
            this.label_Categories = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_TeamAuditingMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnTeamAuditing_Timestamp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_ActorType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Context = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_EventType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Origin = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_IpAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_City = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Region = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTEamAuditing_Country = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Participants = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamAuditing_Assets = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamAuditingExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamFolders.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersMembersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_TeamAuditingMembers)).BeginInit();
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
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TeamFolders.Size = new System.Drawing.Size(713, 435);
            this.tableLayoutPanel_TeamFolders.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamFoldersCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.dateTimePickerFrom, 2, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.comboBox_EventCategory, 2, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.label_Categories, 1, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.Size = new System.Drawing.Size(707, 67);
            this.tableLayoutPanel_TeamFoldersCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersAccessToken
            // 
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.label_TeamFoldersAccessToken, 0, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamAuditingAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(446, 1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(260, 25);
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
            // textBox_TeamAuditingAccessToken
            // 
            this.textBox_TeamAuditingAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TeamAuditingAccessToken.FileFilter = null;
            this.textBox_TeamAuditingAccessToken.Location = new System.Drawing.Point(93, 3);
            this.textBox_TeamAuditingAccessToken.Name = "textBox_TeamAuditingAccessToken";
            this.textBox_TeamAuditingAccessToken.Size = new System.Drawing.Size(164, 22);
            this.textBox_TeamAuditingAccessToken.TabIndex = 1;
            this.textBox_TeamAuditingAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.textBoxTeamAuditing, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamAuditingLoadFromCSV, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(186, 34);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // textBoxTeamAuditing
            // 
            this.textBoxTeamAuditing.AcceptsTab = true;
            this.textBoxTeamAuditing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTeamAuditing.Location = new System.Drawing.Point(3, 9);
            this.textBoxTeamAuditing.Name = "textBoxTeamAuditing";
            this.textBoxTeamAuditing.Size = new System.Drawing.Size(149, 22);
            this.textBoxTeamAuditing.TabIndex = 8;
            this.textBoxTeamAuditing.Text = "Select Member File...";
            // 
            // buttonEx_TeamAuditingLoadFromCSV
            // 
            this.buttonEx_TeamAuditingLoadFromCSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamAuditingLoadFromCSV.Location = new System.Drawing.Point(158, 5);
            this.buttonEx_TeamAuditingLoadFromCSV.Name = "buttonEx_TeamAuditingLoadFromCSV";
            this.buttonEx_TeamAuditingLoadFromCSV.Size = new System.Drawing.Size(35, 26);
            this.buttonEx_TeamAuditingLoadFromCSV.TabIndex = 9;
            this.buttonEx_TeamAuditingLoadFromCSV.Text = "...";
            this.buttonEx_TeamAuditingLoadFromCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_TeamAuditingLoadTeamEvents, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.dateTimePickerTo, 1, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(448, 30);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(256, 34);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_TeamAuditingLoadTeamEvents
            // 
            this.buttonEx_TeamAuditingLoadTeamEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            office2010White3.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010White3.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010White3.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White3.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White3.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010White3.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010White3.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            office2010White3.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White3.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            office2010White3.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White3.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White3.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White3.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010White3.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010White3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White3.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White3.TextColor = System.Drawing.Color.Black;
            this.buttonEx_TeamAuditingLoadTeamEvents.ColorTable = office2010White3;
            this.buttonEx_TeamAuditingLoadTeamEvents.Location = new System.Drawing.Point(191, 5);
            this.buttonEx_TeamAuditingLoadTeamEvents.Name = "buttonEx_TeamAuditingLoadTeamEvents";
            this.buttonEx_TeamAuditingLoadTeamEvents.Size = new System.Drawing.Size(64, 24);
            this.buttonEx_TeamAuditingLoadTeamEvents.TabIndex = 4;
            this.buttonEx_TeamAuditingLoadTeamEvents.Text = "Load";
            this.buttonEx_TeamAuditingLoadTeamEvents.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamAuditingLoadTeamEvents.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(33, 6);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(152, 22);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(258, 36);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerFrom.TabIndex = 5;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // comboBox_EventCategory
            // 
            this.comboBox_EventCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_EventCategory.FormattingEnabled = true;
            this.comboBox_EventCategory.Items.AddRange(new object[] {
            "All Events",
            "Account_Capture",
            "Administration",
            "Apps",
            "Authentication",
            "Comments",
            "Content_Access",
            "Devices",
            "Device_Approvals",
            "Domains",
            "EMM",
            "Errors",
            "Files",
            "File_Operations",
            "File_Requests",
            "Groups",
            "Logins",
            "Members",
            "Paper",
            "Passwords",
            "Reports",
            "Sessions",
            "Shared_Files",
            "Shared_Folders",
            "Shared_Links",
            "Sharing",
            "Sharing_Policies",
            "SSO",
            "Team_Folders",
            "Team_Policies",
            "Team_Profile",
            "TFA"});
            this.comboBox_EventCategory.Location = new System.Drawing.Point(257, 3);
            this.comboBox_EventCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EventCategory.Name = "comboBox_EventCategory";
            this.comboBox_EventCategory.Size = new System.Drawing.Size(186, 21);
            this.comboBox_EventCategory.TabIndex = 6;
            this.comboBox_EventCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_EventCategory_SelectedIndexChanged);
            // 
            // label_Categories
            // 
            this.label_Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Categories.AutoSize = true;
            this.label_Categories.Location = new System.Drawing.Point(194, 7);
            this.label_Categories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Categories.Name = "label_Categories";
            this.label_Categories.Size = new System.Drawing.Size(59, 13);
            this.label_Categories.TabIndex = 7;
            this.label_Categories.Text = "Category:";
            // 
            // tableLayoutPanel_TeamFoldersMembersGroup
            // 
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Controls.Add(this.objectListView_TeamAuditingMembers, 0, 0);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(707, 311);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
            // 
            // objectListView_TeamAuditingMembers
            // 
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Timestamp);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_ActorType);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Email);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Context);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_EventType);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Origin);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_IpAddress);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_City);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Region);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTEamAuditing_Country);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Participants);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamAuditing_Assets);
            this.objectListView_TeamAuditingMembers.CellEditUseWholeCell = false;
            this.objectListView_TeamAuditingMembers.CheckBoxes = true;
            this.objectListView_TeamAuditingMembers.CheckedAspectName = "IsChecked";
            this.objectListView_TeamAuditingMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTeamAuditing_Timestamp,
            this.olvColumnTeamAuditing_ActorType,
            this.olvColumnTeamAuditing_Email,
            this.olvColumnTeamAuditing_Context,
            this.olvColumnTeamAuditing_EventType,
            this.olvColumnTeamAuditing_Origin,
            this.olvColumnTeamAuditing_IpAddress,
            this.olvColumnTeamAuditing_City,
            this.olvColumnTeamAuditing_Region,
            this.olvColumnTEamAuditing_Country,
            this.olvColumnTeamAuditing_Participants,
            this.olvColumnTeamAuditing_Assets});
            this.objectListView_TeamAuditingMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_TeamAuditingMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_TeamAuditingMembers.EmptyListMsg = "No Result";
            this.objectListView_TeamAuditingMembers.FullRowSelect = true;
            this.objectListView_TeamAuditingMembers.HasCollapsibleGroups = false;
            this.objectListView_TeamAuditingMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_TeamAuditingMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_TeamAuditingMembers.Location = new System.Drawing.Point(3, 3);
            this.objectListView_TeamAuditingMembers.Name = "objectListView_TeamAuditingMembers";
            this.objectListView_TeamAuditingMembers.ShowGroups = false;
            this.objectListView_TeamAuditingMembers.Size = new System.Drawing.Size(701, 305);
            this.objectListView_TeamAuditingMembers.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.objectListView_TeamAuditingMembers.TabIndex = 1;
            this.objectListView_TeamAuditingMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_TeamAuditingMembers.UseNotifyPropertyChanged = true;
            this.objectListView_TeamAuditingMembers.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnTeamAuditing_Timestamp
            // 
            this.olvColumnTeamAuditing_Timestamp.AspectName = "TImestamp";
            this.olvColumnTeamAuditing_Timestamp.HeaderCheckBox = true;
            this.olvColumnTeamAuditing_Timestamp.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnTeamAuditing_Timestamp.Hideable = false;
            this.olvColumnTeamAuditing_Timestamp.MinimumWidth = 150;
            this.olvColumnTeamAuditing_Timestamp.Text = "Timestamp";
            this.olvColumnTeamAuditing_Timestamp.Width = 150;
            // 
            // olvColumnTeamAuditing_ActorType
            // 
            this.olvColumnTeamAuditing_ActorType.AspectName = "ActorType";
            this.olvColumnTeamAuditing_ActorType.MinimumWidth = 50;
            this.olvColumnTeamAuditing_ActorType.Text = "ActorType";
            this.olvColumnTeamAuditing_ActorType.Width = 50;
            // 
            // olvColumnTeamAuditing_Email
            // 
            this.olvColumnTeamAuditing_Email.AspectName = "Email";
            this.olvColumnTeamAuditing_Email.MinimumWidth = 100;
            this.olvColumnTeamAuditing_Email.Text = "Actor";
            this.olvColumnTeamAuditing_Email.Width = 100;
            // 
            // olvColumnTeamAuditing_Context
            // 
            this.olvColumnTeamAuditing_Context.AspectName = "Context";
            this.olvColumnTeamAuditing_Context.MinimumWidth = 70;
            this.olvColumnTeamAuditing_Context.Text = "Context";
            this.olvColumnTeamAuditing_Context.Width = 70;
            // 
            // olvColumnTeamAuditing_EventType
            // 
            this.olvColumnTeamAuditing_EventType.AspectName = "EventType";
            this.olvColumnTeamAuditing_EventType.MinimumWidth = 100;
            this.olvColumnTeamAuditing_EventType.Text = "EventType";
            this.olvColumnTeamAuditing_EventType.Width = 100;
            // 
            // olvColumnTeamAuditing_Origin
            // 
            this.olvColumnTeamAuditing_Origin.AspectName = "Origin";
            this.olvColumnTeamAuditing_Origin.MinimumWidth = 75;
            this.olvColumnTeamAuditing_Origin.Text = "Origin";
            this.olvColumnTeamAuditing_Origin.Width = 75;
            // 
            // olvColumnTeamAuditing_IpAddress
            // 
            this.olvColumnTeamAuditing_IpAddress.AspectName = "IpAddress";
            this.olvColumnTeamAuditing_IpAddress.MinimumWidth = 80;
            this.olvColumnTeamAuditing_IpAddress.Text = "IpAddress";
            this.olvColumnTeamAuditing_IpAddress.Width = 80;
            // 
            // olvColumnTeamAuditing_City
            // 
            this.olvColumnTeamAuditing_City.AspectName = "City";
            this.olvColumnTeamAuditing_City.MinimumWidth = 75;
            this.olvColumnTeamAuditing_City.Text = "City";
            this.olvColumnTeamAuditing_City.Width = 75;
            // 
            // olvColumnTeamAuditing_Region
            // 
            this.olvColumnTeamAuditing_Region.AspectName = "Region";
            this.olvColumnTeamAuditing_Region.MinimumWidth = 50;
            this.olvColumnTeamAuditing_Region.Text = "Region";
            this.olvColumnTeamAuditing_Region.Width = 50;
            // 
            // olvColumnTEamAuditing_Country
            // 
            this.olvColumnTEamAuditing_Country.AspectName = "Country";
            this.olvColumnTEamAuditing_Country.MinimumWidth = 60;
            this.olvColumnTEamAuditing_Country.Text = "Country";
            // 
            // olvColumnTeamAuditing_Participants
            // 
            this.olvColumnTeamAuditing_Participants.AspectName = "Participants";
            this.olvColumnTeamAuditing_Participants.MinimumWidth = 150;
            this.olvColumnTeamAuditing_Participants.Text = "Participants";
            this.olvColumnTeamAuditing_Participants.Width = 150;
            // 
            // olvColumnTeamAuditing_Assets
            // 
            this.olvColumnTeamAuditing_Assets.AspectName = "Assets";
            this.olvColumnTeamAuditing_Assets.MinimumWidth = 150;
            this.olvColumnTeamAuditing_Assets.Text = "Assets";
            this.olvColumnTeamAuditing_Assets.Width = 150;
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
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamAuditingExportToCSV, 9, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Location = new System.Drawing.Point(3, 397);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Name = "tableLayoutPanel_TeamFoldersProvisionCommandGroup";
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Size = new System.Drawing.Size(707, 36);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_TeamAuditingExportToCSV
            // 
            office2010Blue3.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue3.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue3.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue3.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue3.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue3.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue3.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue3.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue3.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue3.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue3.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue3.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue3.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue3.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue3.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue3.TextColor = System.Drawing.Color.White;
            this.buttonEx_TeamAuditingExportToCSV.ColorTable = office2010Blue3;
            this.buttonEx_TeamAuditingExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamAuditingExportToCSV.Location = new System.Drawing.Point(578, 3);
            this.buttonEx_TeamAuditingExportToCSV.Name = "buttonEx_TeamAuditingExportToCSV";
            this.buttonEx_TeamAuditingExportToCSV.Size = new System.Drawing.Size(126, 30);
            this.buttonEx_TeamAuditingExportToCSV.TabIndex = 12;
            this.buttonEx_TeamAuditingExportToCSV.Text = "Export Team Folders ";
            this.buttonEx_TeamAuditingExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamAuditingExportToCSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // TeamAuditingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamAuditingView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_TeamFolders.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersCommandGroup.PerformLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.PerformLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.PerformLayout();
            this.tableLayoutPanel_TeamFoldersMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_TeamAuditingMembers)).EndInit();
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersAccessToken;
        private System.Windows.Forms.Label label_TeamFoldersAccessToken;
        private TextBoxEx textBox_TeamAuditingAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMembersGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_TeamAuditingMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Timestamp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersSendEmailGroup;
        private ButtonEx buttonEx_TeamAuditingLoadTeamEvents;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Context;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Email;
        private ButtonEx buttonEx_TeamAuditingExportToCSV;
        private System.Windows.Forms.Button buttonEx_TeamAuditingLoadFromCSV;
        private System.Windows.Forms.TextBox textBoxTeamAuditing;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ComboBox comboBox_EventCategory;
        private System.Windows.Forms.Label label_Categories;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_EventType;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Origin;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_IpAddress;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_City;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Region;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Participants;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_Assets;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamAuditing_ActorType;
        private BrightIdeasSoftware.OLVColumn olvColumnTEamAuditing_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}