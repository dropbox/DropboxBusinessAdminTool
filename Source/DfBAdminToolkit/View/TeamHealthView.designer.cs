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
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.textBox_TeamHealthAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.buttonEx_TeamHealthRefresh = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartPieDevices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel_TeamFolders.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersCommandGroup.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersAccessToken.SuspendLayout();
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.SuspendLayout();
            this.tableLayoutPanelGauge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_TeamFolders
            // 
            this.tableLayoutPanel_TeamFolders.ColumnCount = 1;
            this.tableLayoutPanel_TeamFolders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersCommandGroup, 0, 0);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel_TeamFoldersMembersGroup, 0, 2);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanelGauge, 0, 1);
            this.tableLayoutPanel_TeamFolders.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel_TeamFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFolders.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_TeamFolders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TeamFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFolders.Name = "tableLayoutPanel_TeamFolders";
            this.tableLayoutPanel_TeamFolders.RowCount = 5;
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel_TeamFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
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
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_TeamFoldersCommandGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
            this.tableLayoutPanel_TeamFoldersCommandGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
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
            this.tableLayoutPanel_TeamFoldersAccessToken.Controls.Add(this.textBox_TeamHealthAccessToken, 1, 0);
            this.tableLayoutPanel_TeamFoldersAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TeamFoldersAccessToken.Location = new System.Drawing.Point(589, 2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_TeamFoldersAccessToken.Name = "tableLayoutPanel_TeamFoldersAccessToken";
            this.tableLayoutPanel_TeamFoldersAccessToken.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersAccessToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersAccessToken.Size = new System.Drawing.Size(471, 42);
            this.tableLayoutPanel_TeamFoldersAccessToken.TabIndex = 0;
            // 
            // tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup
            // 
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnCount = 3;
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel_TeamFoldersMemberRoleSelectionGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.572347F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55305F));
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
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
            this.labelRefreshDateTime.Location = new System.Drawing.Point(16, 17);
            this.labelRefreshDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshDateTime.Name = "labelRefreshDateTime";
            this.labelRefreshDateTime.Size = new System.Drawing.Size(219, 13);
            this.labelRefreshDateTime.TabIndex = 5;
            this.labelRefreshDateTime.Text = "Last Refresh: Unknown";
            // 
            // labelTeamName
            // 
            this.labelTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tableLayoutPanel_TeamFoldersMembersGroup.Location = new System.Drawing.Point(4, 573);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TeamFoldersMembersGroup.Name = "tableLayoutPanel_TeamFoldersMembersGroup";
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowCount = 1;
            this.tableLayoutPanel_TeamFoldersMembersGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TeamFoldersMembersGroup.Size = new System.Drawing.Size(1062, 67);
            this.tableLayoutPanel_TeamFoldersMembersGroup.TabIndex = 1;
            // 
            // tableLayoutPanelGauge
            // 
            this.tableLayoutPanelGauge.ColumnCount = 2;
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.58084F));
            this.tableLayoutPanelGauge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.41916F));
            this.tableLayoutPanelGauge.Controls.Add(this.aquaGaugeUsers, 0, 0);
            this.tableLayoutPanelGauge.Controls.Add(this.chartPieDevices, 1, 0);
            this.tableLayoutPanelGauge.Location = new System.Drawing.Point(4, 113);
            this.tableLayoutPanelGauge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelGauge.Name = "tableLayoutPanelGauge";
            this.tableLayoutPanelGauge.RowCount = 1;
            this.tableLayoutPanelGauge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGauge.Size = new System.Drawing.Size(835, 429);
            this.tableLayoutPanelGauge.TabIndex = 4;
            // 
            // aquaGaugeUsers
            // 
            this.aquaGaugeUsers.BackColor = System.Drawing.Color.Transparent;
            this.aquaGaugeUsers.DialColor = System.Drawing.Color.RoyalBlue;
            this.aquaGaugeUsers.DialText = "Users";
            this.aquaGaugeUsers.Glossiness = 11.36364F;
            this.aquaGaugeUsers.Location = new System.Drawing.Point(6, 8);
            this.aquaGaugeUsers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.aquaGaugeUsers.MaxValue = 0F;
            this.aquaGaugeUsers.MinValue = 0F;
            this.aquaGaugeUsers.Name = "aquaGaugeUsers";
            this.aquaGaugeUsers.RecommendedValue = 0F;
            this.aquaGaugeUsers.Size = new System.Drawing.Size(401, 401);
            this.aquaGaugeUsers.TabIndex = 0;
            this.aquaGaugeUsers.ThresholdPercent = 90F;
            this.aquaGaugeUsers.Value = 0F;
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
            this.buttonEx_TeamHealthRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEx_TeamHealthRefresh.Location = new System.Drawing.Point(243, 6);
            this.buttonEx_TeamHealthRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx_TeamHealthRefresh.Name = "buttonEx_TeamHealthRefresh";
            this.buttonEx_TeamHealthRefresh.Size = new System.Drawing.Size(220, 37);
            this.buttonEx_TeamHealthRefresh.TabIndex = 4;
            this.buttonEx_TeamHealthRefresh.Text = "Refresh";
            this.buttonEx_TeamHealthRefresh.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TeamHealthRefresh.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 648);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 6);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // chartPieDevices
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPieDevices.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPieDevices.Legends.Add(legend1);
            this.chartPieDevices.Location = new System.Drawing.Point(416, 3);
            this.chartPieDevices.Name = "chartPieDevices";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "pieDevices";
            this.chartPieDevices.Series.Add(series1);
            this.chartPieDevices.Size = new System.Drawing.Size(372, 300);
            this.chartPieDevices.TabIndex = 1;
            this.chartPieDevices.Text = "Devices";
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
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.ResumeLayout(false);
            this.tableLayoutPanel_TeamFoldersSendEmailGroup.PerformLayout();
            this.tableLayoutPanelGauge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPieDevices)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}