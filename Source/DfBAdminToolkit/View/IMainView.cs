namespace DfBAdminToolkit.View
{
    using System;

    public interface IMainView
        : IView
    {
        void EnableLoadingSpinner(bool enable);

        void EnableView(bool enable);

        void UpdateTitleBarTeamStats();

        void UpdateProgressText(string text);

        void ShowErrorMessage(string message, string title);

        void ShowInfoMessage(string message);
    }
}