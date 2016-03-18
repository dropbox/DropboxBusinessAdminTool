namespace DfBAdminToolkit.View {

    using DfBAdminToolkit.Common.Component;
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class SettingsView
        : FormEx, ISettingsView {
        public SynchronizationContext SyncContext { get; set; }
        public bool ComponentEventsWired { get; set; }

        public event EventHandler DataChanged;
        public event EventHandler CommandApplySettings;
        public event EventHandler CommandCancelSettings;

        public string DefaultAccessToken { get; set; }
        public string DefaultProvisionToken { get; set; }
        public int SearchDefaultLimit { get; set; }
        public string ApiBaseUrl { get; set; }
        public string ApiContentBaseUrl { get; set; }
        public string ApiVersion { get; set; }

        public SettingsView()
            : base(FormExStyle.CENTERED_WINDOW) {
            InitializeComponent();
            Initialize();
            WireComponentEvents();
            labelStatus.Text = "";
        }

        ~SettingsView() {
            UnWireComponentEvents();
        }

        public void Initialize() {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
        }

        public void WireComponentEvents() {
            if (!ComponentEventsWired) {
                buttonEx_SettingsSave.Click += ButtonEx_SettingsSave_Click;
                buttonEx_SettingsCancel.Click += ButtonEx_SettingsCancel_Click;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents() {
            if (ComponentEventsWired) {
                buttonEx_SettingsSave.Click -= ButtonEx_SettingsSave_Click;
                buttonEx_SettingsCancel.Click -= ButtonEx_SettingsCancel_Click;
                ComponentEventsWired = false;
            }
        }

        public void ShowView() {
            this.ShowDialog();
        }

        public void ShowView(IWin32Window owner) {
            this.ShowDialog(owner);
        }

        public void HideView() {
            this.Hide();
        }

        #region Slots

        public void LoadSettingValues() {
            this.textBoxApiVersion.Text = this.ApiVersion;
            this.textBoxBaseUrl.Text = this.ApiBaseUrl;
            this.textBoxContentUrl.Text = this.ApiContentBaseUrl;
            this.numericUpDown_SettingSearchLimit.Value = this.SearchDefaultLimit;
            this.textBoxDefaultAccess.Text = this.DefaultAccessToken;
            this.textBoxDefaultProvision.Text = this.DefaultProvisionToken;
        }

        public void UpdateSettingValues() {
            this.ApiVersion = this.textBoxApiVersion.Text;
            this.ApiBaseUrl = this.textBoxBaseUrl.Text;
            this.ApiContentBaseUrl = this.textBoxContentUrl.Text;
            this.SearchDefaultLimit = Convert.ToInt32(this.numericUpDown_SettingSearchLimit.Value);
            this.DefaultAccessToken = this.textBoxDefaultAccess.Text;
            this.DefaultProvisionToken = this.textBoxDefaultProvision.Text;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.textBoxDefaultAccess.Focus();
        }

        #endregion Slots

        #region Events

        private void ButtonEx_SettingsSave_Click(object sender, EventArgs e) {
            if (CommandApplySettings != null) {
                UpdateSettingValues();
                CommandApplySettings(this, e);
            }
        }

        private void ButtonEx_SettingsCancel_Click(object sender, EventArgs e) {
            if(CommandCancelSettings != null) {
                CommandCancelSettings(this, e);
            }
        }

        #endregion Events
    }
}