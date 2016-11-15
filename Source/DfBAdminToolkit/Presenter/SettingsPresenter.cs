namespace DfBAdminToolkit.Presenter {

    using Common.Utils;
    using Model;
    using System.Configuration;
    using System.Windows.Forms;
    using View;
    using Common.Extensions;

    public class SettingsPresenter
        : PresenterBase, ISettingsPresenter {

        public SettingsPresenter(ISettingsModel model, ISettingsView view)
            : base(model, view) {
            Initialize();
        }

        protected override void Initialize() {
            ConfigurationManager.RefreshSection("configuration");
            FileUtil.ResetConfigMechanism();
            GetConfigSettings();

            ISettingsView view = base._view as ISettingsView;
            ISettingsModel model = base._model as ISettingsModel;
            PresenterBase.SetViewPropertiesFromModel<ISettingsView, ISettingsModel>(
                ref view, model
            );
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                ISettingsView view = base._view as ISettingsView;
                view.DataChanged += OnDataChanged;
                view.CommandApplySettings += OnCommandApplySettings;
                view.CommandCancelSettings += OnCommandCancelSettings;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                ISettingsView view = base._view as ISettingsView;
                view.DataChanged -= OnDataChanged;
                view.CommandApplySettings -= OnCommandApplySettings;
                view.CommandCancelSettings -= OnCommandCancelSettings;
                IsViewEventsWired = false;
            }
        }

        private void UpdateConfigSettings() {
            ISettingsModel model = base._model as ISettingsModel;

            //update config file with any new settings you changed
            FileUtil.UpdateKey("BaseUrl", model.ApiBaseUrl.Trim());
            FileUtil.UpdateKey("ContentUrl", model.ApiContentBaseUrl.Trim());
            FileUtil.UpdateKey("ApiVersion", model.ApiVersion.Trim());
            FileUtil.UpdateKey("SearchDefaultLimit", model.SearchDefaultLimit.ToString());

            //encrypt tokens first
            string encryptedAccessToken = model.DefaultAccessToken.Trim().Encrypt();
            string encryptedProvisionToken = model.DefaultProvisionToken.Trim().Encrypt();

            FileUtil.UpdateKey("DefaultAccessToken", encryptedAccessToken);
            FileUtil.UpdateKey("DefaultProvisionToken", encryptedProvisionToken);
            FileUtil.UpdateKey("SuppressFilenamesInStatus", model.SuppressFilenamesInStatus.ToString().Trim());
            Configuration config = ConfigurationManager.OpenExeConfiguration(FileUtil.GetAppPath() + "DfBAdminToolkit.exe");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            FileUtil.ResetConfigMechanism();
        }

        private void GetConfigSettings() {
            ISettingsModel model = base._model as ISettingsModel;
            Configuration config = ConfigurationManager.OpenExeConfiguration(FileUtil.GetAppPath() + "DfBAdminToolkit.exe");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            FileUtil.ResetConfigMechanism();

            model.DefaultAccessToken = ApplicationResource.DefaultAccessToken;
            model.DefaultProvisionToken = ApplicationResource.DefaultProvisionToken;
            model.SearchDefaultLimit = ApplicationResource.SearchDefaultLimit;
            model.ApiBaseUrl = ApplicationResource.BaseUrl;
            model.ApiContentBaseUrl = ApplicationResource.ContentUrl;
            model.ApiVersion = ApplicationResource.ApiVersion;
            model.SuppressFilenamesInStatus = ApplicationResource.SuppressFilenamesInStatus;
        }

        public void ShowSettings(IWin32Window owner) {
            ISettingsView view = base._view as ISettingsView;
            IWin32Window parent = owner;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.LoadSettingValues();
                    view.ShowView(parent);
                }, null);
            }
        }

        #region Events

        private void OnCommandApplySettings(object sender, System.EventArgs e) {
            ISettingsModel model = base._model as ISettingsModel;
            ISettingsView view = base._view as ISettingsView;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            PresenterBase.SetModelPropertiesFromView<ISettingsModel, ISettingsView>(
                ref model, view
            );
            UpdateConfigSettings();

            // we will probably don't need to broadcast changes,
            // as previous result becomes no longere meaningful upon update of token or API urls.
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.HideView();
                    presenter.UpdateProgressInfo("Settings Updated");
                    Application.Restart();
                }, null);
            }
        }

        private void OnCommandCancelSettings(object sender, System.EventArgs e) {
            ISettingsView view = base._view as ISettingsView;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.HideView();
                    presenter.UpdateProgressInfo("Settings Update Cancelled");
                }, null);
            }
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            ISettingsView view = base._view as ISettingsView;
            ISettingsModel model = base._model as ISettingsModel;
            PresenterBase.SetModelPropertiesFromView<ISettingsModel, ISettingsView>(
                ref model, view
            );
        }

        #endregion Events
    }
}