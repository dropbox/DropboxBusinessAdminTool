namespace DfBAdminToolkit.Model {

    public class SettingsModel
        : ISettingsModel {

        public SettingsModel() {
            Initialize();
        }

        public string DefaultAccessToken { get; set; }
        public string DefaultProvisionToken { get; set; }
        public int SearchDefaultLimit { get; set; }
        public string ApiBaseUrl { get; set; }
        public string ApiContentBaseUrl { get; set; }
        public string ApiVersion { get; set; }

        public void Initialize() {
            DefaultAccessToken = ApplicationResource.DefaultAccessToken;
            DefaultProvisionToken = ApplicationResource.DefaultProvisionToken;
            SearchDefaultLimit = ApplicationResource.SearchDefaultLimit;
            ApiBaseUrl = ApplicationResource.BaseUrl;
            ApiContentBaseUrl = ApplicationResource.ContentUrl;
            ApiVersion = ApplicationResource.ApiVersion;
        }

        public void CleanUp() {
        }
    }
}