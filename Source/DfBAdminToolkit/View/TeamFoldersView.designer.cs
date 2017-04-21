namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class TeamFoldersView
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
            this.textBox_TeamFoldersAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamFoldersCreateTeamFolder = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBoxTeamFolder = new System.Windows.Forms.TextBox();
            this.buttonEx_TeamFoldersLoadFromCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamFoldersLoadTeamFolders = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_TeamFoldersMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnTeamFolders_TeamFolderName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamFolders_TeamFolderId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeamFolders_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamFoldersPermsExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_TeamFoldersExportToCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_TeamFoldersSetFolderSyncSetting = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_TeamFoldersSetFolderStatus = new DfBAdminToolkit.Common.Component.ButtonEx();
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
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_TeamFoldersMembers)).BeginInit();
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
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamFoldersAccessToken, 1, 0);
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
            // textBox_TeamFoldersAccessToken
            // 
            this.textBox_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TeamFoldersAccessToken.FileFilter = null;
            this.textBox_TeamFoldersAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TeamFoldersAccessToken.Name = "textBox_TeamFoldersAccessToken";
            this.textBox_TeamFoldersAccessToken.Size = new System.Drawing.Size(329, 22);
            this.textBox_TeamFoldersAccessToken.TabIndex = 1;
            this.textBox_TeamFoldersAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamFoldersCreateTeamFolder, 2, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.textBoxTeamFolder, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.buttonEx_TeamFoldersLoadFromCSV, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(4, 47);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(467, 46);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // buttonEx_TeamFoldersCreateTeamFolder
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
            this.buttonEx_TeamFoldersCreateTeamFolder.ColorTable = office2010White1;
            this.buttonEx_TeamFoldersCreateTeamFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamFoldersCreateTeamFolder.Location = new System.Drawing.Point(298, 6);
            this.buttonEx_TeamFoldersCreateTeamFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersCreateTeamFolder.Name = "buttonEx_TeamFoldersCreateTeamFolder";
            this.buttonEx_TeamFoldersCreateTeamFolder.Size = new System.Drawing.Size(165, 35);
            this.buttonEx_TeamFoldersCreateTeamFolder.TabIndex = 7;
            this.buttonEx_TeamFoldersCreateTeamFolder.Text = "Create Team Folder(s)";
            this.buttonEx_TeamFoldersCreateTeamFolder.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamFoldersCreateTeamFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxTeamFolder
            // 
            this.textBoxTeamFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTeamFolder.Location = new System.Drawing.Point(4, 19);
            this.textBoxTeamFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTeamFolder.Name = "textBoxTeamFolder";
            this.textBoxTeamFolder.Size = new System.Drawing.Size(232, 22);
            this.textBoxTeamFolder.TabIndex = 8;
            // 
            // buttonEx_TeamFoldersLoadFromCSV
            // 
            this.buttonEx_TeamFoldersLoadFromCSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamFoldersLoadFromCSV.Location = new System.Drawing.Point(244, 6);
            this.buttonEx_TeamFoldersLoadFromCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersLoadFromCSV.Name = "buttonEx_TeamFoldersLoadFromCSV";
            this.buttonEx_TeamFoldersLoadFromCSV.Size = new System.Drawing.Size(46, 35);
            this.buttonEx_TeamFoldersLoadFromCSV.TabIndex = 9;
            this.buttonEx_TeamFoldersLoadFromCSV.Text = "...";
            this.buttonEx_TeamFoldersLoadFromCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93534F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_TeamFoldersLoadTeamFolders, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(590, 47);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(468, 46);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_TeamFoldersLoadTeamFolders
            // 
            this.buttonEx_TeamFoldersLoadTeamFolders.ColorTable = office2010White1;
            this.buttonEx_TeamFoldersLoadTeamFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamFoldersLoadTeamFolders.Location = new System.Drawing.Point(244, 6);
            this.buttonEx_TeamFoldersLoadTeamFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersLoadTeamFolders.Name = "buttonEx_TeamFoldersLoadTeamFolders";
            this.buttonEx_TeamFoldersLoadTeamFolders.Size = new System.Drawing.Size(220, 37);
            this.buttonEx_TeamFoldersLoadTeamFolders.TabIndex = 4;
            this.buttonEx_TeamFoldersLoadTeamFolders.Text = "Load Team Folders";
            this.buttonEx_TeamFoldersLoadTeamFolders.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamFoldersLoadTeamFolders.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TeamFoldersMembersGroup
            // 
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Controls.Add(this.objectListView_TeamFoldersMembers, 0, 0);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(1062, 477);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
            // 
            // objectListView_TeamFoldersMembers
            // 
            this.objectListView_TeamFoldersMembers.AllColumns.Add(this.olvColumnTeamFolders_TeamFolderName);
            this.objectListView_TeamFoldersMembers.AllColumns.Add(this.olvColumnTeamFolders_TeamFolderId);
            this.objectListView_TeamFoldersMembers.AllColumns.Add(this.olvColumnTeamFolders_Status);
            this.objectListView_TeamFoldersMembers.CellEditUseWholeCell = false;
            this.objectListView_TeamFoldersMembers.CheckBoxes = true;
            this.objectListView_TeamFoldersMembers.CheckedAspectName = "IsChecked";
            this.objectListView_TeamFoldersMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTeamFolders_TeamFolderName,
            this.olvColumnTeamFolders_TeamFolderId,
            this.olvColumnTeamFolders_Status});
            this.objectListView_TeamFoldersMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_TeamFoldersMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_TeamFoldersMembers.EmptyListMsg = "No Result";
            this.objectListView_TeamFoldersMembers.FullRowSelect = true;
            this.objectListView_TeamFoldersMembers.HasCollapsibleGroups = false;
            this.objectListView_TeamFoldersMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_TeamFoldersMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_TeamFoldersMembers.Location = new System.Drawing.Point(4, 5);
            this.objectListView_TeamFoldersMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_TeamFoldersMembers.Name = "objectListView_TeamFoldersMembers";
            this.objectListView_TeamFoldersMembers.ShowGroups = false;
            this.objectListView_TeamFoldersMembers.Size = new System.Drawing.Size(1054, 467);
            this.objectListView_TeamFoldersMembers.TabIndex = 1;
            this.objectListView_TeamFoldersMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_TeamFoldersMembers.UseNotifyPropertyChanged = true;
            this.objectListView_TeamFoldersMembers.View = System.Windows.Forms.View.Details;
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
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamFoldersPermsExportToCSV, 8, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamFoldersExportToCSV, 7, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamFoldersSetFolderSyncSetting, 4, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.buttonEx_TeamFoldersSetFolderStatus, 0, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Active, 1, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButtonNoSync, 6, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButtonSync, 5, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Controls.Add(this.radioButton_Archived, 2, 0);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Location = new System.Drawing.Point(4, 610);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Name = "tableLayoutPanel_TeamFoldersProvisionCommandGroup";
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.Size = new System.Drawing.Size(1062, 56);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_TeamFoldersPermsExportToCSV
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
            this.buttonEx_TeamFoldersPermsExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_TeamFoldersPermsExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamFoldersPermsExportToCSV.Location = new System.Drawing.Point(936, 5);
            this.buttonEx_TeamFoldersPermsExportToCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersPermsExportToCSV.Name = "buttonEx_TeamFoldersPermsExportToCSV";
            this.buttonEx_TeamFoldersPermsExportToCSV.Size = new System.Drawing.Size(153, 46);
            this.buttonEx_TeamFoldersPermsExportToCSV.TabIndex = 13;
            this.buttonEx_TeamFoldersPermsExportToCSV.Text = "Export Team Folder Members";
            this.buttonEx_TeamFoldersPermsExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamFoldersPermsExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_TeamFoldersExportToCSV
            // 
            this.buttonEx_TeamFoldersExportToCSV.ColorTable = office2010Blue1;
            this.buttonEx_TeamFoldersExportToCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamFoldersExportToCSV.Location = new System.Drawing.Point(702, 5);
            this.buttonEx_TeamFoldersExportToCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersExportToCSV.Name = "buttonEx_TeamFoldersExportToCSV";
            this.buttonEx_TeamFoldersExportToCSV.Size = new System.Drawing.Size(226, 46);
            this.buttonEx_TeamFoldersExportToCSV.TabIndex = 12;
            this.buttonEx_TeamFoldersExportToCSV.Text = "Export Team Folders ";
            this.buttonEx_TeamFoldersExportToCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamFoldersExportToCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_TeamFoldersSetFolderSyncSetting
            // 
            this.buttonEx_TeamFoldersSetFolderSyncSetting.ColorTable = office2010Blue1;
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Location = new System.Drawing.Point(396, 5);
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Name = "buttonEx_TeamFoldersSetFolderSyncSetting";
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Size = new System.Drawing.Size(172, 46);
            this.buttonEx_TeamFoldersSetFolderSyncSetting.TabIndex = 11;
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Text = "Change Sync Setting";
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamFoldersSetFolderSyncSetting.UseVisualStyleBackColor = true;
            this.buttonEx_TeamFoldersSetFolderSyncSetting.Visible = false;
            // 
            // buttonEx_TeamFoldersSetFolderStatus
            // 
            this.buttonEx_TeamFoldersSetFolderStatus.ColorTable = office2010Blue1;
            this.buttonEx_TeamFoldersSetFolderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TeamFoldersSetFolderStatus.Location = new System.Drawing.Point(4, 5);
            this.buttonEx_TeamFoldersSetFolderStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamFoldersSetFolderStatus.Name = "buttonEx_TeamFoldersSetFolderStatus";
            this.buttonEx_TeamFoldersSetFolderStatus.Size = new System.Drawing.Size(136, 46);
            this.buttonEx_TeamFoldersSetFolderStatus.TabIndex = 8;
            this.buttonEx_TeamFoldersSetFolderStatus.Text = "Change Status";
            this.buttonEx_TeamFoldersSetFolderStatus.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TeamFoldersSetFolderStatus.UseVisualStyleBackColor = true;
            // 
            // radioButton_Active
            // 
            this.radioButton_Active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Active.AutoSize = true;
            this.radioButton_Active.Location = new System.Drawing.Point(148, 19);
            this.radioButton_Active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Active.Name = "radioButton_Active";
            this.radioButton_Active.Size = new System.Drawing.Size(88, 17);
            this.radioButton_Active.TabIndex = 9;
            this.radioButton_Active.TabStop = true;
            this.radioButton_Active.Text = "Active";
            this.radioButton_Active.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoSync
            // 
            this.radioButtonNoSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonNoSync.AutoSize = true;
            this.radioButtonNoSync.Location = new System.Drawing.Point(671, 19);
            this.radioButtonNoSync.Name = "radioButtonNoSync";
            this.radioButtonNoSync.Size = new System.Drawing.Size(24, 17);
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
            this.radioButtonSync.Location = new System.Drawing.Point(575, 19);
            this.radioButtonSync.Name = "radioButtonSync";
            this.radioButtonSync.Size = new System.Drawing.Size(90, 17);
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
            this.radioButton_Archived.Location = new System.Drawing.Point(244, 19);
            this.radioButton_Archived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Archived.Name = "radioButton_Archived";
            this.radioButton_Archived.Size = new System.Drawing.Size(106, 17);
            this.radioButton_Archived.TabIndex = 10;
            this.radioButton_Archived.TabStop = true;
            this.radioButton_Archived.Text = "Archived";
            this.radioButton_Archived.UseVisualStyleBackColor = true;
            // 
            // TeamFoldersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamFoldersView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_TeamFolders.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.PerformLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_TeamFoldersMembers)).EndInit();
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersProvisionCommandGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersAccessToken;
        private System.Windows.Forms.Label label_TeamFoldersAccessToken;
        private TextBoxEx textBox_TeamFoldersAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMembersGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_TeamFoldersMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_TeamFolderName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersSendEmailGroup;
        private ButtonEx buttonEx_TeamFoldersLoadTeamFolders;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_Status;
        private BrightIdeasSoftware.OLVColumn olvColumnTeamFolders_TeamFolderId;
        private ButtonEx buttonEx_TeamFoldersSetFolderStatus;
        private ButtonEx buttonEx_TeamFoldersCreateTeamFolder;
        private System.Windows.Forms.TextBox textBoxTeamFolder;
        private System.Windows.Forms.RadioButton radioButton_Active;
        private System.Windows.Forms.RadioButton radioButton_Archived;
        private System.Windows.Forms.RadioButton radioButtonSync;
        private System.Windows.Forms.RadioButton radioButtonNoSync;
        private ButtonEx buttonEx_TeamFoldersSetFolderSyncSetting;
        private ButtonEx buttonEx_TeamFoldersExportToCSV;
        private System.Windows.Forms.Button buttonEx_TeamFoldersLoadFromCSV;
        private ButtonEx buttonEx_TeamFoldersPermsExportToCSV;
    }
}