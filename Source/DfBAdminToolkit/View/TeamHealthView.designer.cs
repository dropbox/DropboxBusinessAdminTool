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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DfBAdminToolkit.Common.Component.Office2010White office2010White2 = new DfBAdminToolkit.Common.Component.Office2010White();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel_TeamFolders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersCommandGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersAccessToken = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup = new System.Windows.Forms.TableLayoutPanel();
            this.labelRefreshDateTime = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TeamFoldersMembersGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGauge = new System.Windows.Forms.TableLayoutPanel();
            this.aquaGaugeUsers = new AquaControls.AquaGauge();
            this.chartPieDevices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox_TeamHealthAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.buttonEx_TeamHealthRefresh = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.labelLicenses = new System.Windows.Forms.Label();
            this.labelProvisioned = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TeamFolders.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.SuspendLayout();
            this.tableLayoutPanelGauge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).BeginInit();
            this.tableLayoutPanelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_TeamFolders
            // 
            this.tableLayoutPanel_TeamFolders.ColumnCount = 1;
            this.tableLayoutPanel_TeamFolders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersCommandGroup, 0, 0);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersMembersGroup, 0, 2);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanelGauge, 0, 1);
            this.tableLayoutPanel_TeamFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFolders.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_TeamFolders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TeamFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFolders.Name = "tableLayoutPanel_TeamFolders";
            this.tableLayoutPanel_TeamFolders.RowCount = 5;
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel_TeamFolders.Size = new System.Drawing.Size(1070, 669);
            this.tableLayoutPanel_TeamFolders.TabIndex = 1;
            // 
            // tableLayoutPanel_TeamFoldersCommandGroup
            // 
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnCount = 4;
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersAccessToken, 3, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup, 0, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.tableLayoutPanel_TeamFoldersSendEmailGroup, 3, 1);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Controls.Add(this.labelTeamName, 0, 0);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersCommandGroup.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersCommandGroup.Name = "tableLayoutPanel_TeamFoldersCommandGroup";
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowCount = 2;
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.Size = new System.Drawing.Size(1062, 110);
            this.tableLayoutPanel_TeamFoldersCommandGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersAccessToken
            // 
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamHealthAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(589, 2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(471, 42);
            this.tableLayoutPanel_TeamFoldersAccessToken.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 2;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.labelLicenses, 0, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Controls.Add(this.labelProvisioned, 1, 0);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Location = new System.Drawing.Point(4, 51);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Name = "tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup";
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.Size = new System.Drawing.Size(467, 42);
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.TabIndex = 2;
            // 
            // tableLayoutPanel_TeamFoldersSendEmailGroup
            // 
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48608F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89293F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.40685F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.buttonEx_TeamHealthRefresh, 2, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Controls.Add(this.labelRefreshDateTime, 1, 0);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Location = new System.Drawing.Point(591, 51);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Name = "tableLayoutPanel_TeamFoldersSendEmailGroup";
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.Size = new System.Drawing.Size(467, 42);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.TabIndex = 3;
            // 
            // labelRefreshDateTime
            // 
            this.labelRefreshDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRefreshDateTime.AutoSize = true;
            this.labelRefreshDateTime.Location = new System.Drawing.Point(95, 17);
            this.labelRefreshDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshDateTime.Name = "labelRefreshDateTime";
            this.labelRefreshDateTime.Size = new System.Drawing.Size(225, 13);
            this.labelRefreshDateTime.TabIndex = 5;
            this.labelRefreshDateTime.Text = "Last Refresh: (Click Refresh)";
            // 
            // labelTeamName
            // 
            this.labelTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.Location = new System.Drawing.Point(4, 4);
            this.labelTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(467, 37);
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
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tableLayoutPanelGauge.Controls.Add(this.aquaGaugeUsers, 0, 0);
            this.tableLayoutPanelGauge.Controls.Add(this.chartPieDevices, 1, 0);
            this.tableLayoutPanelGauge.Controls.Add(this.tableLayoutPanelStats, 2, 0);
            this.tableLayoutPanelGauge.Location = new System.Drawing.Point(4, 125);
            this.tableLayoutPanelGauge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelGauge.Name = "tableLayoutPanelGauge";
            this.tableLayoutPanelGauge.RowCount = 1;
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanelGauge.Size = new System.Drawing.Size(1062, 424);
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
            this.aquaGaugeUsers.Glossiness = 11.36364F;
            this.aquaGaugeUsers.Location = new System.Drawing.Point(7, 9);
            this.aquaGaugeUsers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.aquaGaugeUsers.MaxValue = 0F;
            this.aquaGaugeUsers.MinValue = 0F;
            this.aquaGaugeUsers.Name = "aquaGaugeUsers";
            this.aquaGaugeUsers.NoOfDivisions = 5;
            this.aquaGaugeUsers.RecommendedValue = 0F;
            this.aquaGaugeUsers.Size = new System.Drawing.Size(312, 312);
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
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartPieDevices.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPieDevices.Legends.Add(legend4);
            this.chartPieDevices.Location = new System.Drawing.Point(329, 4);
            this.chartPieDevices.Name = "chartPieDevices";
            this.chartPieDevices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "pieDevices";
            this.chartPieDevices.Series.Add(series4);
            this.chartPieDevices.Size = new System.Drawing.Size(318, 338);
            this.chartPieDevices.TabIndex = 1;
            this.chartPieDevices.Text = "Devices";
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelStats.ColumnCount = 2;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.45293F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.54707F));
            this.tableLayoutPanelStats.Controls.Add(this.label1, 0, 0);
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
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(654, 4);
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
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(404, 420);
            this.tableLayoutPanelStats.TabIndex = 2;
            this.tableLayoutPanelStats.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Usage";
            // 
            // labelTotalUsage
            // 
            this.labelTotalUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalUsage.AutoSize = true;
            this.labelTotalUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUsage.Location = new System.Drawing.Point(223, 11);
            this.labelTotalUsage.Name = "labelTotalUsage";
            this.labelTotalUsage.Size = new System.Drawing.Size(177, 25);
            this.labelTotalUsage.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shared Usage";
            // 
            // labelSharedUsage
            // 
            this.labelSharedUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSharedUsage.AutoSize = true;
            this.labelSharedUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedUsage.Location = new System.Drawing.Point(223, 57);
            this.labelSharedUsage.Name = "labelSharedUsage";
            this.labelSharedUsage.Size = new System.Drawing.Size(177, 25);
            this.labelSharedUsage.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unshared Usage";
            // 
            // labelUnsharedUsage
            // 
            this.labelUnsharedUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnsharedUsage.AutoSize = true;
            this.labelUnsharedUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnsharedUsage.Location = new System.Drawing.Point(223, 103);
            this.labelUnsharedUsage.Name = "labelUnsharedUsage";
            this.labelUnsharedUsage.Size = new System.Drawing.Size(177, 25);
            this.labelUnsharedUsage.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Shared Folders";
            // 
            // labelSharedFolders
            // 
            this.labelSharedFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSharedFolders.AutoSize = true;
            this.labelSharedFolders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSharedFolders.Location = new System.Drawing.Point(223, 149);
            this.labelSharedFolders.Name = "labelSharedFolders";
            this.labelSharedFolders.Size = new System.Drawing.Size(177, 25);
            this.labelSharedFolders.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Active Shared Folders";
            // 
            // labelActiveShared
            // 
            this.labelActiveShared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActiveShared.AutoSize = true;
            this.labelActiveShared.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveShared.Location = new System.Drawing.Point(223, 195);
            this.labelActiveShared.Name = "labelActiveShared";
            this.labelActiveShared.Size = new System.Drawing.Size(177, 25);
            this.labelActiveShared.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Active Users";
            // 
            // labelActiveUsers
            // 
            this.labelActiveUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActiveUsers.AutoSize = true;
            this.labelActiveUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveUsers.Location = new System.Drawing.Point(223, 241);
            this.labelActiveUsers.Name = "labelActiveUsers";
            this.labelActiveUsers.Size = new System.Drawing.Size(177, 25);
            this.labelActiveUsers.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Adds";
            // 
            // labelAdds
            // 
            this.labelAdds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdds.AutoSize = true;
            this.labelAdds.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdds.Location = new System.Drawing.Point(223, 287);
            this.labelAdds.Name = "labelAdds";
            this.labelAdds.Size = new System.Drawing.Size(177, 25);
            this.labelAdds.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Edits";
            // 
            // labelEdits
            // 
            this.labelEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEdits.AutoSize = true;
            this.labelEdits.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdits.Location = new System.Drawing.Point(223, 333);
            this.labelEdits.Name = "labelEdits";
            this.labelEdits.Size = new System.Drawing.Size(177, 25);
            this.labelEdits.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Deletes";
            // 
            // labelDeletes
            // 
            this.labelDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeletes.AutoSize = true;
            this.labelDeletes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeletes.Location = new System.Drawing.Point(223, 381);
            this.labelDeletes.Name = "labelDeletes";
            this.labelDeletes.Size = new System.Drawing.Size(177, 25);
            this.labelDeletes.TabIndex = 17;
            // 
            // textBox_TeamHealthAccessToken
            // 
            this.textBox_TeamHealthAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TeamHealthAccessToken.FileFilter = null;
            this.textBox_TeamHealthAccessToken.Location = new System.Drawing.Point(139, 5);
            this.textBox_TeamHealthAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TeamHealthAccessToken.Name = "textBox_TeamHealthAccessToken";
            this.textBox_TeamHealthAccessToken.Size = new System.Drawing.Size(328, 22);
            this.textBox_TeamHealthAccessToken.TabIndex = 1;
            this.textBox_TeamHealthAccessToken.Visible = false;
            // 
            // buttonEx_TeamHealthRefresh
            // 
            this.buttonEx_TeamHealthRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            office2010White2.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010White2.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010White2.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White2.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White2.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010White2.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010White2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            office2010White2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White2.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            office2010White2.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White2.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White2.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White2.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010White2.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010White2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White2.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White2.TextColor = System.Drawing.Color.Black;
            this.buttonEx_TeamHealthRefresh.ColorTable = office2010White2;
            this.buttonEx_TeamHealthRefresh.Location = new System.Drawing.Point(328, 5);
            this.buttonEx_TeamHealthRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamHealthRefresh.Name = "buttonEx_TeamHealthRefresh";
            this.buttonEx_TeamHealthRefresh.Size = new System.Drawing.Size(135, 37);
            this.buttonEx_TeamHealthRefresh.TabIndex = 4;
            this.buttonEx_TeamHealthRefresh.Text = "Refresh";
            this.buttonEx_TeamHealthRefresh.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamHealthRefresh.UseVisualStyleBackColor = true;
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
            this.labelProvisioned.Location = new System.Drawing.Point(236, 0);
            this.labelProvisioned.Name = "labelProvisioned";
            this.labelProvisioned.Size = new System.Drawing.Size(0, 32);
            this.labelProvisioned.TabIndex = 1;
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
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(338, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "pieDevices";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(332, 1);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Devices";
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
            // TeamHealthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.tableLayoutPanel_TeamFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamHealthView";
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
            this.tableLayoutPanelGauge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).EndInit();
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.tableLayoutPanelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersCommandGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersAccessToken;
        private TextBoxEx textBox_TeamHealthAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMembersGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TeamFoldersSendEmailGroup;
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