namespace DfBAdminToolkit.View
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class LegalView
        : Form, ILegalView
    {
        public event EventHandler CommandDecline;
        public event EventHandler CommandAccept;
        public event EventHandler DataChanged;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public LegalView()
        {
            InitializeComponent();
            Initialize();
            WireComponentEvents();
        }

        ~LegalView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                buttonEx_LegalDecline.Click += BtnDecline_Click;
                buttonEx_LegalAccept.Click += BtnAccept_Click;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                buttonEx_LegalDecline.Click -= BtnDecline_Click;
                buttonEx_LegalAccept.Click -= BtnAccept_Click;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
        }

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        #region Events

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            if (CommandDecline != null)
            {
                CommandDecline(sender, e);
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (CommandAccept != null)
            {
                CommandAccept(sender, e);
            }
        }

        #endregion Events
    }
}