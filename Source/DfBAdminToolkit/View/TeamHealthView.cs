namespace DfBAdminToolkit.View
{
    using Model;
    using DfBAdminToolkit.Common.Utils;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class TeamHealthView : Form, ITeamHealthView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandRefresh;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public TeamHealthView()
        {
            InitializeComponent();
            Initialize();
            InitRoleTooltips();
            WireComponentEvents();
        }

        ~TeamHealthView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.buttonEx_TeamHealthRefresh.Click += buttonEx_TeamHealthRefresh_Click;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.buttonEx_TeamHealthRefresh.Click -= buttonEx_TeamHealthRefresh_Click;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            this.buttonEx_TeamHealthRefresh.Enabled = true;
            this.aquaGaugeUsers.Visible = false;
        }

        private void InitRoleTooltips()
        {
            //create tooltips for the health stat items
            ToolTip ttTotalUsage = new ToolTip();
            ToolTip ttSharedUsage = new ToolTip();
            ToolTip ttUnsharedUsage = new ToolTip();
            ToolTip ttSharedFolders = new ToolTip();
            ToolTip ttActiveSharedFolders = new ToolTip();
            ToolTip ttActiveUsers = new ToolTip();
            ToolTip ttAdds = new ToolTip();
            ToolTip ttEdits = new ToolTip();
            ToolTip ttDeletes = new ToolTip();
            ToolTip ttActiveDevices = new ToolTip();
            ToolTip ttUsers = new ToolTip();
            ttTotalUsage.SetToolTip(this.labelTotalUsage, Tooltips.TOTAL_USAGE);
            ttSharedUsage.SetToolTip(this.labelSharedUsage, Tooltips.SHARED_USAGE);
            ttUnsharedUsage.SetToolTip(this.labelUnsharedUsage, Tooltips.UNSHARED_USAGE);
            ttSharedFolders.SetToolTip(this.labelSharedFolders, Tooltips.SHARED_FOLDERS);
            ttActiveUsers.SetToolTip(this.labelActiveUsers, Tooltips.ACTIVE_USERS);
            ttActiveSharedFolders.SetToolTip(this.labelActiveShared, Tooltips.ACTIVE_SHARED_FOLDERS);
            ttAdds.SetToolTip(this.labelAdds, Tooltips.FILE_ADDS);
            ttEdits.SetToolTip(this.labelEdits, Tooltips.FILE_EDITS);
            ttDeletes.SetToolTip(this.labelDeletes, Tooltips.FILE_DELETES);
            ttActiveDevices.SetToolTip(this.chartPieDevices, Tooltips.ACTIVE_DEVICES);
            ttUsers.SetToolTip(this.aquaGaugeUsers, Tooltips.USERS);
        }

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        #region Slots

        public void RefreshAccessToken()
        {
            textBox_TeamHealthAccessToken.Text = AccessToken;
        }

        public void LoadViewHealthItems(ITeamHealthModel model)
        {
            //populate view controls for everything in model
            labelRefreshDateTime.Text = "Last Refresh: " + model.RefreshDateTime.ToString();
            labelTeamName.Text = "Team: " + model.TeamName;
            labelLicenses.Text = "Total Licenses: " + model.LicensedUsers;
            labelProvisioned.Text = "Total Provisioned: " + model.ProvisionedUsers;
            tableLayoutPanelStats.Visible = true;
            
            //load users gauge with data
            this.aquaGaugeUsers.Visible = true;
            aquaGaugeUsers.MinValue = 0;
            aquaGaugeUsers.MaxValue = (float)Convert.ToDouble(model.LicensedUsers);
            aquaGaugeUsers.Value = (float)Convert.ToDouble(model.ProvisionedUsers);
            
            //load 3D pie chart with Active Devices info
            chartPieDevices.Series.Clear();
            chartPieDevices.Palette = ChartColorPalette.Bright;
            chartPieDevices.BackColor = Color.Transparent;
            chartPieDevices.Titles.Clear();
            chartPieDevices.Titles.Add("Active Devices In Past Week: " + model.total);
            chartPieDevices.ChartAreas[0].BackColor = Color.Transparent;
            chartPieDevices.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartPieDevices.ChartAreas[0].Area3DStyle.WallWidth = 0;
            Series seriesDevices = new Series
            {
                Name = "Devices",
                IsVisibleInLegend = true,
                Color = Color.Green,
                Font = new Font(Font.Name, 7, FontStyle.Regular),
                ChartType = SeriesChartType.Pie
            };
            chartPieDevices.Series.Add(seriesDevices);
            //pie chart model values here
            seriesDevices.Points.Add(Convert.ToDouble(model.windows));
            seriesDevices.Points.Add(Convert.ToDouble(model.macos));
            seriesDevices.Points.Add(Convert.ToDouble(model.linux));
            seriesDevices.Points.Add(Convert.ToDouble(model.ios));
            seriesDevices.Points.Add(Convert.ToDouble(model.android));
            seriesDevices.Points.Add(Convert.ToDouble(model.other));
            
            var p1 = seriesDevices.Points[0];
            if (model.windows != "0")
            {
                p1.AxisLabel = model.windows + "%";
            }  
            p1.LegendText = "Windows OS";

            var p2 = seriesDevices.Points[1];
            if (model.macos != "0")
            {
                p2.AxisLabel = model.macos + "%";
            } 
            p2.LegendText = "Mac OS";

            var p3 = seriesDevices.Points[2];
            if (model.linux != "0")
            {
                p3.AxisLabel = model.linux + "%";
            }  
            p3.LegendText = "Linux";

            var p4 = seriesDevices.Points[3]; 
            if (model.ios != "0")
            {
                p4.AxisLabel = model.ios + "%";
            }
            p4.LegendText = "iOS";

            var p5 = seriesDevices.Points[4];
            if (model.android != "0")
            {
                p5.AxisLabel = model.android + "%";
            } 
            p5.LegendText = "Android";

            var p6 = seriesDevices.Points[5];
            if (model.other != "0")
            {
                p6.AxisLabel = model.other + "%";
            } 
            p6.LegendText = "Other";

            chartPieDevices.Invalidate();

            //Misc stats
            labelActiveShared.Text = model.ActiveSharedFolders7Day;
            labelActiveUsers.Text = model.ActiveUsers7Day;
            labelAdds.Text = model.Adds;
            labelDeletes.Text = model.Deletes;
            labelEdits.Text = model.Edits;
            labelSharedFolders.Text = model.SharedFolders;
            labelSharedUsage.Text = model.SharedUsage;
            labelTotalUsage.Text = model.TotalUsage;
            labelUnsharedUsage.Text = model.UnsharedUsage;
        }

        #endregion Slots

        #region Events

        private void buttonEx_TeamHealthRefresh_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandRefresh != null)
            {
                CommandRefresh(sender, e);
            }
        }

        private void TextBox_TeamFoldersAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_TeamHealthAccessToken.Text;
        }

        private void InvokeDataChanged(object sender, EventArgs e)
        {
            if (DataChanged != null)
            {
                DataChanged(sender, e);
            }
        }

        #endregion Events

    }
}