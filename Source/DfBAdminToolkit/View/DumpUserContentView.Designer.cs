namespace DfBAdminToolkit.View
{
    partial class DumpUserContentView
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
            this.tableLayoutPanel_DumpUserContentMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MemberListGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MemberListCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MemberListAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.label_MemberListAccessToken = new System.Windows.Forms.Label();
            this.textBox_MemberListAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_DumpUserContentDisplayMembers = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_DumpUserContentFileCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxDeleteUser = new System.Windows.Forms.CheckBox();
            this.checkBoxSuspendUser = new System.Windows.Forms.CheckBox();
            this.label_DumpUserContentOutputDir = new System.Windows.Forms.Label();
            this.tableLayoutPanel_DumpUserContentFileSelection = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_DumpUserContentOutputDir = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.buttonEx_DumpUserContentSelect = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_DumpUserContentDump = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.checkBoxDumpToZip = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepAccount = new System.Windows.Forms.CheckBox();
            this.objectListView_MemberList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnContent_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_TeamId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_FilePath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_FileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_FileSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_DumpUserContentSplitContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label_DumpUserContentSpliter = new System.Windows.Forms.Label();
            this.label_DumpUserContentResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel_DumpUserContentMain.SuspendLayout();
            this.tableLayoutPanel_MemberListGroup.SuspendLayout();
            this.tableLayoutPanel_MemberListCommandGroup.SuspendLayout();
            this.tableLayoutPanel_MemberListAccessToken.SuspendLayout();
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.SuspendLayout();
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.SuspendLayout();
            this.tableLayoutPanel_DumpUserContentFileSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_MemberList)).BeginInit();
            this.tableLayoutPanel_DumpUserContentSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_DumpUserContentMain
            // 
            this.tableLayoutPanel_DumpUserContentMain.ColumnCount = 1;
            this.tableLayoutPanel_DumpUserContentMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentMain.Controls.Add(this.tableLayoutPanel_MemberListGroup, 0, 0);
            this.tableLayoutPanel_DumpUserContentMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DumpUserContentMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_DumpUserContentMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_DumpUserContentMain.Name = "tableLayoutPanel_DumpUserContentMain";
            this.tableLayoutPanel_DumpUserContentMain.RowCount = 1;
            this.tableLayoutPanel_DumpUserContentMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentMain.Size = new System.Drawing.Size(807, 502);
            this.tableLayoutPanel_DumpUserContentMain.TabIndex = 0;
            // 
            // tableLayoutPanel_MemberListGroup
            // 
            this.tableLayoutPanel_MemberListGroup.ColumnCount = 1;
            this.tableLayoutPanel_MemberListGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.tableLayoutPanel_MemberListCommandGroup, 0, 0);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.tableLayoutPanel_DumpUserContentFileCommandGroup, 0, 3);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.objectListView_MemberList, 0, 2);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.tableLayoutPanel_DumpUserContentSplitContainer, 0, 1);
            this.tableLayoutPanel_MemberListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MemberListGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_MemberListGroup.Name = "tableLayoutPanel_MemberListGroup";
            this.tableLayoutPanel_MemberListGroup.RowCount = 4;
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_MemberListGroup.Size = new System.Drawing.Size(801, 496);
            this.tableLayoutPanel_MemberListGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_MemberListCommandGroup
            // 
            this.tableLayoutPanel_MemberListCommandGroup.ColumnCount = 3;
            this.tableLayoutPanel_MemberListCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel_MemberListCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_MemberListCommandGroup.Controls.Add(this.tableLayoutPanel_MemberListAccessToken, 0, 0);
            this.tableLayoutPanel_MemberListCommandGroup.Controls.Add(this.tableLayoutPanel_DumpUserContentDisplayCommandGroup, 2, 0);
            this.tableLayoutPanel_MemberListCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MemberListCommandGroup.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel_MemberListCommandGroup.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_MemberListCommandGroup.Name = "tableLayoutPanel_MemberListCommandGroup";
            this.tableLayoutPanel_MemberListCommandGroup.RowCount = 1;
            this.tableLayoutPanel_MemberListCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListCommandGroup.Size = new System.Drawing.Size(799, 40);
            this.tableLayoutPanel_MemberListCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_MemberListAccessToken
            // 
            this.tableLayoutPanel_MemberListAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_MemberListAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_MemberListAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListAccessToken.Controls.Add(this.label_MemberListAccessToken, 0, 0);
            this.tableLayoutPanel_MemberListAccessToken.Controls.Add(this.textBox_MemberListAccessToken, 1, 0);
            this.tableLayoutPanel_MemberListAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MemberListAccessToken.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_MemberListAccessToken.Name = "tableLayoutPanel_MemberListAccessToken";
            this.tableLayoutPanel_MemberListAccessToken.RowCount = 1;
            this.tableLayoutPanel_MemberListAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListAccessToken.Size = new System.Drawing.Size(433, 34);
            this.tableLayoutPanel_MemberListAccessToken.TabIndex = 0;
            // 
            // label_MemberListAccessToken
            // 
            this.label_MemberListAccessToken.AutoSize = true;
            this.label_MemberListAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MemberListAccessToken.Location = new System.Drawing.Point(3, 0);
            this.label_MemberListAccessToken.Name = "label_MemberListAccessToken";
            this.label_MemberListAccessToken.Size = new System.Drawing.Size(84, 34);
            this.label_MemberListAccessToken.TabIndex = 0;
            this.label_MemberListAccessToken.Text = "Access Token";
            this.label_MemberListAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_MemberListAccessToken.Visible = false;
            // 
            // textBox_MemberListAccessToken
            // 
            this.textBox_MemberListAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MemberListAccessToken.FileFilter = null;
            this.textBox_MemberListAccessToken.Location = new System.Drawing.Point(91, 7);
            this.textBox_MemberListAccessToken.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
            this.textBox_MemberListAccessToken.Name = "textBox_MemberListAccessToken";
            this.textBox_MemberListAccessToken.Size = new System.Drawing.Size(341, 22);
            this.textBox_MemberListAccessToken.TabIndex = 0;
            this.textBox_MemberListAccessToken.Visible = false;
            // 
            // tableLayoutPanel_DumpUserContentDisplayCommandGroup
            // 
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ColumnCount = 2;
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.Controls.Add(this.buttonEx_DumpUserContentDisplayMembers, 1, 0);
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.Location = new System.Drawing.Point(552, 3);
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.Name = "tableLayoutPanel_DumpUserContentDisplayCommandGroup";
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.RowCount = 1;
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.Size = new System.Drawing.Size(244, 34);
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.TabIndex = 1;
            // 
            // buttonEx_DumpUserContentDisplayMembers
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
            this.buttonEx_DumpUserContentDisplayMembers.ColorTable = office2010White1;
            this.buttonEx_DumpUserContentDisplayMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_DumpUserContentDisplayMembers.Location = new System.Drawing.Point(122, 3);
            this.buttonEx_DumpUserContentDisplayMembers.Name = "buttonEx_DumpUserContentDisplayMembers";
            this.buttonEx_DumpUserContentDisplayMembers.Size = new System.Drawing.Size(119, 28);
            this.buttonEx_DumpUserContentDisplayMembers.TabIndex = 3;
            this.buttonEx_DumpUserContentDisplayMembers.Text = "Display Members";
            this.buttonEx_DumpUserContentDisplayMembers.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_DumpUserContentDisplayMembers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_DumpUserContentFileCommandGroup
            // 
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnCount = 7;
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.checkBoxDeleteUser, 3, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.checkBoxSuspendUser, 2, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.label_DumpUserContentOutputDir, 0, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.tableLayoutPanel_DumpUserContentFileSelection, 1, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.buttonEx_DumpUserContentDump, 6, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.checkBoxDumpToZip, 5, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Controls.Add(this.checkBoxKeepAccount, 4, 0);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Enabled = false;
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Location = new System.Drawing.Point(1, 459);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Name = "tableLayoutPanel_DumpUserContentFileCommandGroup";
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.RowCount = 1;
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Size = new System.Drawing.Size(799, 36);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.TabIndex = 2;
            // 
            // checkBoxDeleteUser
            // 
            this.checkBoxDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDeleteUser.AutoSize = true;
            this.checkBoxDeleteUser.Location = new System.Drawing.Point(374, 9);
            this.checkBoxDeleteUser.Name = "checkBoxDeleteUser";
            this.checkBoxDeleteUser.Size = new System.Drawing.Size(85, 17);
            this.checkBoxDeleteUser.TabIndex = 5;
            this.checkBoxDeleteUser.Text = "Delete User";
            this.checkBoxDeleteUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuspendUser
            // 
            this.checkBoxSuspendUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSuspendUser.AutoSize = true;
            this.checkBoxSuspendUser.Location = new System.Drawing.Point(267, 9);
            this.checkBoxSuspendUser.Name = "checkBoxSuspendUser";
            this.checkBoxSuspendUser.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSuspendUser.TabIndex = 4;
            this.checkBoxSuspendUser.Text = "Suspend User";
            this.checkBoxSuspendUser.UseVisualStyleBackColor = true;
            // 
            // label_DumpUserContentOutputDir
            // 
            this.label_DumpUserContentOutputDir.AutoSize = true;
            this.label_DumpUserContentOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DumpUserContentOutputDir.Location = new System.Drawing.Point(3, 0);
            this.label_DumpUserContentOutputDir.Name = "label_DumpUserContentOutputDir";
            this.label_DumpUserContentOutputDir.Size = new System.Drawing.Size(72, 36);
            this.label_DumpUserContentOutputDir.TabIndex = 0;
            this.label_DumpUserContentOutputDir.Text = "Output Dir:";
            this.label_DumpUserContentOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel_DumpUserContentFileSelection
            // 
            this.tableLayoutPanel_DumpUserContentFileSelection.ColumnCount = 2;
            this.tableLayoutPanel_DumpUserContentFileSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentFileSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_DumpUserContentFileSelection.Controls.Add(this.textBox_DumpUserContentOutputDir, 0, 0);
            this.tableLayoutPanel_DumpUserContentFileSelection.Controls.Add(this.buttonEx_DumpUserContentSelect, 1, 0);
            this.tableLayoutPanel_DumpUserContentFileSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DumpUserContentFileSelection.Location = new System.Drawing.Point(79, 1);
            this.tableLayoutPanel_DumpUserContentFileSelection.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_DumpUserContentFileSelection.Name = "tableLayoutPanel_DumpUserContentFileSelection";
            this.tableLayoutPanel_DumpUserContentFileSelection.RowCount = 1;
            this.tableLayoutPanel_DumpUserContentFileSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentFileSelection.Size = new System.Drawing.Size(184, 34);
            this.tableLayoutPanel_DumpUserContentFileSelection.TabIndex = 1;
            // 
            // textBox_DumpUserContentOutputDir
            // 
            this.textBox_DumpUserContentOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DumpUserContentOutputDir.FileFilter = null;
            this.textBox_DumpUserContentOutputDir.Location = new System.Drawing.Point(3, 7);
            this.textBox_DumpUserContentOutputDir.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textBox_DumpUserContentOutputDir.Name = "textBox_DumpUserContentOutputDir";
            this.textBox_DumpUserContentOutputDir.ReadOnly = true;
            this.textBox_DumpUserContentOutputDir.Size = new System.Drawing.Size(123, 22);
            this.textBox_DumpUserContentOutputDir.TabIndex = 0;
            // 
            // buttonEx_DumpUserContentSelect
            // 
            this.buttonEx_DumpUserContentSelect.ColorTable = office2010White1;
            this.buttonEx_DumpUserContentSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_DumpUserContentSelect.Location = new System.Drawing.Point(132, 3);
            this.buttonEx_DumpUserContentSelect.Name = "buttonEx_DumpUserContentSelect";
            this.buttonEx_DumpUserContentSelect.Size = new System.Drawing.Size(49, 28);
            this.buttonEx_DumpUserContentSelect.TabIndex = 1;
            this.buttonEx_DumpUserContentSelect.Text = "Select";
            this.buttonEx_DumpUserContentSelect.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_DumpUserContentSelect.UseVisualStyleBackColor = true;
            // 
            // buttonEx_DumpUserContentDump
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
            this.buttonEx_DumpUserContentDump.ColorTable = office2010Blue1;
            this.buttonEx_DumpUserContentDump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_DumpUserContentDump.Location = new System.Drawing.Point(699, 3);
            this.buttonEx_DumpUserContentDump.Name = "buttonEx_DumpUserContentDump";
            this.buttonEx_DumpUserContentDump.Size = new System.Drawing.Size(97, 30);
            this.buttonEx_DumpUserContentDump.TabIndex = 2;
            this.buttonEx_DumpUserContentDump.Text = "Dump File(s)";
            this.buttonEx_DumpUserContentDump.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_DumpUserContentDump.UseVisualStyleBackColor = true;
            // 
            // checkBoxDumpToZip
            // 
            this.checkBoxDumpToZip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDumpToZip.AutoSize = true;
            this.checkBoxDumpToZip.Location = new System.Drawing.Point(579, 9);
            this.checkBoxDumpToZip.Name = "checkBoxDumpToZip";
            this.checkBoxDumpToZip.Size = new System.Drawing.Size(111, 17);
            this.checkBoxDumpToZip.TabIndex = 3;
            this.checkBoxDumpToZip.Text = "Dump To Zip File";
            this.checkBoxDumpToZip.UseVisualStyleBackColor = true;
            this.checkBoxDumpToZip.CheckedChanged += new System.EventHandler(this.CheckBoxDumpToZip_CheckedChanged);
            // 
            // checkBoxKeepAccount
            // 
            this.checkBoxKeepAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKeepAccount.AutoSize = true;
            this.checkBoxKeepAccount.Location = new System.Drawing.Point(469, 9);
            this.checkBoxKeepAccount.Name = "checkBoxKeepAccount";
            this.checkBoxKeepAccount.Size = new System.Drawing.Size(101, 17);
            this.checkBoxKeepAccount.TabIndex = 6;
            this.checkBoxKeepAccount.Text = "Keep Account";
            this.checkBoxKeepAccount.UseVisualStyleBackColor = true;
            // 
            // objectListView_MemberList
            // 
            this.objectListView_MemberList.AllColumns.Add(this.olvColumnContent_Email);
            this.objectListView_MemberList.AllColumns.Add(this.olvColumnContent_TeamId);
            this.objectListView_MemberList.AllColumns.Add(this.olvColumnContent_FilePath);
            this.objectListView_MemberList.AllColumns.Add(this.olvColumnContent_FileName);
            this.objectListView_MemberList.AllColumns.Add(this.olvColumnContent_FileSize);
            this.objectListView_MemberList.CellEditUseWholeCell = false;
            this.objectListView_MemberList.CheckBoxes = true;
            this.objectListView_MemberList.CheckedAspectName = "IsChecked";
            this.objectListView_MemberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnContent_Email,
            this.olvColumnContent_TeamId,
            this.olvColumnContent_FilePath,
            this.olvColumnContent_FileName,
            this.olvColumnContent_FileSize});
            this.objectListView_MemberList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_MemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_MemberList.EmptyListMsg = "No Result";
            this.objectListView_MemberList.FullRowSelect = true;
            this.objectListView_MemberList.HideSelection = false;
            this.objectListView_MemberList.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_MemberList.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_MemberList.Location = new System.Drawing.Point(3, 83);
            this.objectListView_MemberList.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.objectListView_MemberList.Name = "objectListView_MemberList";
            this.objectListView_MemberList.ShowFilterMenuOnRightClick = false;
            this.objectListView_MemberList.ShowGroups = false;
            this.objectListView_MemberList.ShowImagesOnSubItems = true;
            this.objectListView_MemberList.ShowItemCountOnGroups = true;
            this.objectListView_MemberList.Size = new System.Drawing.Size(795, 372);
            this.objectListView_MemberList.SortGroupItemsByPrimaryColumn = false;
            this.objectListView_MemberList.TabIndex = 0;
            this.objectListView_MemberList.UseCellFormatEvents = true;
            this.objectListView_MemberList.UseCompatibleStateImageBehavior = false;
            this.objectListView_MemberList.UseFilterIndicator = true;
            this.objectListView_MemberList.UseHotItem = true;
            this.objectListView_MemberList.UseNotifyPropertyChanged = true;
            this.objectListView_MemberList.UseTranslucentHotItem = true;
            this.objectListView_MemberList.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnContent_Email
            // 
            this.olvColumnContent_Email.AspectName = "Email";
            this.olvColumnContent_Email.HeaderCheckBox = true;
            this.olvColumnContent_Email.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.olvColumnContent_Email.Hideable = false;
            this.olvColumnContent_Email.MinimumWidth = 170;
            this.olvColumnContent_Email.Text = "Email";
            this.olvColumnContent_Email.Width = 170;
            // 
            // olvColumnContent_TeamId
            // 
            this.olvColumnContent_TeamId.AspectName = "TeamId";
            this.olvColumnContent_TeamId.MinimumWidth = 150;
            this.olvColumnContent_TeamId.Text = "Team ID";
            this.olvColumnContent_TeamId.Width = 150;
            // 
            // olvColumnContent_FilePath
            // 
            this.olvColumnContent_FilePath.AspectName = "FilePath";
            this.olvColumnContent_FilePath.MinimumWidth = 220;
            this.olvColumnContent_FilePath.Text = "Path";
            this.olvColumnContent_FilePath.Width = 220;
            // 
            // olvColumnContent_FileName
            // 
            this.olvColumnContent_FileName.AspectName = "FileName";
            this.olvColumnContent_FileName.Hideable = false;
            this.olvColumnContent_FileName.MinimumWidth = 100;
            this.olvColumnContent_FileName.Text = "File Name";
            this.olvColumnContent_FileName.Width = 150;
            // 
            // olvColumnContent_FileSize
            // 
            this.olvColumnContent_FileSize.AspectName = "FileSize";
            this.olvColumnContent_FileSize.FillsFreeSpace = true;
            this.olvColumnContent_FileSize.Text = "File Size";
            this.olvColumnContent_FileSize.Width = 100;
            // 
            // tableLayoutPanel_DumpUserContentSplitContainer
            // 
            this.tableLayoutPanel_DumpUserContentSplitContainer.ColumnCount = 1;
            this.tableLayoutPanel_DumpUserContentSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentSplitContainer.Controls.Add(this.label_DumpUserContentSpliter, 0, 0);
            this.tableLayoutPanel_DumpUserContentSplitContainer.Controls.Add(this.label_DumpUserContentResult, 0, 1);
            this.tableLayoutPanel_DumpUserContentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DumpUserContentSplitContainer.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel_DumpUserContentSplitContainer.Name = "tableLayoutPanel_DumpUserContentSplitContainer";
            this.tableLayoutPanel_DumpUserContentSplitContainer.RowCount = 2;
            this.tableLayoutPanel_DumpUserContentSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_DumpUserContentSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DumpUserContentSplitContainer.Size = new System.Drawing.Size(795, 26);
            this.tableLayoutPanel_DumpUserContentSplitContainer.TabIndex = 3;
            // 
            // label_DumpUserContentSpliter
            // 
            this.label_DumpUserContentSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_DumpUserContentSpliter.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DumpUserContentSpliter.Location = new System.Drawing.Point(3, 0);
            this.label_DumpUserContentSpliter.Name = "label_DumpUserContentSpliter";
            this.label_DumpUserContentSpliter.Size = new System.Drawing.Size(789, 2);
            this.label_DumpUserContentSpliter.TabIndex = 0;
            // 
            // label_DumpUserContentResult
            // 
            this.label_DumpUserContentResult.AutoSize = true;
            this.label_DumpUserContentResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DumpUserContentResult.Location = new System.Drawing.Point(3, 4);
            this.label_DumpUserContentResult.Name = "label_DumpUserContentResult";
            this.label_DumpUserContentResult.Size = new System.Drawing.Size(789, 22);
            this.label_DumpUserContentResult.TabIndex = 1;
            this.label_DumpUserContentResult.Text = "Member Display";
            this.label_DumpUserContentResult.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DumpUserContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 502);
            this.Controls.Add(this.tableLayoutPanel_DumpUserContentMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DumpUserContentView";
            this.Text = "DumpUserContentView";
            this.tableLayoutPanel_DumpUserContentMain.ResumeLayout(false);
            this.tableLayoutPanel_MemberListGroup.ResumeLayout(false);
            this.tableLayoutPanel_MemberListCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_MemberListAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_MemberListAccessToken.PerformLayout();
            this.tableLayoutPanel_DumpUserContentDisplayCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.PerformLayout();
            this.tableLayoutPanel_DumpUserContentFileSelection.ResumeLayout(false);
            this.tableLayoutPanel_DumpUserContentFileSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_MemberList)).EndInit();
            this.tableLayoutPanel_DumpUserContentSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel_DumpUserContentSplitContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DumpUserContentMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MemberListGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_MemberList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MemberListCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MemberListAccessToken;
        private System.Windows.Forms.Label label_MemberListAccessToken;
        private DfBAdminToolkit.Common.Component.TextBoxEx textBox_MemberListAccessToken;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_Email;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_TeamId;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_FilePath;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_FileSize;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_FileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DumpUserContentFileCommandGroup;
        private System.Windows.Forms.Label label_DumpUserContentOutputDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DumpUserContentFileSelection;
        private DfBAdminToolkit.Common.Component.TextBoxEx textBox_DumpUserContentOutputDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DumpUserContentSplitContainer;
        private System.Windows.Forms.Label label_DumpUserContentSpliter;
        private System.Windows.Forms.Label label_DumpUserContentResult;
        private Common.Component.ButtonEx buttonEx_DumpUserContentSelect;
        private Common.Component.ButtonEx buttonEx_DumpUserContentDump;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DumpUserContentDisplayCommandGroup;
        private Common.Component.ButtonEx buttonEx_DumpUserContentDisplayMembers;
        private System.Windows.Forms.CheckBox checkBoxDumpToZip;
        private System.Windows.Forms.CheckBox checkBoxDeleteUser;
        private System.Windows.Forms.CheckBox checkBoxSuspendUser;
        private System.Windows.Forms.CheckBox checkBoxKeepAccount;
    }
}