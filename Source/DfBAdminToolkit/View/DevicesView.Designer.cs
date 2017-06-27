namespace DfBAdminToolkit.View
{
    partial class DevicesView
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
            DfBAdminToolkit.Common.Component.Office2010Blue office2010Blue1 = new DfBAdminToolkit.Common.Component.Office2010Blue();
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            this.tableLayoutPanel_DevicesMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_MemberListGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_DevicesFileCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_ExportDevices = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.label_DevicesOutputDir = new System.Windows.Forms.Label();
            this.tableLayoutPanel_DevicesFileSelection = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_DevicesSelectFolder = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBox_DevicesOutputPath = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.objectListView_DeviceList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnContent_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_DeviceName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_IpAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_ClientType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_Created = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_Updated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_TeamId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnContent_SessionId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_DevicesSplitContainer = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_DevicesDump = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonLoadDevices = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.textBoxDeviceFilter = new System.Windows.Forms.TextBox();
            this.radioIpAddress = new System.Windows.Forms.RadioButton();
            this.radioDeviceFilter = new System.Windows.Forms.RadioButton();
            this.buttonDeviceFilterList = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.comboFilterCriteria = new System.Windows.Forms.ComboBox();
            this.checkBoxRemoteWipe = new System.Windows.Forms.CheckBox();
            this.textBox_DeviceListAccessToken = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_DevicesMain.SuspendLayout();
            this.tableLayoutPanel_MemberListGroup.SuspendLayout();
            this.tableLayoutPanel_DevicesFileCommandGroup.SuspendLayout();
            this.tableLayoutPanel_DevicesFileSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_DeviceList)).BeginInit();
            this.tableLayoutPanel_DevicesSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_DevicesMain
            // 
            this.tableLayoutPanel_DevicesMain.ColumnCount = 1;
            this.tableLayoutPanel_DevicesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesMain.Controls.Add(this.tableLayoutPanel_MemberListGroup, 0, 0);
            this.tableLayoutPanel_DevicesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DevicesMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_DevicesMain.Name = "tableLayoutPanel_DevicesMain";
            this.tableLayoutPanel_DevicesMain.RowCount = 1;
            this.tableLayoutPanel_DevicesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesMain.Size = new System.Drawing.Size(481, 457);
            this.tableLayoutPanel_DevicesMain.TabIndex = 0;
            // 
            // tableLayoutPanel_MemberListGroup
            // 
            this.tableLayoutPanel_MemberListGroup.ColumnCount = 1;
            this.tableLayoutPanel_MemberListGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.tableLayoutPanel_DevicesFileCommandGroup, 0, 3);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.objectListView_DeviceList, 0, 2);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.tableLayoutPanel_DevicesSplitContainer, 0, 1);
            this.tableLayoutPanel_MemberListGroup.Controls.Add(this.textBox_DeviceListAccessToken, 0, 0);
            this.tableLayoutPanel_MemberListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MemberListGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_MemberListGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_MemberListGroup.Name = "tableLayoutPanel_MemberListGroup";
            this.tableLayoutPanel_MemberListGroup.RowCount = 4;
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_MemberListGroup.Size = new System.Drawing.Size(475, 451);
            this.tableLayoutPanel_MemberListGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_DevicesFileCommandGroup
            // 
            this.tableLayoutPanel_DevicesFileCommandGroup.ColumnCount = 3;
            this.tableLayoutPanel_DevicesFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_DevicesFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesFileCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_DevicesFileCommandGroup.Controls.Add(this.buttonEx_ExportDevices, 2, 0);
            this.tableLayoutPanel_DevicesFileCommandGroup.Controls.Add(this.label_DevicesOutputDir, 0, 0);
            this.tableLayoutPanel_DevicesFileCommandGroup.Controls.Add(this.tableLayoutPanel_DevicesFileSelection, 1, 0);
            this.tableLayoutPanel_DevicesFileCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DevicesFileCommandGroup.Location = new System.Drawing.Point(1, 414);
            this.tableLayoutPanel_DevicesFileCommandGroup.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_DevicesFileCommandGroup.Name = "tableLayoutPanel_DevicesFileCommandGroup";
            this.tableLayoutPanel_DevicesFileCommandGroup.RowCount = 1;
            this.tableLayoutPanel_DevicesFileCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesFileCommandGroup.Size = new System.Drawing.Size(473, 36);
            this.tableLayoutPanel_DevicesFileCommandGroup.TabIndex = 2;
            // 
            // buttonEx_ExportDevices
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
            this.buttonEx_ExportDevices.ColorTable = office2010Blue1;
            this.buttonEx_ExportDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_ExportDevices.Location = new System.Drawing.Point(376, 3);
            this.buttonEx_ExportDevices.Name = "buttonEx_ExportDevices";
            this.buttonEx_ExportDevices.Size = new System.Drawing.Size(94, 30);
            this.buttonEx_ExportDevices.TabIndex = 5;
            this.buttonEx_ExportDevices.Text = "Export To CSV";
            this.buttonEx_ExportDevices.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_ExportDevices.UseVisualStyleBackColor = true;
            // 
            // label_DevicesOutputDir
            // 
            this.label_DevicesOutputDir.AutoSize = true;
            this.label_DevicesOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DevicesOutputDir.Location = new System.Drawing.Point(3, 0);
            this.label_DevicesOutputDir.Name = "label_DevicesOutputDir";
            this.label_DevicesOutputDir.Size = new System.Drawing.Size(84, 36);
            this.label_DevicesOutputDir.TabIndex = 0;
            this.label_DevicesOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel_DevicesFileSelection
            // 
            this.tableLayoutPanel_DevicesFileSelection.ColumnCount = 2;
            this.tableLayoutPanel_DevicesFileSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesFileSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_DevicesFileSelection.Controls.Add(this.buttonEx_DevicesSelectFolder, 0, 0);
            this.tableLayoutPanel_DevicesFileSelection.Controls.Add(this.textBox_DevicesOutputPath, 0, 0);
            this.tableLayoutPanel_DevicesFileSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DevicesFileSelection.Location = new System.Drawing.Point(91, 1);
            this.tableLayoutPanel_DevicesFileSelection.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_DevicesFileSelection.Name = "tableLayoutPanel_DevicesFileSelection";
            this.tableLayoutPanel_DevicesFileSelection.RowCount = 1;
            this.tableLayoutPanel_DevicesFileSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesFileSelection.Size = new System.Drawing.Size(281, 34);
            this.tableLayoutPanel_DevicesFileSelection.TabIndex = 1;
            // 
            // buttonEx_DevicesSelectFolder
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
            this.buttonEx_DevicesSelectFolder.ColorTable = office2010White1;
            this.buttonEx_DevicesSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_DevicesSelectFolder.Location = new System.Drawing.Point(224, 2);
            this.buttonEx_DevicesSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEx_DevicesSelectFolder.Name = "buttonEx_DevicesSelectFolder";
            this.buttonEx_DevicesSelectFolder.Size = new System.Drawing.Size(54, 30);
            this.buttonEx_DevicesSelectFolder.TabIndex = 3;
            this.buttonEx_DevicesSelectFolder.Text = "Select";
            this.buttonEx_DevicesSelectFolder.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_DevicesSelectFolder.UseVisualStyleBackColor = true;
            // 
            // textBox_DevicesOutputPath
            // 
            this.textBox_DevicesOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DevicesOutputPath.FileFilter = null;
            this.textBox_DevicesOutputPath.Location = new System.Drawing.Point(3, 5);
            this.textBox_DevicesOutputPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBox_DevicesOutputPath.Name = "textBox_DevicesOutputPath";
            this.textBox_DevicesOutputPath.ReadOnly = true;
            this.textBox_DevicesOutputPath.Size = new System.Drawing.Size(215, 22);
            this.textBox_DevicesOutputPath.TabIndex = 2;
            // 
            // objectListView_DeviceList
            // 
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_Email);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_DeviceName);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_IpAddress);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_ClientType);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_Created);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_Updated);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_TeamId);
            this.objectListView_DeviceList.AllColumns.Add(this.olvColumnContent_SessionId);
            this.objectListView_DeviceList.CellEditUseWholeCell = false;
            this.objectListView_DeviceList.CheckBoxes = true;
            this.objectListView_DeviceList.CheckedAspectName = "IsChecked";
            this.objectListView_DeviceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnContent_Email,
            this.olvColumnContent_DeviceName,
            this.olvColumnContent_IpAddress,
            this.olvColumnContent_ClientType,
            this.olvColumnContent_Created,
            this.olvColumnContent_Updated,
            this.olvColumnContent_TeamId,
            this.olvColumnContent_SessionId});
            this.objectListView_DeviceList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_DeviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_DeviceList.EmptyListMsg = "No Result";
            this.objectListView_DeviceList.FullRowSelect = true;
            this.objectListView_DeviceList.HideSelection = false;
            this.objectListView_DeviceList.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_DeviceList.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_DeviceList.Location = new System.Drawing.Point(3, 50);
            this.objectListView_DeviceList.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.objectListView_DeviceList.Name = "objectListView_DeviceList";
            this.objectListView_DeviceList.ShowFilterMenuOnRightClick = false;
            this.objectListView_DeviceList.ShowGroups = false;
            this.objectListView_DeviceList.ShowImagesOnSubItems = true;
            this.objectListView_DeviceList.ShowItemCountOnGroups = true;
            this.objectListView_DeviceList.Size = new System.Drawing.Size(469, 360);
            this.objectListView_DeviceList.SortGroupItemsByPrimaryColumn = false;
            this.objectListView_DeviceList.TabIndex = 0;
            this.objectListView_DeviceList.UseCellFormatEvents = true;
            this.objectListView_DeviceList.UseCompatibleStateImageBehavior = false;
            this.objectListView_DeviceList.UseFilterIndicator = true;
            this.objectListView_DeviceList.UseHotItem = true;
            this.objectListView_DeviceList.UseNotifyPropertyChanged = true;
            this.objectListView_DeviceList.UseTranslucentHotItem = true;
            this.objectListView_DeviceList.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnContent_Email
            // 
            this.olvColumnContent_Email.AspectName = "Email";
            this.olvColumnContent_Email.HeaderCheckBox = true;
            this.olvColumnContent_Email.Text = "Email";
            this.olvColumnContent_Email.Width = 170;
            // 
            // olvColumnContent_DeviceName
            // 
            this.olvColumnContent_DeviceName.AspectName = "DeviceName";
            this.olvColumnContent_DeviceName.MinimumWidth = 130;
            this.olvColumnContent_DeviceName.Text = "Device Name";
            this.olvColumnContent_DeviceName.Width = 180;
            // 
            // olvColumnContent_IpAddress
            // 
            this.olvColumnContent_IpAddress.AspectName = "IpAddress";
            this.olvColumnContent_IpAddress.Hideable = false;
            this.olvColumnContent_IpAddress.MinimumWidth = 90;
            this.olvColumnContent_IpAddress.Text = "Ip Address";
            this.olvColumnContent_IpAddress.Width = 90;
            // 
            // olvColumnContent_ClientType
            // 
            this.olvColumnContent_ClientType.AspectName = "ClientType";
            this.olvColumnContent_ClientType.Text = "Client Type";
            this.olvColumnContent_ClientType.Width = 75;
            // 
            // olvColumnContent_Created
            // 
            this.olvColumnContent_Created.AspectName = "Created";
            this.olvColumnContent_Created.Text = "Created";
            this.olvColumnContent_Created.Width = 130;
            // 
            // olvColumnContent_Updated
            // 
            this.olvColumnContent_Updated.AspectName = "Updated";
            this.olvColumnContent_Updated.Text = "Updated";
            this.olvColumnContent_Updated.Width = 130;
            // 
            // olvColumnContent_TeamId
            // 
            this.olvColumnContent_TeamId.AspectName = "TeamId";
            this.olvColumnContent_TeamId.MinimumWidth = 200;
            this.olvColumnContent_TeamId.Text = "Team ID";
            this.olvColumnContent_TeamId.Width = 200;
            // 
            // olvColumnContent_SessionId
            // 
            this.olvColumnContent_SessionId.AspectName = "SessionId";
            this.olvColumnContent_SessionId.FillsFreeSpace = true;
            this.olvColumnContent_SessionId.Text = "Session Id";
            this.olvColumnContent_SessionId.Width = 100;
            // 
            // tableLayoutPanel_DevicesSplitContainer
            // 
            this.tableLayoutPanel_DevicesSplitContainer.ColumnCount = 8;
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DevicesSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.buttonEx_DevicesDump, 0, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.buttonLoadDevices, 0, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.textBoxDeviceFilter, 4, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.radioIpAddress, 5, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.radioDeviceFilter, 6, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.buttonDeviceFilterList, 7, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.comboFilterCriteria, 3, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Controls.Add(this.checkBoxRemoteWipe, 2, 1);
            this.tableLayoutPanel_DevicesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DevicesSplitContainer.Location = new System.Drawing.Point(3, 9);
            this.tableLayoutPanel_DevicesSplitContainer.Name = "tableLayoutPanel_DevicesSplitContainer";
            this.tableLayoutPanel_DevicesSplitContainer.RowCount = 2;
            this.tableLayoutPanel_DevicesSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_DevicesSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DevicesSplitContainer.Size = new System.Drawing.Size(469, 29);
            this.tableLayoutPanel_DevicesSplitContainer.TabIndex = 3;
            // 
            // buttonEx_DevicesDump
            // 
            this.buttonEx_DevicesDump.ColorTable = office2010Blue1;
            this.buttonEx_DevicesDump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_DevicesDump.Enabled = false;
            this.buttonEx_DevicesDump.Location = new System.Drawing.Point(118, 7);
            this.buttonEx_DevicesDump.Name = "buttonEx_DevicesDump";
            this.buttonEx_DevicesDump.Size = new System.Drawing.Size(133, 19);
            this.buttonEx_DevicesDump.TabIndex = 8;
            this.buttonEx_DevicesDump.Text = "Remove Device(s)";
            this.buttonEx_DevicesDump.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_DevicesDump.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDevices
            // 
            this.buttonLoadDevices.ColorTable = office2010Blue1;
            this.buttonLoadDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadDevices.Location = new System.Drawing.Point(3, 7);
            this.buttonLoadDevices.Name = "buttonLoadDevices";
            this.buttonLoadDevices.Size = new System.Drawing.Size(109, 19);
            this.buttonLoadDevices.TabIndex = 5;
            this.buttonLoadDevices.Text = "Search Device(s)";
            this.buttonLoadDevices.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonLoadDevices.UseVisualStyleBackColor = true;
            // 
            // textBoxDeviceFilter
            // 
            this.textBoxDeviceFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDeviceFilter.Location = new System.Drawing.Point(235, 7);
            this.textBoxDeviceFilter.Name = "textBoxDeviceFilter";
            this.textBoxDeviceFilter.Size = new System.Drawing.Size(1, 22);
            this.textBoxDeviceFilter.TabIndex = 1;
            // 
            // radioIpAddress
            // 
            this.radioIpAddress.AutoSize = true;
            this.radioIpAddress.Location = new System.Drawing.Point(217, 7);
            this.radioIpAddress.Name = "radioIpAddress";
            this.radioIpAddress.Size = new System.Drawing.Size(78, 17);
            this.radioIpAddress.TabIndex = 2;
            this.radioIpAddress.TabStop = true;
            this.radioIpAddress.Text = "IP Address";
            this.radioIpAddress.UseVisualStyleBackColor = true;
            // 
            // radioDeviceFilter
            // 
            this.radioDeviceFilter.AutoSize = true;
            this.radioDeviceFilter.Location = new System.Drawing.Point(301, 7);
            this.radioDeviceFilter.Name = "radioDeviceFilter";
            this.radioDeviceFilter.Size = new System.Drawing.Size(90, 17);
            this.radioDeviceFilter.TabIndex = 3;
            this.radioDeviceFilter.TabStop = true;
            this.radioDeviceFilter.Text = "Device Name";
            this.radioDeviceFilter.UseVisualStyleBackColor = true;
            // 
            // buttonDeviceFilterList
            // 
            this.buttonDeviceFilterList.ColorTable = office2010Blue1;
            this.buttonDeviceFilterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeviceFilterList.Location = new System.Drawing.Point(397, 7);
            this.buttonDeviceFilterList.Name = "buttonDeviceFilterList";
            this.buttonDeviceFilterList.Size = new System.Drawing.Size(69, 19);
            this.buttonDeviceFilterList.TabIndex = 4;
            this.buttonDeviceFilterList.Text = "Filter";
            this.buttonDeviceFilterList.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonDeviceFilterList.UseVisualStyleBackColor = true;
            this.buttonDeviceFilterList.Visible = false;
            // 
            // comboFilterCriteria
            // 
            this.comboFilterCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboFilterCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterCriteria.FormattingEnabled = true;
            this.comboFilterCriteria.Items.AddRange(new object[] {
            "CONTAINS",
            "NOT CONTAINS",
            "BEGINS WITH",
            "ENDS WITH"});
            this.comboFilterCriteria.Location = new System.Drawing.Point(247, 7);
            this.comboFilterCriteria.Name = "comboFilterCriteria";
            this.comboFilterCriteria.Size = new System.Drawing.Size(1, 21);
            this.comboFilterCriteria.TabIndex = 9;
            // 
            // checkBoxRemoteWipe
            // 
            this.checkBoxRemoteWipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRemoteWipe.AutoSize = true;
            this.checkBoxRemoteWipe.Location = new System.Drawing.Point(256, 8);
            this.checkBoxRemoteWipe.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRemoteWipe.Name = "checkBoxRemoteWipe";
            this.checkBoxRemoteWipe.Size = new System.Drawing.Size(1, 17);
            this.checkBoxRemoteWipe.TabIndex = 10;
            this.checkBoxRemoteWipe.Text = "Remote Wipe";
            this.checkBoxRemoteWipe.UseVisualStyleBackColor = true;
            // 
            // textBox_DeviceListAccessToken
            // 
            this.textBox_DeviceListAccessToken.Location = new System.Drawing.Point(2, 2);
            this.textBox_DeviceListAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DeviceListAccessToken.Name = "textBox_DeviceListAccessToken";
            this.textBox_DeviceListAccessToken.Size = new System.Drawing.Size(68, 22);
            this.textBox_DeviceListAccessToken.TabIndex = 4;
            this.textBox_DeviceListAccessToken.Visible = false;
            // 
            // DevicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.tableLayoutPanel_DevicesMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevicesView";
            this.Text = "DevicesView";
            this.tableLayoutPanel_DevicesMain.ResumeLayout(false);
            this.tableLayoutPanel_MemberListGroup.ResumeLayout(false);
            this.tableLayoutPanel_MemberListGroup.PerformLayout();
            this.tableLayoutPanel_DevicesFileCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_DevicesFileCommandGroup.PerformLayout();
            this.tableLayoutPanel_DevicesFileSelection.ResumeLayout(false);
            this.tableLayoutPanel_DevicesFileSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_DeviceList)).EndInit();
            this.tableLayoutPanel_DevicesSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel_DevicesSplitContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DevicesMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MemberListGroup;
        private BrightIdeasSoftware.ObjectListView objectListView_DeviceList;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_TeamId;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_DeviceName;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_SessionId;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_IpAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DevicesFileCommandGroup;
        private System.Windows.Forms.Label label_DevicesOutputDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DevicesFileSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DevicesSplitContainer;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_ClientType;
        private System.Windows.Forms.TextBox textBox_DeviceListAccessToken;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_Created;
        private System.Windows.Forms.ComboBox comboFilterCriteria;
        private Common.Component.ButtonEx buttonDeviceFilterList;
        private System.Windows.Forms.RadioButton radioDeviceFilter;
        private System.Windows.Forms.RadioButton radioIpAddress;
        private System.Windows.Forms.TextBox textBoxDeviceFilter;
        private Common.Component.ButtonEx buttonLoadDevices;
        private Common.Component.ButtonEx buttonEx_DevicesDump;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_Email;
        private Common.Component.ButtonEx buttonEx_ExportDevices;
        private Common.Component.TextBoxEx textBox_DevicesOutputPath;
        private Common.Component.ButtonEx buttonEx_DevicesSelectFolder;
        private System.Windows.Forms.CheckBox checkBoxRemoteWipe;
        private BrightIdeasSoftware.OLVColumn olvColumnContent_Updated;
    }
}