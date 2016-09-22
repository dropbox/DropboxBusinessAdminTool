namespace DfBAdminToolkit.View
{
    using Common.Component;


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
            this.tableLayoutPanel_Provisioning = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProvisioningCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProvisioningInputFile = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ProvisioningInputFile = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_ProvisioningRoleTeamAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleUserMgmtAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleSupportAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_ProvisioningRoleMemberOnly = new System.Windows.Forms.RadioButton();
            this.checkBox_ProvisioningSendWelcomeEmail = new System.Windows.Forms.CheckBox();
            this.buttonEx_ProvisioningFileInputSelect = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_ProvisioningSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxProvisioningKeepAccount = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_ProvisioningLoadCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningLoadUpdateCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.objectListView_ProvisioningMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnProvisioning_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_FirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_LastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_Usage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_NewEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProvisioning_NewExternalId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBulkProvisioning = new System.Windows.Forms.RadioButton();
            this.radioBulkOffboard = new System.Windows.Forms.RadioButton();
            this.radioViewStatistics = new System.Windows.Forms.RadioButton();
            this.textBox_ProvisioningAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.radioBulkDelete = new System.Windows.Forms.RadioButton();
            this.radioBulkSuspend = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_ProvisioningDeprovision = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningProvision = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningSuspend = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningCreateCSV = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningGetUsage = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningUnsuspend = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_ProvisioningUpdateProfile = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_OpenTemplates = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_Provisioning.SuspendLayout();
            this.tableLayoutPanel_ProvisioningCommandGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningInputFile.SuspendLayout();
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.SuspendLayout();
            this.tableLayoutPanel_ProvisioningSendEmailGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ProvisioningMembers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Provisioning
            // 
            this.tableLayoutPanel_Provisioning.ColumnCount = 1;
            this.tableLayoutPanel_Provisioning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningCommandGroup, 0, 1);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.objectListView_ProvisioningMembers, 0, 2);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Provisioning.Controls.Add(this.tableLayoutPanel_ProvisioningProvisionCommandGroup, 0, 3);
            this.tableLayoutPanel_Provisioning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Provisioning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_Provisioning.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Provisioning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Provisioning.Name = "tableLayoutPanel_Provisioning";
            this.tableLayoutPanel_Provisioning.RowCount = 4;
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.84848F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.15151F));
            this.tableLayoutPanel_Provisioning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel_Provisioning.Size = new System.Drawing.Size(1070, 723);
            this.tableLayoutPanel_Provisioning.TabIndex = 1;
            // 
            // tableLayoutPanel_ProvisioningCommandGroup
            // 
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnCount = 1;
            this.tableLayoutPanel_ProvisioningCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_ProvisioningCommandGroup.Controls.Add(this.tableLayoutPanel_ProvisioningInputFile, 0, 0);
            this.tableLayoutPanel_ProvisioningCommandGroup.Location = new System.Drawing.Point(4, 51);
            this.tableLayoutPanel_ProvisioningCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ProvisioningCommandGroup.Name = "tableLayoutPanel_ProvisioningCommandGroup";
            this.tableLayoutPanel_ProvisioningCommandGroup.RowCount = 2;
            this.tableLayoutPanel_ProvisioningCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.35519F));
            this.tableLayoutPanel_ProvisioningCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_ProvisioningCommandGroup.Size = new System.Drawing.Size(1060, 202);
            this.tableLayoutPanel_ProvisioningCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_ProvisioningInputFile
            // 
            this.tableLayoutPanel_ProvisioningInputFile.ColumnCount = 4;
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 501F));
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.07371F));
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.92629F));
            this.tableLayoutPanel_ProvisioningInputFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.textBox_ProvisioningInputFile, 0, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.tableLayoutPanel_ProvisioningRolesSelectionGroup, 0, 1);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.buttonEx_ProvisioningFileInputSelect, 1, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.tableLayoutPanel_ProvisioningSendEmailGroup, 2, 1);
            this.tableLayoutPanel_ProvisioningInputFile.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel_ProvisioningInputFile.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_ProvisioningInputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_ProvisioningInputFile.Name = "tableLayoutPanel_ProvisioningInputFile";
            this.tableLayoutPanel_ProvisioningInputFile.RowCount = 2;
            this.tableLayoutPanel_ProvisioningInputFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.50847F));
            this.tableLayoutPanel_ProvisioningInputFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.49152F));
            this.tableLayoutPanel_ProvisioningInputFile.Size = new System.Drawing.Size(1056, 186);
            this.tableLayoutPanel_ProvisioningInputFile.TabIndex = 1;
            // 
            // textBox_ProvisioningInputFile
            // 
            this.textBox_ProvisioningInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ProvisioningInputFile.FileFilter = null;
            this.textBox_ProvisioningInputFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProvisioningInputFile.Location = new System.Drawing.Point(4, 17);
            this.textBox_ProvisioningInputFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.textBox_ProvisioningInputFile.Name = "textBox_ProvisioningInputFile";
            this.textBox_ProvisioningInputFile.Size = new System.Drawing.Size(493, 22);
            this.textBox_ProvisioningInputFile.TabIndex = 1;
            this.textBox_ProvisioningInputFile.Visible = false;
            // 
            // tableLayoutPanel_ProvisioningRolesSelectionGroup
            // 
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnCount = 2;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleTeamAdmin, 0, 1);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleUserMgmtAdmin, 1, 0);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleSupportAdmin, 1, 1);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.radioButton_ProvisioningRoleMemberOnly, 0, 0);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.Add(this.checkBox_ProvisioningSendWelcomeEmail, 0, 2);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Location = new System.Drawing.Point(4, 61);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Name = "tableLayoutPanel_ProvisioningRolesSelectionGroup";
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowCount = 3;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Size = new System.Drawing.Size(493, 120);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.TabIndex = 0;
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.Visible = false;
            // 
            // radioButton_ProvisioningRoleTeamAdmin
            // 
            this.radioButton_ProvisioningRoleTeamAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_ProvisioningRoleTeamAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleTeamAdmin.Location = new System.Drawing.Point(8, 50);
            this.radioButton_ProvisioningRoleTeamAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ProvisioningRoleTeamAdmin.Name = "radioButton_ProvisioningRoleTeamAdmin";
            this.radioButton_ProvisioningRoleTeamAdmin.Size = new System.Drawing.Size(229, 17);
            this.radioButton_ProvisioningRoleTeamAdmin.TabIndex = 3;
            this.radioButton_ProvisioningRoleTeamAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleTeamAdmin.Text = "Team Admin";
            this.radioButton_ProvisioningRoleTeamAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleUserMgmtAdmin
            // 
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_ProvisioningRoleUserMgmtAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Location = new System.Drawing.Point(245, 14);
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Name = "radioButton_ProvisioningRoleUserMgmtAdmin";
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Size = new System.Drawing.Size(240, 17);
            this.radioButton_ProvisioningRoleUserMgmtAdmin.TabIndex = 4;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleUserMgmtAdmin.Text = "User Management Admin";
            this.radioButton_ProvisioningRoleUserMgmtAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleSupportAdmin
            // 
            this.radioButton_ProvisioningRoleSupportAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_ProvisioningRoleSupportAdmin.AutoSize = true;
            this.radioButton_ProvisioningRoleSupportAdmin.Location = new System.Drawing.Point(245, 50);
            this.radioButton_ProvisioningRoleSupportAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ProvisioningRoleSupportAdmin.Name = "radioButton_ProvisioningRoleSupportAdmin";
            this.radioButton_ProvisioningRoleSupportAdmin.Size = new System.Drawing.Size(240, 17);
            this.radioButton_ProvisioningRoleSupportAdmin.TabIndex = 5;
            this.radioButton_ProvisioningRoleSupportAdmin.TabStop = true;
            this.radioButton_ProvisioningRoleSupportAdmin.Text = "Support Admin";
            this.radioButton_ProvisioningRoleSupportAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProvisioningRoleMemberOnly
            // 
            this.radioButton_ProvisioningRoleMemberOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_ProvisioningRoleMemberOnly.AutoSize = true;
            this.radioButton_ProvisioningRoleMemberOnly.Location = new System.Drawing.Point(8, 14);
            this.radioButton_ProvisioningRoleMemberOnly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ProvisioningRoleMemberOnly.Name = "radioButton_ProvisioningRoleMemberOnly";
            this.radioButton_ProvisioningRoleMemberOnly.Size = new System.Drawing.Size(229, 17);
            this.radioButton_ProvisioningRoleMemberOnly.TabIndex = 2;
            this.radioButton_ProvisioningRoleMemberOnly.TabStop = true;
            this.radioButton_ProvisioningRoleMemberOnly.Text = "Standard Team Member";
            this.radioButton_ProvisioningRoleMemberOnly.UseVisualStyleBackColor = true;
            // 
            // checkBox_ProvisioningSendWelcomeEmail
            // 
            this.checkBox_ProvisioningSendWelcomeEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ProvisioningSendWelcomeEmail.AutoSize = true;
            this.checkBox_ProvisioningSendWelcomeEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ProvisioningSendWelcomeEmail.Location = new System.Drawing.Point(8, 87);
            this.checkBox_ProvisioningSendWelcomeEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_ProvisioningSendWelcomeEmail.Name = "checkBox_ProvisioningSendWelcomeEmail";
            this.checkBox_ProvisioningSendWelcomeEmail.Size = new System.Drawing.Size(229, 17);
            this.checkBox_ProvisioningSendWelcomeEmail.TabIndex = 5;
            this.checkBox_ProvisioningSendWelcomeEmail.Text = "Send Team Join Emails";
            this.checkBox_ProvisioningSendWelcomeEmail.UseVisualStyleBackColor = true;
            this.checkBox_ProvisioningSendWelcomeEmail.Visible = false;
            // 
            // buttonEx_ProvisioningFileInputSelect
            // 
            this.buttonEx_ProvisioningFileInputSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningFileInputSelect.AutoSize = true;
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
            this.buttonEx_ProvisioningFileInputSelect.Location = new System.Drawing.Point(505, 5);
            this.buttonEx_ProvisioningFileInputSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningFileInputSelect.Name = "buttonEx_ProvisioningFileInputSelect";
            this.buttonEx_ProvisioningFileInputSelect.Size = new System.Drawing.Size(47, 46);
            this.buttonEx_ProvisioningFileInputSelect.TabIndex = 4;
            this.buttonEx_ProvisioningFileInputSelect.Text = "...";
            this.buttonEx_ProvisioningFileInputSelect.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningFileInputSelect.UseVisualStyleBackColor = true;
            this.buttonEx_ProvisioningFileInputSelect.Visible = false;
            // 
            // tableLayoutPanel_ProvisioningSendEmailGroup
            // 
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.58282F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.43558F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.28834F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Controls.Add(this.checkBoxProvisioningKeepAccount, 0, 0);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Location = new System.Drawing.Point(560, 61);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Name = "tableLayoutPanel_ProvisioningSendEmailGroup";
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowCount = 2;
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.48649F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.51351F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_ProvisioningSendEmailGroup.Size = new System.Drawing.Size(489, 120);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.TabIndex = 3;
            // 
            // checkBoxProvisioningKeepAccount
            // 
            this.checkBoxProvisioningKeepAccount.AutoSize = true;
            this.checkBoxProvisioningKeepAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxProvisioningKeepAccount.Location = new System.Drawing.Point(4, 5);
            this.checkBoxProvisioningKeepAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxProvisioningKeepAccount.Name = "checkBoxProvisioningKeepAccount";
            this.checkBoxProvisioningKeepAccount.Size = new System.Drawing.Size(165, 33);
            this.checkBoxProvisioningKeepAccount.TabIndex = 5;
            this.checkBoxProvisioningKeepAccount.Text = "Keep Account";
            this.checkBoxProvisioningKeepAccount.UseVisualStyleBackColor = true;
            this.checkBoxProvisioningKeepAccount.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonEx_OpenTemplates, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEx_ProvisioningLoadCSV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEx_ProvisioningLoadUpdateCSV, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(560, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 42);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // buttonEx_ProvisioningLoadCSV
            // 
            this.buttonEx_ProvisioningLoadCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningLoadCSV.ColorTable = office2010White1;
            this.buttonEx_ProvisioningLoadCSV.Location = new System.Drawing.Point(4, 5);
            this.buttonEx_ProvisioningLoadCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningLoadCSV.Name = "buttonEx_ProvisioningLoadCSV";
            this.buttonEx_ProvisioningLoadCSV.Size = new System.Drawing.Size(153, 32);
            this.buttonEx_ProvisioningLoadCSV.TabIndex = 4;
            this.buttonEx_ProvisioningLoadCSV.Text = "Load Input File";
            this.buttonEx_ProvisioningLoadCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningLoadCSV.UseVisualStyleBackColor = true;
            this.buttonEx_ProvisioningLoadCSV.Visible = false;
            // 
            // buttonEx_ProvisioningLoadUpdateCSV
            // 
            this.buttonEx_ProvisioningLoadUpdateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningLoadUpdateCSV.ColorTable = office2010White1;
            this.buttonEx_ProvisioningLoadUpdateCSV.Location = new System.Drawing.Point(165, 5);
            this.buttonEx_ProvisioningLoadUpdateCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningLoadUpdateCSV.Name = "buttonEx_ProvisioningLoadUpdateCSV";
            this.buttonEx_ProvisioningLoadUpdateCSV.Size = new System.Drawing.Size(153, 32);
            this.buttonEx_ProvisioningLoadUpdateCSV.TabIndex = 9;
            this.buttonEx_ProvisioningLoadUpdateCSV.Text = "Load Update CSV";
            this.buttonEx_ProvisioningLoadUpdateCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningLoadUpdateCSV.UseVisualStyleBackColor = true;
            this.buttonEx_ProvisioningLoadUpdateCSV.Visible = false;
            // 
            // objectListView_ProvisioningMembers
            // 
            this.objectListView_ProvisioningMembers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_Email);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_FirstName);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_LastName);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_Usage);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_NewEmail);
            this.objectListView_ProvisioningMembers.AllColumns.Add(this.olvColumnProvisioning_NewExternalId);
            this.objectListView_ProvisioningMembers.CellEditUseWholeCell = false;
            this.objectListView_ProvisioningMembers.CheckBoxes = true;
            this.objectListView_ProvisioningMembers.CheckedAspectName = "IsChecked";
            this.objectListView_ProvisioningMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnProvisioning_Email,
            this.olvColumnProvisioning_FirstName,
            this.olvColumnProvisioning_LastName,
            this.olvColumnProvisioning_Usage,
            this.olvColumnProvisioning_NewEmail,
            this.olvColumnProvisioning_NewExternalId});
            this.objectListView_ProvisioningMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_ProvisioningMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_ProvisioningMembers.EmptyListMsg = "";
            this.objectListView_ProvisioningMembers.FullRowSelect = true;
            this.objectListView_ProvisioningMembers.HasCollapsibleGroups = false;
            this.objectListView_ProvisioningMembers.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_ProvisioningMembers.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_ProvisioningMembers.Location = new System.Drawing.Point(4, 263);
            this.objectListView_ProvisioningMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView_ProvisioningMembers.Name = "objectListView_ProvisioningMembers";
            this.objectListView_ProvisioningMembers.ShowGroups = false;
            this.objectListView_ProvisioningMembers.Size = new System.Drawing.Size(1062, 388);
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
            this.olvColumnProvisioning_LastName.Hideable = false;
            this.olvColumnProvisioning_LastName.MinimumWidth = 120;
            this.olvColumnProvisioning_LastName.Text = "Last Name";
            this.olvColumnProvisioning_LastName.UseInitialLetterForGroup = true;
            this.olvColumnProvisioning_LastName.Width = 120;
            // 
            // olvColumnProvisioning_Usage
            // 
            this.olvColumnProvisioning_Usage.AspectName = "Usage (MB)";
            this.olvColumnProvisioning_Usage.FillsFreeSpace = true;
            this.olvColumnProvisioning_Usage.MinimumWidth = 100;
            this.olvColumnProvisioning_Usage.Text = "Usage (MB)";
            this.olvColumnProvisioning_Usage.Width = 100;
            // 
            // olvColumnProvisioning_NewEmail
            // 
            this.olvColumnProvisioning_NewEmail.AspectName = "NewEmail";
            this.olvColumnProvisioning_NewEmail.Text = "New Email";
            this.olvColumnProvisioning_NewEmail.Width = 120;
            // 
            // olvColumnProvisioning_NewExternalId
            // 
            this.olvColumnProvisioning_NewExternalId.AspectName = "NewExternalId";
            this.olvColumnProvisioning_NewExternalId.Text = "New External Id";
            this.olvColumnProvisioning_NewExternalId.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radioBulkProvisioning, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioBulkOffboard, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioViewStatistics, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ProvisioningAccessToken, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioBulkDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioBulkSuspend, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // radioBulkProvisioning
            // 
            this.radioBulkProvisioning.AutoSize = true;
            this.radioBulkProvisioning.Location = new System.Drawing.Point(4, 5);
            this.radioBulkProvisioning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBulkProvisioning.Name = "radioBulkProvisioning";
            this.radioBulkProvisioning.Size = new System.Drawing.Size(115, 17);
            this.radioBulkProvisioning.TabIndex = 0;
            this.radioBulkProvisioning.TabStop = true;
            this.radioBulkProvisioning.Text = "Bulk Provisioning";
            this.radioBulkProvisioning.UseVisualStyleBackColor = true;
            this.radioBulkProvisioning.CheckedChanged += new System.EventHandler(this.radioBulkProvisioning_CheckedChanged);
            // 
            // radioBulkOffboard
            // 
            this.radioBulkOffboard.AutoSize = true;
            this.radioBulkOffboard.Location = new System.Drawing.Point(255, 5);
            this.radioBulkOffboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBulkOffboard.Name = "radioBulkOffboard";
            this.radioBulkOffboard.Size = new System.Drawing.Size(113, 17);
            this.radioBulkOffboard.TabIndex = 2;
            this.radioBulkOffboard.TabStop = true;
            this.radioBulkOffboard.Text = "Account Updates";
            this.radioBulkOffboard.UseVisualStyleBackColor = true;
            this.radioBulkOffboard.CheckedChanged += new System.EventHandler(this.radioBulkOffboard_CheckedChanged);
            // 
            // radioViewStatistics
            // 
            this.radioViewStatistics.AutoSize = true;
            this.radioViewStatistics.Location = new System.Drawing.Point(376, 5);
            this.radioViewStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioViewStatistics.Name = "radioViewStatistics";
            this.radioViewStatistics.Size = new System.Drawing.Size(174, 17);
            this.radioViewStatistics.TabIndex = 3;
            this.radioViewStatistics.TabStop = true;
            this.radioViewStatistics.Text = "View or Export User Statistics";
            this.radioViewStatistics.UseVisualStyleBackColor = true;
            this.radioViewStatistics.CheckedChanged += new System.EventHandler(this.radioViewStatistics_CheckedChanged);
            // 
            // textBox_ProvisioningAccessToken
            // 
            this.textBox_ProvisioningAccessToken.FileFilter = null;
            this.textBox_ProvisioningAccessToken.Location = new System.Drawing.Point(655, 5);
            this.textBox_ProvisioningAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ProvisioningAccessToken.Name = "textBox_ProvisioningAccessToken";
            this.textBox_ProvisioningAccessToken.Size = new System.Drawing.Size(13, 22);
            this.textBox_ProvisioningAccessToken.TabIndex = 1;
            this.textBox_ProvisioningAccessToken.Visible = false;
            // 
            // radioBulkDelete
            // 
            this.radioBulkDelete.AutoSize = true;
            this.radioBulkDelete.ForeColor = System.Drawing.Color.Black;
            this.radioBulkDelete.Location = new System.Drawing.Point(558, 5);
            this.radioBulkDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBulkDelete.Name = "radioBulkDelete";
            this.radioBulkDelete.Size = new System.Drawing.Size(89, 17);
            this.radioBulkDelete.TabIndex = 4;
            this.radioBulkDelete.TabStop = true;
            this.radioBulkDelete.Text = "Delete Users";
            this.radioBulkDelete.UseVisualStyleBackColor = true;
            this.radioBulkDelete.CheckedChanged += new System.EventHandler(this.radioBulkDelete_CheckedChanged);
            // 
            // radioBulkSuspend
            // 
            this.radioBulkSuspend.AutoSize = true;
            this.radioBulkSuspend.Location = new System.Drawing.Point(127, 5);
            this.radioBulkSuspend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBulkSuspend.Name = "radioBulkSuspend";
            this.radioBulkSuspend.Size = new System.Drawing.Size(120, 17);
            this.radioBulkSuspend.TabIndex = 1;
            this.radioBulkSuspend.TabStop = true;
            this.radioBulkSuspend.Text = "Suspend Accounts";
            this.radioBulkSuspend.UseVisualStyleBackColor = true;
            this.radioBulkSuspend.CheckedChanged += new System.EventHandler(this.radioBulkSuspendDelete_CheckedChanged);
            // 
            // tableLayoutPanel_ProvisioningProvisionCommandGroup
            // 
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnCount = 10;
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningDeprovision, 2, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningProvision, 0, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningSuspend, 5, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningCreateCSV, 9, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningGetUsage, 8, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningUnsuspend, 4, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Controls.Add(this.buttonEx_ProvisioningUpdateProfile, 6, 0);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Location = new System.Drawing.Point(4, 659);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Name = "tableLayoutPanel_ProvisioningProvisionCommandGroup";
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.RowCount = 1;
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.Size = new System.Drawing.Size(1060, 60);
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.TabIndex = 3;
            // 
            // buttonEx_ProvisioningDeprovision
            // 
            this.buttonEx_ProvisioningDeprovision.ColorTable = office2010White1;
            this.buttonEx_ProvisioningDeprovision.Location = new System.Drawing.Point(122, 3);
            this.buttonEx_ProvisioningDeprovision.Name = "buttonEx_ProvisioningDeprovision";
            this.buttonEx_ProvisioningDeprovision.Size = new System.Drawing.Size(111, 49);
            this.buttonEx_ProvisioningDeprovision.TabIndex = 2;
            this.buttonEx_ProvisioningDeprovision.Text = "Deprovision";
            this.buttonEx_ProvisioningDeprovision.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningDeprovision.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningProvision
            // 
            this.buttonEx_ProvisioningProvision.ColorTable = office2010White1;
            this.buttonEx_ProvisioningProvision.Location = new System.Drawing.Point(4, 5);
            this.buttonEx_ProvisioningProvision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningProvision.Name = "buttonEx_ProvisioningProvision";
            this.buttonEx_ProvisioningProvision.Size = new System.Drawing.Size(111, 46);
            this.buttonEx_ProvisioningProvision.TabIndex = 1;
            this.buttonEx_ProvisioningProvision.Text = "Provision";
            this.buttonEx_ProvisioningProvision.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningProvision.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningSuspend
            // 
            this.buttonEx_ProvisioningSuspend.ColorTable = office2010White1;
            this.buttonEx_ProvisioningSuspend.Location = new System.Drawing.Point(358, 5);
            this.buttonEx_ProvisioningSuspend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningSuspend.Name = "buttonEx_ProvisioningSuspend";
            this.buttonEx_ProvisioningSuspend.Size = new System.Drawing.Size(105, 46);
            this.buttonEx_ProvisioningSuspend.TabIndex = 3;
            this.buttonEx_ProvisioningSuspend.Text = "Suspend";
            this.buttonEx_ProvisioningSuspend.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningSuspend.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningCreateCSV
            // 
            this.buttonEx_ProvisioningCreateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningCreateCSV.ColorTable = office2010White1;
            this.buttonEx_ProvisioningCreateCSV.Location = new System.Drawing.Point(810, 7);
            this.buttonEx_ProvisioningCreateCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningCreateCSV.Name = "buttonEx_ProvisioningCreateCSV";
            this.buttonEx_ProvisioningCreateCSV.Size = new System.Drawing.Size(246, 46);
            this.buttonEx_ProvisioningCreateCSV.TabIndex = 6;
            this.buttonEx_ProvisioningCreateCSV.Text = "Export Member Information";
            this.buttonEx_ProvisioningCreateCSV.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningCreateCSV.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningGetUsage
            // 
            this.buttonEx_ProvisioningGetUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningGetUsage.ColorTable = office2010White1;
            this.buttonEx_ProvisioningGetUsage.Location = new System.Drawing.Point(644, 7);
            this.buttonEx_ProvisioningGetUsage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningGetUsage.Name = "buttonEx_ProvisioningGetUsage";
            this.buttonEx_ProvisioningGetUsage.Size = new System.Drawing.Size(158, 46);
            this.buttonEx_ProvisioningGetUsage.TabIndex = 7;
            this.buttonEx_ProvisioningGetUsage.Text = "View Usage";
            this.buttonEx_ProvisioningGetUsage.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningGetUsage.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningUnsuspend
            // 
            this.buttonEx_ProvisioningUnsuspend.ColorTable = office2010White1;
            this.buttonEx_ProvisioningUnsuspend.Location = new System.Drawing.Point(240, 5);
            this.buttonEx_ProvisioningUnsuspend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningUnsuspend.Name = "buttonEx_ProvisioningUnsuspend";
            this.buttonEx_ProvisioningUnsuspend.Size = new System.Drawing.Size(110, 46);
            this.buttonEx_ProvisioningUnsuspend.TabIndex = 4;
            this.buttonEx_ProvisioningUnsuspend.Text = "Unsuspend";
            this.buttonEx_ProvisioningUnsuspend.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningUnsuspend.UseVisualStyleBackColor = true;
            // 
            // buttonEx_ProvisioningUpdateProfile
            // 
            this.buttonEx_ProvisioningUpdateProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_ProvisioningUpdateProfile.ColorTable = office2010White1;
            this.buttonEx_ProvisioningUpdateProfile.Location = new System.Drawing.Point(471, 7);
            this.buttonEx_ProvisioningUpdateProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_ProvisioningUpdateProfile.Name = "buttonEx_ProvisioningUpdateProfile";
            this.buttonEx_ProvisioningUpdateProfile.Size = new System.Drawing.Size(165, 46);
            this.buttonEx_ProvisioningUpdateProfile.TabIndex = 8;
            this.buttonEx_ProvisioningUpdateProfile.Text = "Update Members";
            this.buttonEx_ProvisioningUpdateProfile.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_ProvisioningUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // buttonEx_OpenTemplates
            // 
            this.buttonEx_OpenTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx_OpenTemplates.ColorTable = office2010White1;
            this.buttonEx_OpenTemplates.Location = new System.Drawing.Point(326, 5);
            this.buttonEx_OpenTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_OpenTemplates.Name = "buttonEx_OpenTemplates";
            this.buttonEx_OpenTemplates.Size = new System.Drawing.Size(154, 32);
            this.buttonEx_OpenTemplates.TabIndex = 10;
            this.buttonEx_OpenTemplates.Text = "Open Templates";
            this.buttonEx_OpenTemplates.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_OpenTemplates.UseVisualStyleBackColor = true;
            this.buttonEx_OpenTemplates.Visible = false;
            // 
            // ProvisioningView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 723);
            this.Controls.Add(this.tableLayoutPanel_Provisioning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProvisioningView";
            this.Text = "ProvisioningView";
            this.tableLayoutPanel_Provisioning.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningInputFile.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningInputFile.PerformLayout();
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningRolesSelectionGroup.PerformLayout();
            this.tableLayoutPanel_ProvisioningSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_ProvisioningSendEmailGroup.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_ProvisioningMembers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_ProvisioningProvisionCommandGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Provisioning;
        private BrightIdeasSoftware.ObjectListView objectListView_ProvisioningMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_Email;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_FirstName;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_LastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningProvisionCommandGroup;
        private ButtonEx buttonEx_ProvisioningProvision;
        private ButtonEx buttonEx_ProvisioningDeprovision;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_Usage;
        private ButtonEx buttonEx_ProvisioningUnsuspend;
        private ButtonEx buttonEx_ProvisioningSuspend;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_NewEmail;
        private BrightIdeasSoftware.OLVColumn olvColumnProvisioning_NewExternalId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioBulkProvisioning;
        private System.Windows.Forms.RadioButton radioBulkSuspend;
        private System.Windows.Forms.RadioButton radioBulkOffboard;
        private System.Windows.Forms.RadioButton radioViewStatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningInputFile;
        private TextBoxEx textBox_ProvisioningInputFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningRolesSelectionGroup;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleTeamAdmin;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleUserMgmtAdmin;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleSupportAdmin;
        private System.Windows.Forms.RadioButton radioButton_ProvisioningRoleMemberOnly;
        private ButtonEx buttonEx_ProvisioningFileInputSelect;
        private ButtonEx buttonEx_ProvisioningLoadCSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProvisioningSendEmailGroup;
        private ButtonEx buttonEx_ProvisioningLoadUpdateCSV;
        private ButtonEx buttonEx_ProvisioningUpdateProfile;
        private ButtonEx buttonEx_ProvisioningGetUsage;
        private ButtonEx buttonEx_ProvisioningCreateCSV;
        private System.Windows.Forms.CheckBox checkBox_ProvisioningSendWelcomeEmail;
        private System.Windows.Forms.CheckBox checkBoxProvisioningKeepAccount;
        private TextBoxEx textBox_ProvisioningAccessToken;
        private System.Windows.Forms.RadioButton radioBulkDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ButtonEx buttonEx_OpenTemplates;
    }
}