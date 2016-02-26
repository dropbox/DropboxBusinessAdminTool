namespace DfBAdminToolkit.Presenter {

    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;

    public class MainPresenter
         : PresenterBase, IMainPresenter {

        public MainPresenter()
            : this(new MainModel(), new MainView()) {
        }

        public MainPresenter(IMainModel model, IMainView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            // TODO:
            // any main view related components will be synced from
            // model here
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                // TODO:
                // wire up main view events
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                // TODO:
                // unwire main view events
            }
        }

        protected override void CleanUp() {
        }

        #region Signals

        public void ShowView() {
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    base._view.ShowView();
                }, null);
            }
        }

        public void ActivateSpinner(bool activate) {
            IMainView view = base._view as IMainView;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.EnableLoadingSpinner(activate);
                }, null);
            }
        }

        public void EnableControl(bool enable) {
            IMainView view = base._view as IMainView;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.EnableView(enable);
                }, null);
            }
        }

        public void UpdateProgressInfo(string text) {
            IMainView view = base._view as IMainView;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.UpdateProgressText(text);
                }, null);
            }
        }

        public void ShowErrorMessage(string text, string title) {
            IMainView view = base._view as IMainView;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.ShowErrorMessage(text, title);
                }, null);
            }
        }

        public void ShowInfoMessage(string text) {
            IMainView view = base._view as IMainView;
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.ShowInfoMessage(text);
                }, null);
            }
        }

        #endregion Signals
    }
}