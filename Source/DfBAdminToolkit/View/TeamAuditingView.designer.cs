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
            this.textBoxTeamAuditing = new System.Windows.Forms.TextBox();
            this.buttonEx_TeamAuditingLoadFromCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamAuditingLoadTeamFolders = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_TeamAuditingMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnTeamFolders_TeamFolderName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamFolders_TeamFolderId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamFolders_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamAuditingExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_TeamAuditingSetFolderStatus = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.radioButton_Active = new System.Windows.Forms.RadioButton();
            this.radioButton_Archived = new System.Windows.Forms.RadioButton();
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
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.dateTimePickerFrom, 2, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamAuditingAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(447, 1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(259, 25);
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
            this.textBox_TeamAuditingAccessToken.Size = new System.Drawing.Size(163, 22);
            this.textBox_TeamAuditingAccessToken.TabIndex = 1;
            this.textBox_TeamAuditingAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.textBoxTeamAuditing, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamAuditingLoadFromCSV, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(249, 31);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // textBoxTeamAuditing
            // 
            this.textBoxTeamAuditing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTeamAuditing.Location = new System.Drawing.Point(3, 6);
            this.textBoxTeamAuditing.Name = "textBoxTeamAuditing";
            this.textBoxTeamAuditing.Size = new System.Drawing.Size(154, 22);
            this.textBoxTeamAuditing.TabIndex = 8;
            // 
            // buttonEx_TeamAuditingLoadFromCSV
            // 
            this.buttonEx_TeamAuditingLoadFromCSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamAuditingLoadFromCSV.Location = new System.Drawing.Point(163, 5);
            this.buttonEx_TeamAuditingLoadFromCSV.Name = "buttonEx_TeamAuditingLoadFromCSV";
            this.buttonEx_TeamAuditingLoadFromCSV.Size = new System.Drawing.Size(30, 23);
            this.buttonEx_TeamAuditingLoadFromCSV.TabIndex = 9;
            this.buttonEx_TeamAuditingLoadFromCSV.Text = "...";
            this.buttonEx_TeamAuditingLoadFromCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_TeamAuditingLoadTeamFolders, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.dateTimePickerTo, 1, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(449, 30);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(255, 31);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_TeamAuditingLoadTeamFolders
            // 
            this.buttonEx_TeamAuditingLoadTeamFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonEx_TeamAuditingLoadTeamFolders.ColorTable = office2010White1;
            this.buttonEx_TeamAuditingLoadTeamFolders.Location = new System.Drawing.Point(193, 3);
            this.buttonEx_TeamAuditingLoadTeamFolders.Name = "buttonEx_TeamAuditingLoadTeamFolders";
            this.buttonEx_TeamAuditingLoadTeamFolders.Size = new System.Drawing.Size(59, 24);
            this.buttonEx_TeamAuditingLoadTeamFolders.TabIndex = 4;
            this.buttonEx_TeamAuditingLoadTeamFolders.Text = "Load";
            this.buttonEx_TeamAuditingLoadTeamFolders.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamAuditingLoadTeamFolders.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(3, 4);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(184, 22);
            this.dateTimePickerTo.TabIndex = 6;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(259, 34);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(184, 22);
            this.dateTimePickerFrom.TabIndex = 5;
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
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamFolders_TeamFolderName);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamFolders_TeamFolderId);
            this.objectListView_TeamAuditingMembers.AllColumns.Add(this.olvColumnTeamFolders_Status);
            this.objectListView_TeamAuditingMembers.CellEditUseWholeCell = false;
            this.objectListView_TeamAuditingMembers.CheckBoxes = true;
            this.objectListView_TeamAuditingMembers.CheckedAspectName = "IsChecked";
            this.objectListView_TeamAuditingMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTeamFolders_TeamFolderName,
            this.olvColumnTeamFolders_TeamFolderId,
            this.olvColumnTeamFolders_Status});
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
            this.objectListView_TeamAuditingMembers.TabIndex = 1;
            this.objectListView_TeamAuditingMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_TeamAuditingMembers.UseNotifyPropertyChanged = true;
            this.objectListView_TeamAuditingMembers.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnTeamFolders_TeamFolderName
            // 
            this.olvColumnTeamFolders_TeamFolderName.AspectName = "TeamFolderName";
            this.olvColumnTeamFolders_TeamFolderName.HeaderCheckBox = true;
            this.olvColumnTeamFolders_TeamFolderName.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnTeamFolders_TeamFolderName.Hideable = false;
            this.olvColumnTeamFolders_TeamFolderName.MinimumWidth = 150;
            this.olvColumnTeamFolders_TeamFolderName.Text = "TeamFolderName";
            this.olvColumnTeamFolders_TeamFolderName.Width = 250;
            // 
            // olvColumnTeamFolders_TeamFolderId
            // 
            this.olvColumnTeamFolders_TeamFolderId.AspectName = "TeamFolderId";
            this.olvColumnTeamFolders_TeamFolderId.DisplayIndex = 2;
            this.olvColumnTeamFolders_TeamFolderId.MinimumWidth = 300;
            this.olvColumnTeamFolders_TeamFolderId.Text = "TeamFolderId";
            this.olvColumnTeamFolders_TeamFolderId.Width = 300;
            // 
            // olvColumnTeamFolders_Status
            // 
            this.olvColumnTeamFolders_Status.AspectName = "Status";
            this.olvColumnTeamFolders_Status.DisplayIndex = 1;
            this.olvColumnTeamFolders_Status.MinimumWidth = 100;
            this.olvColumnTeamFolders_Status.Text = "Status";
            this.olvColumnTeamFolders_Status.Width = 100;
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
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamAuditingExportToCSV, 7, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamAuditingSetFolderStatus, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Active, 1, 0);
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
            this.buttonEx_TeamAuditingExportToCSV.Location = new System.Drawing.Point(468, 3);
            this.buttonEx_TeamAuditingExportToCSV.Name = "buttonEx_TeamAuditingExportToCSV";
            this.buttonEx_TeamAuditingExportToCSV.Size = new System.Drawing.Size(150, 30);
            this.buttonEx_TeamAuditingExportToCSV.TabIndex = 12;
            this.buttonEx_TeamAuditingExportToCSV.Text = "Export Team Folders ";
            this.buttonEx_TeamAuditingExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamAuditingExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_TeamAuditingSetFolderStatus
            // 
            this.buttonEx_TeamAuditingSetFolderStatus.ColorTable = office2010Blue1;
            this.buttonEx_TeamAuditingSetFolderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamAuditingSetFolderStatus.Location = new System.Drawing.Point(3, 3);
            this.buttonEx_TeamAuditingSetFolderStatus.Name = "buttonEx_TeamAuditingSetFolderStatus";
            this.buttonEx_TeamAuditingSetFolderStatus.Size = new System.Drawing.Size(90, 30);
            this.buttonEx_TeamAuditingSetFolderStatus.TabIndex = 8;
            this.buttonEx_TeamAuditingSetFolderStatus.Text = "Change Status";
            this.buttonEx_TeamAuditingSetFolderStatus.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamAuditingSetFolderStatus.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel_TeamFoldersAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.PerformLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_TeamAuditingMembers)).EndInit();
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.PerformLayout();
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
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_TeamFolderName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersSendEmailGroup;
        private ButtonEx buttonEx_TeamAuditingLoadTeamFolders;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_Status;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_TeamFolderId;
        private ButtonEx buttonEx_TeamAuditingSetFolderStatus;
        private System.Windows.Forms.RadioButton radioButton_Active;
        private System.Windows.Forms.RadioButton radioButton_Archived;
        private ButtonEx buttonEx_TeamAuditingExportToCSV;
        private System.Windows.Forms.Button buttonEx_TeamAuditingLoadFromCSV;
        private System.Windows.Forms.TextBox textBoxTeamAuditing;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}