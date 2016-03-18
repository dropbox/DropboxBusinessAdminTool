namespace DfBAdminToolkit.Presenter {
    public interface IDumpUserContentPresenter
        : IPresenter {
        string[] ContextMenuItemText { get; set; }

        void UpdateSettings();
    }
}