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

        #endregion Slots

        #region Events

        private void buttonEx_TeamHealthRefresh_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            //if (CommandGetTeamFolders != null)
            //{
            //    CommandGetTeamFolders(sender, e);
            //}
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