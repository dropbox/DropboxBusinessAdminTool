namespace DfBAdminToolkit.Presenter
{
    public interface IMainPresenter
        : IPresenter
    {
        void ShowView();

        void ActivateSpinner(bool activate);

        void EnableControl(bool enable);

        void UpdateProgressInfo(string text);

        void ShowErrorMessage(string text, string title);

        void ShowInfoMessage(string text);
    }
}