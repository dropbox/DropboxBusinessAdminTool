namespace DfBAdminToolkit.Presenter {

    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using Microsoft.Win32;
    using System.Windows.Forms;

    public class LegalPresenter
        : PresenterBase, ILegalPresenter {

        public LegalPresenter(ILegalModel model, ILegalView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            // read data from model
            ILegalView view = base._view as ILegalView;
            ILegalModel model = base._model as ILegalModel;
            PresenterBase.SetViewPropertiesFromModel<ILegalView, ILegalModel>(
                ref view, model
            );
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                ILegalView view = base._view as ILegalView;
                view.DataChanged += OnDataChanged;
                view.CommandAccept += OnCommandAccept;
                view.CommandDecline += OnCommandDecline;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                ILegalView view = base._view as ILegalView;
                view.DataChanged -= OnDataChanged;
                view.CommandAccept -= OnCommandAccept;
                view.CommandDecline -= OnCommandDecline;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        #region Events

        private void OnDataChanged(object sender, System.EventArgs e) {
            ILegalView view = base._view as ILegalView;
            ILegalModel model = base._model as ILegalModel;
            PresenterBase.SetModelPropertiesFromView<ILegalModel, ILegalView>(
                ref model, view
            );
        }

        private void OnCommandDecline(object sender, System.EventArgs e) {
            Application.Exit();
        }

        private void OnCommandAccept(object sender, System.EventArgs e) {
            RegistryKey key = RegistryUtils.CreateKey(ApplicationResource.RegistryEntryPoint);
            RegistryUtils.SetKeyValue(key, ApplicationResource.RegistryKey, bool.TrueString);

            IView view = base._view;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    // hide legal view
                    view.HideView();

                    // show main view
                    IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>(
                        new object[] {
                            new MainModel(), new MainView()
                        });
                    presenter.ShowView();
                }, null);
            }
            //now encrypt AppSettings to not make tokens visible (all appSettings encrypted)
            FileUtil.EncryptAppSettings("appSettings");
        }

        #endregion Events
    }
}