namespace DfBAdminToolkit.Model {
    public interface ISettingsModel
        : IModel {
        string DefaultAccessToken { get; set; }
        string DefaultProvisionToken { get; set; }
        int SearchDefaultLimit { get; set; }
        string ApiBaseUrl { get; set; }
        string ApiContentBaseUrl { get; set; }
        string ApiVersion { get; set; }
    }
}