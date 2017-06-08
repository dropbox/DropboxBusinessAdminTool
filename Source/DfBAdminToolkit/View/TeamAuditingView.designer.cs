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
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            DfBAdminToolkit.Common.Component.Office2010Blue office2010Blue1 = new DfBAdminToolkit.Common.Component.Office2010Blue();
            this.tableLayoutPanel_TeamFolders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_TeamFoldersAccessToken = new System.Windows.Forms.Label();
            this.textBox_TeamAuditingAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamAuditingFilterMembers = new System.Windows.Forms.Button();
            this.textBoxTeamAuditing = new System.Windows.Forms.TextBox();
            this.buttonEx_TeamAuditingLoadFromCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEx_TeamAuditingLoadTeamEvents = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox_EventCategory = new System.Windows.Forms.ComboBox();
            this.label_Categories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel_TeamFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFolders.Name = "tableLayoutPanel_TeamFolders";
            this.tableLayoutPanel_TeamFolders.RowCount = 4;
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_TeamFolders.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_TeamFolders.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamFoldersCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.dateTimePickerFrom, 2, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.comboBox_EventCategory, 2, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.label_Categories, 1, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.Size = new System.Drawing.Size(1062, 102);
            this.tableLayoutPanel_TeamFoldersCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersAccessToken
            // 
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.label_TeamFoldersAccessToken, 0, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamAuditingAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(670, 2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(390, 46);
            this.tableLayoutPanel_TeamFoldersAccessToken.TabIndex = 0;
            // 
            // label_TeamFoldersAccessToken
            // 
            this.label_TeamFoldersAccessToken.AutoSize = true;
            this.label_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TeamFoldersAccessToken.Location = new System.Drawing.Point(4, 0);
            this.label_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TeamFoldersAccessToken.Name = "label_TeamFoldersAccessToken";
            this.label_TeamFoldersAccessToken.Size = new System.Drawing.Size(127, 46);
            this.label_TeamFoldersAccessToken.TabIndex = 0;
            this.label_TeamFoldersAccessToken.Text = "Access Token";
            this.label_TeamFoldersAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_TeamFoldersAccessToken.Visible = false;
            // 
            // textBox_TeamAuditingAccessToken
            // 
            this.textBox_TeamAuditingAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TeamAuditingAccessToken.FileFilter = null;
            this.textBox_TeamAuditingAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_TeamAuditingAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TeamAuditingAccessToken.Name = "textBox_TeamAuditingAccessToken";
            this.textBox_TeamAuditingAccessToken.Size = new System.Drawing.Size(247, 22);
            this.textBox_TeamAuditingAccessToken.TabIndex = 1;
            this.textBox_TeamAuditingAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamAuditingFilterMembers, 2, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.textBoxTeamAuditing, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamAuditingLoadFromCSV, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(4, 55);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(313, 52);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // buttonEx_TeamAuditingFilterMembers
            // 
            this.buttonEx_TeamAuditingFilterMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_TeamAuditingFilterMembers.Location = new System.Drawing.Point(298, 6);
            this.buttonEx_TeamAuditingFilterMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamAuditingFilterMembers.Name = "buttonEx_TeamAuditingFilterMembers";
            this.buttonEx_TeamAuditingFilterMembers.Size = new System.Drawing.Size(72, 40);
            this.buttonEx_TeamAuditingFilterMembers.TabIndex = 10;
            this.buttonEx_TeamAuditingFilterMembers.Text = "Filter";
            this.buttonEx_TeamAuditingFilterMembers.UseVisualStyleBackColor = true;
            // 
            // textBoxTeamAuditing
            // 
            this.textBoxTeamAuditing.AcceptsTab = true;
            this.textBoxTeamAuditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTeamAuditing.Location = new System.Drawing.Point(4, 15);
            this.textBoxTeamAuditing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTeamAuditing.Name = "textBoxTeamAuditing";
            this.textBoxTeamAuditing.Size = new System.Drawing.Size(244, 22);
            this.textBoxTeamAuditing.TabIndex = 8;
            this.textBoxTeamAuditing.Text = "Upload Member(s) Filter File...";
            // 
            // buttonEx_TeamAuditingLoadFromCSV
            // 
            this.buttonEx_TeamAuditingLoadFromCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_TeamAuditingLoadFromCSV.Location = new System.Drawing.Point(256, 6);
            this.buttonEx_TeamAuditingLoadFromCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamAuditingLoadFromCSV.Name = "buttonEx_TeamAuditingLoadFromCSV";
            this.buttonEx_TeamAuditingLoadFromCSV.Size = new System.Drawing.Size(34, 40);
            this.buttonEx_TeamAuditingLoadFromCSV.TabIndex = 9;
            this.buttonEx_TeamAuditingLoadFromCSV.Text = "...";
            this.buttonEx_TeamAuditingLoadFromCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_TeamAuditingLoadTeamEvents, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.dateTimePickerTo, 1, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(672, 55);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(386, 52);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // buttonEx_TeamAuditingLoadTeamEvents
            // 
            this.buttonEx_TeamAuditingLoadTeamEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonEx_TeamAuditingLoadTeamEvents.ColorTable = office2010White1;
            this.buttonEx_TeamAuditingLoadTeamEvents.Location = new System.Drawing.Point(286, 7);
            this.buttonEx_TeamAuditingLoadTeamEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamAuditingLoadTeamEvents.Name = "buttonEx_TeamAuditingLoadTeamEvents";
            this.buttonEx_TeamAuditingLoadTeamEvents.Size = new System.Drawing.Size(97, 37);
            this.buttonEx_TeamAuditingLoadTeamEvents.TabIndex = 4;
            this.buttonEx_TeamAuditingLoadTeamEvents.Text = "Load";
            this.buttonEx_TeamAuditingLoadTeamEvents.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamAuditingLoadTeamEvents.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(49, 15);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(387, 70);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(277, 22);
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
            this.comboBox_EventCategory.Location = new System.Drawing.Point(386, 14);
            this.comboBox_EventCategory.Name = "comboBox_EventCategory";
            this.comboBox_EventCategory.Size = new System.Drawing.Size(279, 21);
            this.comboBox_EventCategory.TabIndex = 6;
            this.comboBox_EventCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_EventCategory_SelectedIndexChanged);
            // 
            // label_Categories
            // 
            this.label_Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Categories.AutoSize = true;
            this.label_Categories.Location = new System.Drawing.Point(324, 18);
            this.label_Categories.Name = "label_Categories";
            this.label_Categories.Size = new System.Drawing.Size(56, 13);
            this.label_Categories.TabIndex = 7;
            this.label_Categories.Text = "Category:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_TeamFoldersMembersGroup
            // 
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Controls.Add(this.objectListView_TeamAuditingMembers, 0, 0);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(1062, 477);
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
            this.objectListView_TeamAuditingMembers.Location = new System.Drawing.Point(4, 5);
            this.objectListView_TeamAuditingMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_TeamAuditingMembers.Name = "objectListView_TeamAuditingMembers";
            this.objectListView_TeamAuditingMembers.ShowGroups = false;
            this.objectListView_TeamAuditingMembers.Size = new System.Drawing.Size(1054, 467);
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
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamAuditingExportToCSV, 9, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Location = new System.Drawing.Point(4, 610);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Name = "tableLayoutPanel_TeamFoldersProvisionCommandGroup";
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Size = new System.Drawing.Size(1062, 56);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_TeamAuditingExportToCSV
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
            this.buttonEx_TeamAuditingExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_TeamAuditingExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamAuditingExportToCSV.Location = new System.Drawing.Point(816, 5);
            this.buttonEx_TeamAuditingExportToCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamAuditingExportToCSV.Name = "buttonEx_TeamAuditingExportToCSV";
            this.buttonEx_TeamAuditingExportToCSV.Size = new System.Drawing.Size(242, 46);
            this.buttonEx_TeamAuditingExportToCSV.TabIndex = 12;
            this.buttonEx_TeamAuditingExportToCSV.Text = "Export Selected Items TO CSV";
            this.buttonEx_TeamAuditingExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamAuditingExportToCSV.UseVisualStyleBackColor = true;
            // 
            // TeamAuditingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonEx_TeamAuditingFilterMembers;
    }
}