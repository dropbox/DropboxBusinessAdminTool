namespace DfBAdminToolkit.Presenter {
    public interface IDevicesPresenter
        : IPresenter {
        string[] ContextMenuItemText { get; set; }

        void UpdateSettings();
    }
}