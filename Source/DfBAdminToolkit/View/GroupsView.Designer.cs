namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class GroupsView
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
            this.tableLayoutPanel_Groups = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_GroupsCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_GroupsAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_GroupsAccessToken = new System.Windows.Forms.Label();
            this.textBox_GroupsAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_GroupsCreateGroup = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_GroupsSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_GroupsLoadGroups = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_GroupsMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_GroupsMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnGroups_GroupName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnGroups_MemberCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnGroups_GroupId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_GroupsProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_GroupsDeleteMember = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_GroupsAddMember = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBoxAddMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Groups.SuspendLayout();
            this.tableLayoutPanel_GroupsCommandGroup.SuspendLayout();
            this.tableLayoutPanel_GroupsAccessToken.SuspendLayout();
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.SuspendLayout();
            this.tableLayoutPanel_GroupsSendEmailGroup.SuspendLayout();
            this.tableLayoutPanel_GroupsMembersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_GroupsMembers)).BeginInit();
            this.tableLayoutPanel_GroupsProvisionCommandGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Groups
            // 
            this.tableLayoutPanel_Groups.ColumnCount = 1;
            this.tableLayoutPanel_Groups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Groups.Controls.Add(this.tableLayoutPanel_GroupsCommandGroup, 0, 0);
            this.tableLayoutPanel_Groups.Controls.Add(this.tableLayoutPanel_GroupsMembersGroup, 0, 2);
            this.tableLayoutPanel_Groups.Controls.Add(this.tableLayoutPanel_GroupsProvisionCommandGroup, 0, 3);
            this.tableLayoutPanel_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Groups.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Groups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Groups.Name = "tableLayoutPanel_Groups";
            this.tableLayoutPanel_Groups.RowCount = 4;
            this.tableLayoutPanel_Groups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel_Groups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_Groups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Groups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_Groups.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_Groups.TabIndex = 1;
            // 
            // tableLayoutPanel_GroupsCommandGroup
            // 
            this.tableLayoutPanel_GroupsCommandGroup.ColumnCount = 3;
            this.tableLayoutPanel_GroupsCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_GroupsCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel_GroupsCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_GroupsCommandGroup.Controls.Add(this.tableLayoutPanel_GroupsAccessToken, 2, 0);
            this.tableLayoutPanel_GroupsCommandGroup.Controls.Add(this.tableLayoutPanel_GroupsMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_GroupsCommandGroup.Controls.Add(this.tableLayoutPanel_GroupsSendEmailGroup, 2, 1);
            this.tableLayoutPanel_GroupsCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsCommandGroup.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_GroupsCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_GroupsCommandGroup.Name = "tableLayoutPanel_GroupsCommandGroup";
            this.tableLayoutPanel_GroupsCommandGroup.RowCount = 2;
            this.tableLayoutPanel_GroupsCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel_GroupsCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel_GroupsCommandGroup.Size = new System.Drawing.Size(1062, 98);
            this.tableLayoutPanel_GroupsCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_GroupsAccessToken
            // 
            this.tableLayoutPanel_GroupsAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_GroupsAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_GroupsAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_GroupsAccessToken.Controls.Add(this.label_GroupsAccessToken, 0, 0);
            this.tableLayoutPanel_GroupsAccessToken.Controls.Add(this.textBox_GroupsAccessToken, 1, 0);
            this.tableLayoutPanel_GroupsAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsAccessToken.Location = new System.Drawing.Point(555, 2);
            this.tableLayoutPanel_GroupsAccessToken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_GroupsAccessToken.Name = "tableLayoutPanel_GroupsAccessToken";
            this.tableLayoutPanel_GroupsAccessToken.RowCount = 1;
            this.tableLayoutPanel_GroupsAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsAccessToken.Size = new System.Drawing.Size(505, 38);
            this.tableLayoutPanel_GroupsAccessToken.TabIndex = 0;
            // 
            // label_GroupsAccessToken
            // 
            this.label_GroupsAccessToken.AutoSize = true;
            this.label_GroupsAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_GroupsAccessToken.Location = new System.Drawing.Point(4, 0);
            this.label_GroupsAccessToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GroupsAccessToken.Name = "label_GroupsAccessToken";
            this.label_GroupsAccessToken.Size = new System.Drawing.Size(127, 38);
            this.label_GroupsAccessToken.TabIndex = 0;
            this.label_GroupsAccessToken.Text = "Access Token";
            this.label_GroupsAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_GroupsAccessToken.Visible = false;
            // 
            // textBox_GroupsAccessToken
            // 
            this.textBox_GroupsAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_GroupsAccessToken.FileFilter = null;
            this.textBox_GroupsAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_GroupsAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_GroupsAccessToken.Name = "textBox_GroupsAccessToken";
            this.textBox_GroupsAccessToken.Size = new System.Drawing.Size(362, 26);
            this.textBox_GroupsAccessToken.TabIndex = 1;
            this.textBox_GroupsAccessToken.Visible = false;
            // 
            // tableLayoutPanel_GroupsMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.ColumnCount = 2;
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Controls.Add(this.buttonEx_GroupsCreateGroup, 0, 0);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Controls.Add(this.textBoxGroup, 0, 0);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Location = new System.Drawing.Point(4, 47);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Name = "tableLayoutPanel_GroupsMemberRoleSelectionGroup";
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.Size = new System.Drawing.Size(500, 46);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // buttonEx_GroupsCreateGroup
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
            this.buttonEx_GroupsCreateGroup.ColorTable = office2010White1;
            this.buttonEx_GroupsCreateGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_GroupsCreateGroup.Location = new System.Drawing.Point(402, 5);
            this.buttonEx_GroupsCreateGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_GroupsCreateGroup.Name = "buttonEx_GroupsCreateGroup";
            this.buttonEx_GroupsCreateGroup.Size = new System.Drawing.Size(94, 36);
            this.buttonEx_GroupsCreateGroup.TabIndex = 7;
            this.buttonEx_GroupsCreateGroup.Text = "Create Group";
            this.buttonEx_GroupsCreateGroup.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_GroupsCreateGroup.UseVisualStyleBackColor = true;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxGroup.Location = new System.Drawing.Point(4, 15);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(390, 26);
            this.textBoxGroup.TabIndex = 8;
            // 
            // tableLayoutPanel_GroupsSendEmailGroup
            // 
            this.tableLayoutPanel_GroupsSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_GroupsSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93534F));
            this.tableLayoutPanel_GroupsSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0504F));
            this.tableLayoutPanel_GroupsSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.01426F));
            this.tableLayoutPanel_GroupsSendEmailGroup.Controls.Add(this.buttonEx_GroupsLoadGroups, 2, 0);
            this.tableLayoutPanel_GroupsSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsSendEmailGroup.Location = new System.Drawing.Point(557, 47);
            this.tableLayoutPanel_GroupsSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_GroupsSendEmailGroup.Name = "tableLayoutPanel_GroupsSendEmailGroup";
            this.tableLayoutPanel_GroupsSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_GroupsSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_GroupsSendEmailGroup.Size = new System.Drawing.Size(501, 46);
            this.tableLayoutPanel_GroupsSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_GroupsLoadGroups
            // 
            this.buttonEx_GroupsLoadGroups.ColorTable = office2010White1;
            this.buttonEx_GroupsLoadGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_GroupsLoadGroups.Location = new System.Drawing.Point(343, 6);
            this.buttonEx_GroupsLoadGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_GroupsLoadGroups.Name = "buttonEx_GroupsLoadGroups";
            this.buttonEx_GroupsLoadGroups.Size = new System.Drawing.Size(154, 37);
            this.buttonEx_GroupsLoadGroups.TabIndex = 4;
            this.buttonEx_GroupsLoadGroups.Text = "Load Groups";
            this.buttonEx_GroupsLoadGroups.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_GroupsLoadGroups.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_GroupsMembersGroup
            // 
            this.tableLayoutPanel_GroupsMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_GroupsMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsMembersGroup.Controls.Add(this.objectListView_GroupsMembers, 0, 0);
            this.tableLayoutPanel_GroupsMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsMembersGroup.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanel_GroupsMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_GroupsMembersGroup.Name = "tableLayoutPanel_GroupsMembersGroup";
            this.tableLayoutPanel_GroupsMembersGroup.RowCount = 1;
            this.tableLayoutPanel_GroupsMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsMembersGroup.Size = new System.Drawing.Size(1062, 477);
            this.tableLayoutPanel_GroupsMembersGroup.TabIndex = 1;
            // 
            // objectListView_GroupsMembers
            // 
            this.objectListView_GroupsMembers.AllColumns.Add(this.olvColumnGroups_GroupName);
            this.objectListView_GroupsMembers.AllColumns.Add(this.olvColumnGroups_MemberCount);
            this.objectListView_GroupsMembers.AllColumns.Add(this.olvColumnGroups_GroupId);
            this.objectListView_GroupsMembers.CellEditUseWholeCell = false;
            this.objectListView_GroupsMembers.CheckBoxes = true;
            this.objectListView_GroupsMembers.CheckedAspectName = "IsChecked";
            this.objectListView_GroupsMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnGroups_GroupName,
            this.olvColumnGroups_MemberCount,
            this.olvColumnGroups_GroupId});
            this.objectListView_GroupsMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_GroupsMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_GroupsMembers.EmptyListMsg = "No Result";
            this.objectListView_GroupsMembers.FullRowSelect = true;
            this.objectListView_GroupsMembers.HasCollapsibleGroups = false;
            this.objectListView_GroupsMembers.SelectedBackColor = System.Drawing.Color.Empty;
            this.objectListView_GroupsMembers.SelectedBackColor = System.Drawing.Color.Empty;
            this.objectListView_GroupsMembers.Location = new System.Drawing.Point(4, 5);
            this.objectListView_GroupsMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_GroupsMembers.Name = "objectListView_GroupsMembers";
            this.objectListView_GroupsMembers.ShowGroups = false;
            this.objectListView_GroupsMembers.Size = new System.Drawing.Size(1054, 467);
            this.objectListView_GroupsMembers.TabIndex = 1;
            this.objectListView_GroupsMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_GroupsMembers.UseNotifyPropertyChanged = true;
            this.objectListView_GroupsMembers.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnGroups_GroupName
            // 
            this.olvColumnGroups_GroupName.AspectName = "GroupName";
            this.olvColumnGroups_GroupName.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnGroups_GroupName.Hideable = false;
            this.olvColumnGroups_GroupName.MinimumWidth = 150;
            this.olvColumnGroups_GroupName.Text = "GroupName";
            this.olvColumnGroups_GroupName.Width = 150;
            // 
            // olvColumnGroups_MemberCount
            // 
            this.olvColumnGroups_MemberCount.AspectName = "MemberCount";
            this.olvColumnGroups_MemberCount.MinimumWidth = 100;
            this.olvColumnGroups_MemberCount.Text = "MemberCount";
            this.olvColumnGroups_MemberCount.Width = 100;
            // 
            // olvColumnGroups_GroupId
            // 
            this.olvColumnGroups_GroupId.AspectName = "GroupId";
            this.olvColumnGroups_GroupId.MinimumWidth = 300;
            this.olvColumnGroups_GroupId.Text = "GroupId";
            this.olvColumnGroups_GroupId.Width = 300;
            // 
            // tableLayoutPanel_GroupsProvisionCommandGroup
            // 
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnCount = 5;
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Controls.Add(this.buttonEx_GroupsDeleteMember, 3, 0);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Controls.Add(this.buttonEx_GroupsAddMember, 1, 0);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Controls.Add(this.textBoxAddMember, 1, 0);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Location = new System.Drawing.Point(4, 610);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Name = "tableLayoutPanel_GroupsProvisionCommandGroup";
            this.tableLayoutPanel_GroupsProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_GroupsProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_GroupsProvisionCommandGroup.Size = new System.Drawing.Size(1062, 56);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_GroupsDeleteMember
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
            this.buttonEx_GroupsDeleteMember.ColorTable = office2010Blue1;
            this.buttonEx_GroupsDeleteMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_GroupsDeleteMember.Location = new System.Drawing.Point(726, 5);
            this.buttonEx_GroupsDeleteMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_GroupsDeleteMember.Name = "buttonEx_GroupsDeleteMember";
            this.buttonEx_GroupsDeleteMember.Size = new System.Drawing.Size(162, 46);
            this.buttonEx_GroupsDeleteMember.TabIndex = 9;
            this.buttonEx_GroupsDeleteMember.Text = "Delete Member";
            this.buttonEx_GroupsDeleteMember.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_GroupsDeleteMember.UseVisualStyleBackColor = true;
            // 
            // buttonEx_GroupsAddMember
            // 
            this.buttonEx_GroupsAddMember.ColorTable = office2010Blue1;
            this.buttonEx_GroupsAddMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_GroupsAddMember.Location = new System.Drawing.Point(556, 5);
            this.buttonEx_GroupsAddMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_GroupsAddMember.Name = "buttonEx_GroupsAddMember";
            this.buttonEx_GroupsAddMember.Size = new System.Drawing.Size(162, 46);
            this.buttonEx_GroupsAddMember.TabIndex = 8;
            this.buttonEx_GroupsAddMember.Text = "Add Member";
            this.buttonEx_GroupsAddMember.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_GroupsAddMember.UseVisualStyleBackColor = true;
            // 
            // textBoxAddMember
            // 
            this.textBoxAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMember.Location = new System.Drawing.Point(72, 15);
            this.textBoxAddMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddMember.Name = "textBoxAddMember";
            this.textBoxAddMember.Size = new System.Drawing.Size(476, 26);
            this.textBoxAddMember.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_Groups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupsView";
            this.Text = "GroupsView";
            this.tableLayoutPanel_Groups.ResumeLayout(false);
            this.tableLayoutPanel_GroupsCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_GroupsAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_GroupsAccessToken.PerformLayout();
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_GroupsMemberRoleSelectionGroup.PerformLayout();
            this.tableLayoutPanel_GroupsSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_GroupsMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_GroupsMembers)).EndInit();
            this.tableLayoutPanel_GroupsProvisionCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_GroupsProvisionCommandGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Groups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsAccessToken;
        private System.Windows.Forms.Label label_GroupsAccessToken;
        private TextBoxEx textBox_GroupsAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsMembersGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_GroupsMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnGroups_GroupName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GroupsSendEmailGroup;
        private ButtonEx buttonEx_GroupsLoadGroups;
        private BrightIdeasSoftware.OLVColumn olvColumnGroups_MemberCount;
        private BrightIdeasSoftware.OLVColumn olvColumnGroups_GroupId;
        private System.Windows.Forms.TextBox textBoxAddMember;
        private ButtonEx buttonEx_GroupsDeleteMember;
        private ButtonEx buttonEx_GroupsAddMember;
        private System.Windows.Forms.Label label1;
        private ButtonEx buttonEx_GroupsCreateGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
    }
}