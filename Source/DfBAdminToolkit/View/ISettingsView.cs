namespace DfBAdminToolkit.View {

    using System;
    using System.Windows.Forms;

    public interface ISettingsView
        : IView {
        event EventHandler CommandApplySettings;
        event EventHandler CommandCancelSettings;

        string DefaultAccessToken { get; set; }
        string DefaultProvisionToken { get; set; }
        int SearchDefaultLimit { get; set; }
        string ApiBaseUrl { get; set; }
        string ApiContentBaseUrl { get; set; }
        string ApiVersion { get; set; }
        bool SuppressFilenamesInStatus { get; set; }

        void LoadSettingValues();
        void ShowView(IWin32Window owner);
    }
}