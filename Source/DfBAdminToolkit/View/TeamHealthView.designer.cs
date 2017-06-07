namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.Component;

    partial class TeamHealthView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel_TeamHealth = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel_TeamHealthCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamHealthAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_TeamHealthAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TeamHealthUsersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.labelLicenses = new System.Windows.Forms.Label();
            this.labelProvisioned = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamHealthSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TeamHealthRefresh = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.labelRefreshDateTime = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGauge = new System.Windows.Forms.TableLayoutPanel();
            this.aquaGaugeUsers = new AquaControls.AquaGauge();
            this.chartPieDevices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalUsage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSharedUsage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUnsharedUsage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSharedFolders = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelActiveShared = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelActiveUsers = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAdds = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelEdits = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelDeletes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamHealth.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel_TeamHealthCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamHealthAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamHealthUsersGroup.SuspendLayout();
            this.tableLayoutPanel_TeamHealthSendEmailGroup.SuspendLayout();
            this.tableLayoutPanelGauge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).BeginInit();
            this.tableLayoutPanelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_TeamHealth
            // 
            this.tableLayoutPanel_TeamHealth.ColumnCount = 1;
            this.tableLayoutPanel_TeamHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamHealth.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel_TeamHealth.Controls.Add(this.tableLayoutPanel_TeamHealthCommandGroup, 0, 0);
            this.tableLayoutPanel_TeamHealth.Controls.Add(this.tableLayoutPanel_TeamFoldersMembersGroup, 0, 2);
            this.tableLayoutPanel_TeamHealth.Controls.Add(this.tableLayoutPanelGauge, 0, 1);
            this.tableLayoutPanel_TeamHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamHealth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_TeamHealth.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TeamHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamHealth.Name = "tableLayoutPanel_TeamHealth";
            this.tableLayoutPanel_TeamHealth.RowCount = 5;
            this.tableLayoutPanel_TeamHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel_TeamHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel_TeamHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamHealth.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_TeamHealth.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62853F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37147F));
            this.tableLayoutPanel2.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 662);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(674, 2);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(338, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "pieDevices";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(332, 1);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Devices";
            // 
            // tableLayoutPanel_TeamHealthCommandGroup
            // 
            this.tableLayoutPanel_TeamHealthCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamHealthCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.12854F));
            this.tableLayoutPanel_TeamHealthCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_TeamHealthCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_TeamHealthCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.87146F));
            this.tableLayoutPanel_TeamHealthCommandGroup.Controls.Add(this.tableLayoutPanel_TeamHealthAccessToken, 3, 0);
            this.tableLayoutPanel_TeamHealthCommandGroup.Controls.Add(this.tableLayoutPanel_TeamHealthUsersGroup, 0, 1);
            this.tableLayoutPanel_TeamHealthCommandGroup.Controls.Add(this.tableLayoutPanel_TeamHealthSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamHealthCommandGroup.Controls.Add(this.labelTeamName, 0, 0);
            this.tableLayoutPanel_TeamHealthCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamHealthCommandGroup.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_TeamHealthCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamHealthCommandGroup.Name = "tableLayoutPanel_TeamHealthCommandGroup";
            this.tableLayoutPanel_TeamHealthCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamHealthCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_TeamHealthCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_TeamHealthCommandGroup.Size = new System.Drawing.Size(1062, 110);
            this.tableLayoutPanel_TeamHealthCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamHealthAccessToken
            // 
            this.tableLayoutPanel_TeamHealthAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamHealthAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_TeamHealthAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamHealthAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamHealthAccessToken.Controls.Add(this.textBox_TeamHealthAccessToken, 1, 0);
            this.tableLayoutPanel_TeamHealthAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamHealthAccessToken.Location = new System.Drawing.Point(620, 2);
            this.tableLayoutPanel_TeamHealthAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_TeamHealthAccessToken.Name = "tableLayoutPanel_TeamHealthAccessToken";
            this.tableLayoutPanel_TeamHealthAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamHealthAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamHealthAccessToken.Size = new System.Drawing.Size(440, 56);
            this.tableLayoutPanel_TeamHealthAccessToken.TabIndex = 0;
            // 
            // textBox_TeamHealthAccessToken
            // 
            this.textBox_TeamHealthAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TeamHealthAccessToken.FileFilter = null;
            this.textBox_TeamHealthAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_TeamHealthAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TeamHealthAccessToken.Name = "textBox_TeamHealthAccessToken";
            this.textBox_TeamHealthAccessToken.Size = new System.Drawing.Size(297, 22);
            this.textBox_TeamHealthAccessToken.TabIndex = 1;
            this.textBox_TeamHealthAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TeamHealthUsersGroup
            // 
            this.tableLayoutPanel_TeamHealthUsersGroup.ColumnCount = 2;
            this.tableLayoutPanel_TeamHealthUsersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_TeamHealthUsersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel_TeamHealthUsersGroup.Controls.Add(this.labelLicenses, 0, 0);
            this.tableLayoutPanel_TeamHealthUsersGroup.Controls.Add(this.labelProvisioned, 1, 0);
            this.tableLayoutPanel_TeamHealthUsersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamHealthUsersGroup.Location = new System.Drawing.Point(4, 65);
            this.tableLayoutPanel_TeamHealthUsersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamHealthUsersGroup.Name = "tableLayoutPanel_TeamHealthUsersGroup";
            this.tableLayoutPanel_TeamHealthUsersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamHealthUsersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamHealthUsersGroup.Size = new System.Drawing.Size(606, 50);
            this.tableLayoutPanel_TeamHealthUsersGroup.TabIndex = 2;
            // 
            // labelLicenses
            // 
            this.labelLicenses.AutoSize = true;
            this.labelLicenses.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenses.Location = new System.Drawing.Point(3, 0);
            this.labelLicenses.Name = "labelLicenses";
            this.labelLicenses.Size = new System.Drawing.Size(0, 32);
            this.labelLicenses.TabIndex = 0;
            // 
            // labelProvisioned
            // 
            this.labelProvisioned.AutoSize = true;
            this.labelProvisioned.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvisioned.Location = new System.Drawing.Point(275, 0);
            this.labelProvisioned.Name = "labelProvisioned";
            this.labelProvisioned.Size = new System.Drawing.Size(0, 32);
            this.labelProvisioned.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamHealthSendEmailGroup
            // 
            this.tableLayoutPanel_TeamHealthSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamHealthSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel_TeamHealthSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel_TeamHealthSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Controls.Add(this.buttonEx_TeamHealthRefresh, 2, 0);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Controls.Add(this.labelRefreshDateTime, 1, 0);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Location = new System.Drawing.Point(622, 65);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Name = "tableLayoutPanel_TeamHealthSendEmailGroup";
            this.tableLayoutPanel_TeamHealthSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamHealthSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel_TeamHealthSendEmailGroup.Size = new System.Drawing.Size(436, 50);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.TabIndex = 3;
            // 
            // buttonEx_TeamHealthRefresh
            // 
            this.buttonEx_TeamHealthRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonEx_TeamHealthRefresh.ColorTable = office2010White1;
            this.buttonEx_TeamHealthRefresh.Location = new System.Drawing.Point(308, 7);
            this.buttonEx_TeamHealthRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamHealthRefresh.Name = "buttonEx_TeamHealthRefresh";
            this.buttonEx_TeamHealthRefresh.Size = new System.Drawing.Size(124, 37);
            this.buttonEx_TeamHealthRefresh.TabIndex = 4;
            this.buttonEx_TeamHealthRefresh.Text = "Refresh";
            this.buttonEx_TeamHealthRefresh.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamHealthRefresh.UseVisualStyleBackColor = true;
            // 
            // labelRefreshDateTime
            // 
            this.labelRefreshDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRefreshDateTime.AutoSize = true;
            this.labelRefreshDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefreshDateTime.Location = new System.Drawing.Point(8, 17);
            this.labelRefreshDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshDateTime.Name = "labelRefreshDateTime";
            this.labelRefreshDateTime.Size = new System.Drawing.Size(292, 17);
            this.labelRefreshDateTime.TabIndex = 5;
            this.labelRefreshDateTime.Text = "Last Refresh: (Click Refresh)";
            // 
            // labelTeamName
            // 
            this.labelTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.Location = new System.Drawing.Point(4, 14);
            this.labelTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(606, 32);
            this.labelTeamName.TabIndex = 4;
            // 
            // tableLayoutPanel_TeamFoldersMembersGroup
            // 
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(4, 583);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(1062, 57);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
            // 
            // tableLayoutPanelGauge
            // 
            this.tableLayoutPanelGauge.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelGauge.ColumnCount = 3;
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGauge.Controls.Add(this.aquaGaugeUsers, 0, 0);
            this.tableLayoutPanelGauge.Controls.Add(this.chartPieDevices, 1, 0);
            this.tableLayoutPanelGauge.Controls.Add(this.tableLayoutPanelStats, 2, 0);
            this.tableLayoutPanelGauge.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanelGauge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelGauge.MinimumSize = new System.Drawing.Size(1350, 0);
            this.tableLayoutPanelGauge.Name = "tableLayoutPanelGauge";
            this.tableLayoutPanelGauge.RowCount = 1;
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGauge.Size = new System.Drawing.Size(1350, 425);
            this.tableLayoutPanelGauge.TabIndex = 4;
            // 
            // aquaGaugeUsers
            // 
            this.aquaGaugeUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aquaGaugeUsers.BackColor = System.Drawing.Color.Transparent;
            this.aquaGaugeUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aquaGaugeUsers.DialColor = System.Drawing.Color.Blue;
            this.aquaGaugeUsers.DialText = "Users";
            this.aquaGaugeUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aquaGaugeUsers.Glossiness = 11.36364F;
            this.aquaGaugeUsers.Location = new System.Drawing.Point(7, 9);
            this.aquaGaugeUsers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.aquaGaugeUsers.MaxValue = 0F;
            this.aquaGaugeUsers.MinValue = 0F;
            this.aquaGaugeUsers.Name = "aquaGaugeUsers";
            this.aquaGaugeUsers.NoOfDivisions = 5;
            this.aquaGaugeUsers.RecommendedValue = 0F;
            this.aquaGaugeUsers.Size = new System.Drawing.Size(383, 383);
            this.aquaGaugeUsers.TabIndex = 0;
            this.aquaGaugeUsers.ThresholdPercent = 90F;
            this.aquaGaugeUsers.Value = 0F;
            // 
            // chartPieDevices
            // 
            this.chartPieDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPieDevices.BackColor = System.Drawing.Color.Transparent;
            this.chartPieDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartPieDevices.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartPieDevices.BorderlineColor = System.Drawing.Color.Black;
            this.chartPieDevices.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartPieDevices.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartPieDevices.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPieDevices.Legends.Add(legend2);
            this.chartPieDevices.Location = new System.Drawing.Point(400, 4);
            this.chartPieDevices.MinimumSize = new System.Drawing.Size(400, 0);
            this.chartPieDevices.Name = "chartPieDevices";
            this.chartPieDevices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "pieDevices";
            this.chartPieDevices.Series.Add(series2);
            this.chartPieDevices.Size = new System.Drawing.Size(400, 420);
            this.chartPieDevices.TabIndex = 1;
            this.chartPieDevices.Text = "Devices";
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelStats.ColumnCount = 2;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStats.Controls.Add(this.labelTotalUsage, 1, 0);
            this.tableLayoutPanelStats.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelStats.Controls.Add(this.labelSharedUsage, 1, 1);
            this.tableLayoutPanelStats.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanelStats.Controls.Add(this.labelUnsharedUsage, 1, 2);
            this.tableLayoutPanelStats.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanelStats.Controls.Add(this.labelSharedFolders, 1, 3);
            this.tableLayoutPanelStats.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanelStats.Controls.Add(this.labelActiveShared, 1, 4);
            this.tableLayoutPanelStats.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanelStats.Controls.Add(this.labelActiveUsers, 1, 5);
            this.tableLayoutPanelStats.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanelStats.Controls.Add(this.labelAdds, 1, 6);
            this.tableLayoutPanelStats.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanelStats.Controls.Add(this.labelEdits, 1, 7);
            this.tableLayoutPanelStats.Controls.Add(this.label17, 0, 8);
            this.tableLayoutPanelStats.Controls.Add(this.labelDeletes, 1, 8);
            this.tableLayoutPanelStats.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(796, 4);
            this.tableLayoutPanelStats.MinimumSize = new System.Drawing.Size(548, 0);
            this.tableLayoutPanelStats.Name = "tableLayoutPanelStats";
            this.tableLayoutPanelStats.RowCount = 9;
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(550, 420);
            this.tableLayoutPanelStats.TabIndex = 2;
            this.tableLayoutPanelStats.Visible = false;
            // 
            // labelTotalUsage
            // 
            this.labelTotalUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalUsage.AutoSize = true;
            this.labelTotalUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUsage.Location = new System.Drawing.Point(274, 11);
            this.labelTotalUsage.Name = "labelTotalUsage";
            this.labelTotalUsage.Size = new System.Drawing.Size(272, 25);
            this.labelTotalUsage.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shared Usage";
            // 
            // labelSharedUsage
            // 
            this.labelSharedUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSharedUsage.AutoSize = true;
            this.labelSharedUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedUsage.Location = new System.Drawing.Point(274, 57);
            this.labelSharedUsage.Name = "labelSharedUsage";
            this.labelSharedUsage.Size = new System.Drawing.Size(272, 25);
            this.labelSharedUsage.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unshared Usage";
            // 
            // labelUnsharedUsage
            // 
            this.labelUnsharedUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnsharedUsage.AutoSize = true;
            this.labelUnsharedUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnsharedUsage.Location = new System.Drawing.Point(274, 103);
            this.labelUnsharedUsage.Name = "labelUnsharedUsage";
            this.labelUnsharedUsage.Size = new System.Drawing.Size(272, 25);
            this.labelUnsharedUsage.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Shared Folders";
            // 
            // labelSharedFolders
            // 
            this.labelSharedFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSharedFolders.AutoSize = true;
            this.labelSharedFolders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedFolders.Location = new System.Drawing.Point(274, 149);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(272, 25);
            this.labelSharedFolders.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Active Shared Folders (7 days)";
            // 
            // labelActiveShared
            // 
            this.labelActiveShared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActiveShared.AutoSize = true;
            this.labelActiveShared.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveShared.Location = new System.Drawing.Point(274, 195);
            this.labelActiveShared.Name = "labelActiveShared";
            this.labelActiveShared.Size = new System.Drawing.Size(272, 25);
            this.labelActiveShared.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Active Users (7 Days)";
            // 
            // labelActiveUsers
            // 
            this.labelActiveUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActiveUsers.AutoSize = true;
            this.labelActiveUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveUsers.Location = new System.Drawing.Point(274, 241);
            this.labelActiveUsers.Name = "labelActiveUsers";
            this.labelActiveUsers.Size = new System.Drawing.Size(272, 25);
            this.labelActiveUsers.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Adds";
            // 
            // labelAdds
            // 
            this.labelAdds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdds.AutoSize = true;
            this.labelAdds.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdds.Location = new System.Drawing.Point(274, 287);
            this.labelAdds.Name = "labelAdds";
            this.labelAdds.Size = new System.Drawing.Size(272, 25);
            this.labelAdds.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Edits";
            // 
            // labelEdits
            // 
            this.labelEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEdits.AutoSize = true;
            this.labelEdits.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdits.Location = new System.Drawing.Point(274, 333);
            this.labelEdits.Name = "labelEdits";
            this.labelEdits.Size = new System.Drawing.Size(272, 25);
            this.labelEdits.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(263, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Deletes";
            // 
            // labelDeletes
            // 
            this.labelDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeletes.AutoSize = true;
            this.labelDeletes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeletes.Location = new System.Drawing.Point(274, 381);
            this.labelDeletes.Name = "labelDeletes";
            this.labelDeletes.Size = new System.Drawing.Size(272, 25);
            this.labelDeletes.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Usage";
            // 
            // TeamHealthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_TeamHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamHealthView";
            this.Text = "TeamFoldersView";
            this.tableLayoutPanel_TeamHealth.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel_TeamHealthCommandGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamHealthCommandGroup.PerformLayout();
            this.tableLayoutPanel_TeamHealthAccessToken.ResumeLayout(false);
            this.tableLayoutPanel_TeamHealthAccessToken.PerformLayout();
            this.tableLayoutPanel_TeamHealthUsersGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamHealthUsersGroup.PerformLayout();
            this.tableLayoutPanel_TeamHealthSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamHealthSendEmailGroup.PerformLayout();
            this.tableLayoutPanelGauge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).EndInit();
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.tableLayoutPanelStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamHealth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamHealthCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamHealthAccessToken;
        private TextBoxEx textBox_TeamHealthAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMembersGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamHealthUsersGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamHealthSendEmailGroup;
        private ButtonEx buttonEx_TeamHealthRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGauge;
        private System.Windows.Forms.Label labelRefreshDateTime;
        private AquaControls.AquaGauge aquaGaugeUsers;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieDevices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSharedUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelUnsharedUsage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSharedFolders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelActiveShared;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelActiveUsers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelAdds;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelEdits;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelDeletes;
        private System.Windows.Forms.Label labelLicenses;
        private System.Windows.Forms.Label labelProvisioned;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}