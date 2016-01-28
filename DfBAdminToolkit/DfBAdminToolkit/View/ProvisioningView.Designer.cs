namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class ProvisioningView
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
            this.tableLayoutPanel_Provisioning = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProvisioningCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProvisioningAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_ProvisioningAccessToken = new System.Windows.Forms.Label();
            this.textBox_ProvisioningAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_ProvisioningInputFile = new System.Windows.Forms.TableLayoutPanel();
            this.label_ProvisioningInputFile = new System.Windows.Forms.Label();
            this.textBox_ProvisioningInputFile = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.buttonEx_ProvisioningFileInputSelect = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.label_ProvisioningRole = new System.Windows.Forms.Label();
            this.groupBox_ProvisioningRoleGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_ProvisioningRoleMemberOnly = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleTeamAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleUserMgmtAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleSupportAdmin = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_ProvisioningSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_ProvisioningSendWelcomeEmail = new System.Windows.Forms.CheckBox();
            this.buttonEx_ProvisioningLoadCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_ProvisioningMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_ProvisioningMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnProvisioning_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_FirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_LastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_ProvisioningProvision = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_ProvisioningSplitter = new System.Windows.Forms.TableLayoutPanel();
            this.label_ProvisioningSplitter = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Provisioning.SuspendLayout();
            this.tableLayoutPanel_ProvisioningCommandGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningAccessToken.SuspendLayout();
            this.tableLayoutPanel_ProvisioningInputFile.SuspendLayout();
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.SuspendLayout();
            this.groupBox_ProvisioningRoleGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningSendEmailGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningMembersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ProvisioningMembers)).BeginInit();
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Provisioning
            // 
            this.tableLayoutPanel_Provisioning.ColumnCount = 1;
            this.tableLayoutPanel_Provisioning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningCommandGroup, 0, 0);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningMembersGroup, 0, 2);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningProvisionCommandGroup, 0, 3);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningSplitter, 0, 1);
            this.tableLayoutPanel_Provisioning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Provisioning.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Provisioning.Name = "tableLayoutPanel_Provisioning";
            this.tableLayoutPanel_Provisioning.RowCount = 4;
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Provisioning.Size = new System.Drawing.Size(713, 435);
            this.tableLayoutPanel_Provisioning.TabIndex = 1;
            // 
            // tableLayoutPanel_ProvisioningCommandGroup
            // 
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnCount = 3;
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProvisioningCommandGroup.Controls.Add(this.tableLayoutPanel_ProvisioningAccessToken, 2, 0);
            this.tableLayoutPanel_ProvisioningCommandGroup.Controls.Add(this.tableLayoutPanel_ProvisioningInputFile, 0, 0);
            this.tableLayoutPanel_ProvisioningCommandGroup.Controls.Add(this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_ProvisioningCommandGroup.Controls.Add(this.tableLayoutPanel_ProvisioningSendEmailGroup, 2, 1);
            this.tableLayoutPanel_ProvisioningCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningCommandGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ProvisioningCommandGroup.Name = "tableLayoutPanel_ProvisioningCommandGroup";
            this.tableLayoutPanel_ProvisioningCommandGroup.RowCount = 2;
            this.tableLayoutPanel_ProvisioningCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_ProvisioningCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel_ProvisioningCommandGroup.Size = new System.Drawing.Size(707, 120);
            this.tableLayoutPanel_ProvisioningCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_ProvisioningAccessToken
            // 
            this.tableLayoutPanel_ProvisioningAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_ProvisioningAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_ProvisioningAccessToken.Controls.Add(this.label_ProvisioningAccessToken, 0, 0);
            this.tableLayoutPanel_ProvisioningAccessToken.Controls.Add(this.textBox_ProvisioningAccessToken, 1, 0);
            this.tableLayoutPanel_ProvisioningAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningAccessToken.Location = new System.Drawing.Point(369, 1);
            this.tableLayoutPanel_ProvisioningAccessToken.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_ProvisioningAccessToken.Name = "tableLayoutPanel_ProvisioningAccessToken";
            this.tableLayoutPanel_ProvisioningAccessToken.RowCount = 1;
            this.tableLayoutPanel_ProvisioningAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningAccessToken.Size = new System.Drawing.Size(337, 27);
            this.tableLayoutPanel_ProvisioningAccessToken.TabIndex = 0;
            // 
            // label_ProvisioningAccessToken
            // 
            this.label_ProvisioningAccessToken.AutoSize = true;
            this.label_ProvisioningAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ProvisioningAccessToken.Location = new System.Drawing.Point(3, 0);
            this.label_ProvisioningAccessToken.Name = "label_ProvisioningAccessToken";
            this.label_ProvisioningAccessToken.Size = new System.Drawing.Size(84, 27);
            this.label_ProvisioningAccessToken.TabIndex = 0;
            this.label_ProvisioningAccessToken.Text = "Access Token";
            this.label_ProvisioningAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ProvisioningAccessToken.Visible = false;
            // 
            // textBox_ProvisioningAccessToken
            // 
            this.textBox_ProvisioningAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ProvisioningAccessToken.FileFilter = null;
            this.textBox_ProvisioningAccessToken.Location = new System.Drawing.Point(93, 3);
            this.textBox_ProvisioningAccessToken.Name = "textBox_ProvisioningAccessToken";
            this.textBox_ProvisioningAccessToken.Size = new System.Drawing.Size(241, 20);
            this.textBox_ProvisioningAccessToken.TabIndex = 1;
            this.textBox_ProvisioningAccessToken.Visible = false;
            // 
            // tableLayoutPanel_ProvisioningInputFile
            // 
            this.tableLayoutPanel_ProvisioningInputFile.ColumnCount = 3;
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.label_ProvisioningInputFile, 0, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.textBox_ProvisioningInputFile, 1, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.buttonEx_ProvisioningFileInputSelect, 2, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningInputFile.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel_ProvisioningInputFile.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_ProvisioningInputFile.Name = "tableLayoutPanel_ProvisioningInputFile";
            this.tableLayoutPanel_ProvisioningInputFile.RowCount = 1;
            this.tableLayoutPanel_ProvisioningInputFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningInputFile.Size = new System.Drawing.Size(336, 27);
            this.tableLayoutPanel_ProvisioningInputFile.TabIndex = 1;
            // 
            // label_ProvisioningInputFile
            // 
            this.label_ProvisioningInputFile.AutoSize = true;
            this.label_ProvisioningInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ProvisioningInputFile.Location = new System.Drawing.Point(3, 0);
            this.label_ProvisioningInputFile.Name = "label_ProvisioningInputFile";
            this.label_ProvisioningInputFile.Size = new System.Drawing.Size(56, 27);
            this.label_ProvisioningInputFile.TabIndex = 0;
            this.label_ProvisioningInputFile.Text = "CSV File";
            this.label_ProvisioningInputFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ProvisioningInputFile
            // 
            this.textBox_ProvisioningInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ProvisioningInputFile.FileFilter = null;
            this.textBox_ProvisioningInputFile.Location = new System.Drawing.Point(65, 4);
            this.textBox_ProvisioningInputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox_ProvisioningInputFile.Name = "textBox_ProvisioningInputFile";
            this.textBox_ProvisioningInputFile.Size = new System.Drawing.Size(198, 20);
            this.textBox_ProvisioningInputFile.TabIndex = 1;
            // 
            // buttonEx_ProvisioningFileInputSelect
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
            this.buttonEx_ProvisioningFileInputSelect.ColorTable = office2010White1;
            this.buttonEx_ProvisioningFileInputSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_ProvisioningFileInputSelect.Location = new System.Drawing.Point(269, 3);
            this.buttonEx_ProvisioningFileInputSelect.Name = "buttonEx_ProvisioningFileInputSelect";
            this.buttonEx_ProvisioningFileInputSelect.Size = new System.Drawing.Size(64, 21);
            this.buttonEx_ProvisioningFileInputSelect.TabIndex = 4;
            this.buttonEx_ProvisioningFileInputSelect.Text = "Select";
            this.buttonEx_ProvisioningFileInputSelect.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningFileInputSelect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_ProvisioningMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Controls.Add(this.label_ProvisioningRole, 0, 0);
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Controls.Add(this.groupBox_ProvisioningRoleGroup, 1, 0);
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Name = "tableLayoutPanel_ProvisioningMemberRoleSelectionGroup";
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.Size = new System.Drawing.Size(332, 85);
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // label_ProvisioningRole
            // 
            this.label_ProvisioningRole.AutoSize = true;
            this.label_ProvisioningRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ProvisioningRole.Location = new System.Drawing.Point(3, 22);
            this.label_ProvisioningRole.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.label_ProvisioningRole.Name = "label_ProvisioningRole";
            this.label_ProvisioningRole.Size = new System.Drawing.Size(54, 13);
            this.label_ProvisioningRole.TabIndex = 7;
            this.label_ProvisioningRole.Text = "Role";
            this.label_ProvisioningRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_ProvisioningRoleGroup
            // 
            this.groupBox_ProvisioningRoleGroup.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_ProvisioningRoleGroup.Controls.Add(this.tableLayoutPanel_ProvisioningRolesSelectionGroup);
            this.groupBox_ProvisioningRoleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ProvisioningRoleGroup.Location = new System.Drawing.Point(63, 3);
            this.groupBox_ProvisioningRoleGroup.Name = "groupBox_ProvisioningRoleGroup";
            this.groupBox_ProvisioningRoleGroup.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox_ProvisioningRoleGroup.Size = new System.Drawing.Size(266, 79);
            this.groupBox_ProvisioningRoleGroup.TabIndex = 6;
            this.groupBox_ProvisioningRoleGroup.TabStop = false;
            // 
            // tableLayoutPanel_ProvisioningRolesSelectionGroup
            // 
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleMemberOnly, 0, 0);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleTeamAdmin, 0, 1);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleUserMgmtAdmin, 1, 0);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleSupportAdmin, 1, 1);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Name = "tableLayoutPanel_ProvisioningRolesSelectionGroup";
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowCount = 2;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Size = new System.Drawing.Size(263, 60);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.TabIndex = 0;
            // 
            // radioButton_ProvisioningRoleMemberOnly
            // 
            this.radioButton_ProvisioningRoleMemberOnly.AutoSize = true;
            this.radioButton_ProvisioningRoleMemberOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_ProvisioningRoleMemberOnly.Location = new System.Drawing.Point(6, 6);
            this.radioButton_ProvisioningRoleMemberOnly.Name = "radioButton_ProvisioningRoleMemberOnly";
            this.radioButton_ProvisioningRoleMemberOnly.Size = new System.Drawing.Size(122, 19);
            this.radioButton_ProvisioningRoleMemberOnly.TabIndex = 2;
            this.radioButton_ProvisioningRoleMemberOnly.TabStop = true;
            this.radioButton_ProvisioningRoleMemberOnly.Text = "Member Only";
            this.radioButton_ProvisioningRoleMemberOnly.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleTeamAdmin
            // 
            this.radioButton_ProvisioningRoleTeamAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleTeamAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_ProvisioningRoleTeamAdmin.Location = new System.Drawing.Point(6, 31);
            this.radioButton_ProvisioningRoleTeamAdmin.Name = "radioButton_ProvisioningRoleTeamAdmin";
            this.radioButton_ProvisioningRoleTeamAdmin.Size = new System.Drawing.Size(122, 23);
            this.radioButton_ProvisioningRoleTeamAdmin.TabIndex = 3;
            this.radioButton_ProvisioningRoleTeamAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleTeamAdmin.Text = "Team Admin";
            this.radioButton_ProvisioningRoleTeamAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleUserMgmtAdmin
            // 
            this.radioButton_ProvisioningRoleUserMgmtAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Location = new System.Drawing.Point(134, 6);
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Name = "radioButton_ProvisioningRoleUserMgmtAdmin";
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Size = new System.Drawing.Size(123, 19);
            this.radioButton_ProvisioningRoleUserMgmtAdmin.TabIndex = 4;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Text = "User Mgmt Admin";
            this.radioButton_ProvisioningRoleUserMgmtAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleSupportAdmin
            // 
            this.radioButton_ProvisioningRoleSupportAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleSupportAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_ProvisioningRoleSupportAdmin.Location = new System.Drawing.Point(134, 31);
            this.radioButton_ProvisioningRoleSupportAdmin.Name = "radioButton_ProvisioningRoleSupportAdmin";
            this.radioButton_ProvisioningRoleSupportAdmin.Size = new System.Drawing.Size(123, 23);
            this.radioButton_ProvisioningRoleSupportAdmin.TabIndex = 5;
            this.radioButton_ProvisioningRoleSupportAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleSupportAdmin.Text = "Support Admin";
            this.radioButton_ProvisioningRoleSupportAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_ProvisioningSendEmailGroup
            // 
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Controls.Add(this.checkBox_ProvisioningSendWelcomeEmail, 0, 0);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Controls.Add(this.buttonEx_ProvisioningLoadCSV, 1, 0);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Location = new System.Drawing.Point(371, 32);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Name = "tableLayoutPanel_ProvisioningSendEmailGroup";
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Size = new System.Drawing.Size(333, 85);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.TabIndex = 3;
            // 
            // checkBox_ProvisioningSendWelcomeEmail
            // 
            this.checkBox_ProvisioningSendWelcomeEmail.AutoSize = true;
            this.checkBox_ProvisioningSendWelcomeEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ProvisioningSendWelcomeEmail.Location = new System.Drawing.Point(3, 22);
            this.checkBox_ProvisioningSendWelcomeEmail.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.checkBox_ProvisioningSendWelcomeEmail.Name = "checkBox_ProvisioningSendWelcomeEmail";
            this.checkBox_ProvisioningSendWelcomeEmail.Size = new System.Drawing.Size(227, 17);
            this.checkBox_ProvisioningSendWelcomeEmail.TabIndex = 5;
            this.checkBox_ProvisioningSendWelcomeEmail.Text = "Send Welcome Email";
            this.checkBox_ProvisioningSendWelcomeEmail.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningLoadCSV
            // 
            this.buttonEx_ProvisioningLoadCSV.ColorTable = office2010White1;
            this.buttonEx_ProvisioningLoadCSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_ProvisioningLoadCSV.Location = new System.Drawing.Point(236, 54);
            this.buttonEx_ProvisioningLoadCSV.Name = "buttonEx_ProvisioningLoadCSV";
            this.buttonEx_ProvisioningLoadCSV.Size = new System.Drawing.Size(94, 28);
            this.buttonEx_ProvisioningLoadCSV.TabIndex = 4;
            this.buttonEx_ProvisioningLoadCSV.Text = "Load CSV";
            this.buttonEx_ProvisioningLoadCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningLoadCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_ProvisioningMembersGroup
            // 
            this.tableLayoutPanel_ProvisioningMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_ProvisioningMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningMembersGroup.Controls.Add(this.objectListView_ProvisioningMembers, 0, 0);
            this.tableLayoutPanel_ProvisioningMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningMembersGroup.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel_ProvisioningMembersGroup.Name = "tableLayoutPanel_ProvisioningMembersGroup";
            this.tableLayoutPanel_ProvisioningMembersGroup.RowCount = 1;
            this.tableLayoutPanel_ProvisioningMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningMembersGroup.Size = new System.Drawing.Size(707, 253);
            this.tableLayoutPanel_ProvisioningMembersGroup.TabIndex = 1;
            // 
            // objectListView_ProvisioningMembers
            // 
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_Email);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_FirstName);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_LastName);
            this.objectListView_ProvisioningMembers.CellEditUseWholeCell = false;
            this.objectListView_ProvisioningMembers.CheckBoxes = true;
            this.objectListView_ProvisioningMembers.CheckedAspectName = "IsChecked";
            this.objectListView_ProvisioningMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnProvisioning_Email,
            this.olvColumnProvisioning_FirstName,
            this.olvColumnProvisioning_LastName});
            this.objectListView_ProvisioningMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_ProvisioningMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_ProvisioningMembers.EmptyListMsg = "No Result";
            this.objectListView_ProvisioningMembers.FullRowSelect = true;
            this.objectListView_ProvisioningMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_ProvisioningMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_ProvisioningMembers.Location = new System.Drawing.Point(3, 3);
            this.objectListView_ProvisioningMembers.Name = "objectListView_ProvisioningMembers";
            this.objectListView_ProvisioningMembers.Size = new System.Drawing.Size(701, 247);
            this.objectListView_ProvisioningMembers.TabIndex = 1;
            this.objectListView_ProvisioningMembers.UseCompatibleStateImageBehavior = false;
            this.objectListView_ProvisioningMembers.UseNotifyPropertyChanged = true;
            this.objectListView_ProvisioningMembers.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnProvisioning_Email
            // 
            this.olvColumnProvisioning_Email.AspectName = "Email";
            this.olvColumnProvisioning_Email.HeaderCheckBox = true;
            this.olvColumnProvisioning_Email.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnProvisioning_Email.Hideable = false;
            this.olvColumnProvisioning_Email.MinimumWidth = 180;
            this.olvColumnProvisioning_Email.Text = "Email";
            this.olvColumnProvisioning_Email.Width = 180;
            // 
            // olvColumnProvisioning_FirstName
            // 
            this.olvColumnProvisioning_FirstName.AspectName = "FirstName";
            this.olvColumnProvisioning_FirstName.Hideable = false;
            this.olvColumnProvisioning_FirstName.MinimumWidth = 120;
            this.olvColumnProvisioning_FirstName.Text = "First Name";
            this.olvColumnProvisioning_FirstName.UseInitialLetterForGroup = true;
            this.olvColumnProvisioning_FirstName.Width = 120;
            // 
            // olvColumnProvisioning_LastName
            // 
            this.olvColumnProvisioning_LastName.AspectName = "LastName";
            this.olvColumnProvisioning_LastName.FillsFreeSpace = true;
            this.olvColumnProvisioning_LastName.Hideable = false;
            this.olvColumnProvisioning_LastName.MinimumWidth = 120;
            this.olvColumnProvisioning_LastName.Text = "Last Name";
            this.olvColumnProvisioning_LastName.UseInitialLetterForGroup = true;
            this.olvColumnProvisioning_LastName.Width = 120;
            // 
            // tableLayoutPanel_ProvisioningProvisionCommandGroup
            // 
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningProvision, 1, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Location = new System.Drawing.Point(3, 397);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Name = "tableLayoutPanel_ProvisioningProvisionCommandGroup";
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Size = new System.Drawing.Size(707, 36);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_ProvisioningProvision
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
            this.buttonEx_ProvisioningProvision.ColorTable = office2010Blue1;
            this.buttonEx_ProvisioningProvision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_ProvisioningProvision.Location = new System.Drawing.Point(597, 3);
            this.buttonEx_ProvisioningProvision.Name = "buttonEx_ProvisioningProvision";
            this.buttonEx_ProvisioningProvision.Size = new System.Drawing.Size(107, 30);
            this.buttonEx_ProvisioningProvision.TabIndex = 1;
            this.buttonEx_ProvisioningProvision.Text = "Provision";
            this.buttonEx_ProvisioningProvision.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_ProvisioningProvision.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_ProvisioningSplitter
            // 
            this.tableLayoutPanel_ProvisioningSplitter.ColumnCount = 1;
            this.tableLayoutPanel_ProvisioningSplitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningSplitter.Controls.Add(this.label_ProvisioningSplitter, 0, 0);
            this.tableLayoutPanel_ProvisioningSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningSplitter.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel_ProvisioningSplitter.Name = "tableLayoutPanel_ProvisioningSplitter";
            this.tableLayoutPanel_ProvisioningSplitter.RowCount = 2;
            this.tableLayoutPanel_ProvisioningSplitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_ProvisioningSplitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningSplitter.Size = new System.Drawing.Size(707, 4);
            this.tableLayoutPanel_ProvisioningSplitter.TabIndex = 4;
            // 
            // label_ProvisioningSplitter
            // 
            this.label_ProvisioningSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ProvisioningSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ProvisioningSplitter.Location = new System.Drawing.Point(3, 0);
            this.label_ProvisioningSplitter.Name = "label_ProvisioningSplitter";
            this.label_ProvisioningSplitter.Size = new System.Drawing.Size(701, 2);
            this.label_ProvisioningSplitter.TabIndex = 0;
            // 
            // ProvisioningView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.tableLayoutPanel_Provisioning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProvisioningView";
            this.Text = "ProvisioningView";
            this.tableLayoutPanel_Provisioning.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningAccessToken.PerformLayout();
            this.tableLayoutPanel_ProvisioningInputFile.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningInputFile.PerformLayout();
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningMemberRoleSelectionGroup.PerformLayout();
            this.groupBox_ProvisioningRoleGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.PerformLayout();
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.PerformLayout();
            this.tableLayoutPanel_ProvisioningMembersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ProvisioningMembers)).EndInit();
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Provisioning;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningInputFile;
        private System.Windows.Forms.Label label_ProvisioningInputFile;
        private TextBoxEx textBox_ProvisioningInputFile;
        private System.Windows.Forms.Label label_ProvisioningAccessToken;
        private TextBoxEx textBox_ProvisioningAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningMembersGroup;
        private System.Windows.Forms.CheckBox checkBox_ProvisioningSendWelcomeEmail;
        private System.Windows.Forms.GroupBox groupBox_ProvisioningRoleGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningRolesSelectionGroup;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleUserMgmtAdmin;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleTeamAdmin;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleMemberOnly;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleSupportAdmin;
        private BrightIdeasSoftware.ObjectListView objectListView_ProvisioningMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_Email;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_FirstName;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_LastName;
        private System.Windows.Forms.Label label_ProvisioningRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningProvisionCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningSendEmailGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningSplitter;
        private System.Windows.Forms.Label label_ProvisioningSplitter;
        private ButtonEx buttonEx_ProvisioningFileInputSelect;
        private ButtonEx buttonEx_ProvisioningLoadCSV;
        private ButtonEx buttonEx_ProvisioningProvision;
    }
}