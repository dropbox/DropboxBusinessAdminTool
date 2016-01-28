using System;
using DfBAdminToolkit.Common.Utils;
using System.Configuration;
using System.Windows.Forms;

namespace DfBAdminToolkit.View
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ConfigurationManager.RefreshSection("configuration");
            FileUtil.ResetConfigMechanism();
            GetConfigSettings();
            
            labelStatus.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            UpdateConfigSettings();
            Application.Restart();
        }

        private void UpdateConfigSettings()
        {
            //update config file with any new settings you changed
            FileUtil.UpdateKey("BaseUrl", textBoxBaseUrl.Text.Trim());
            FileUtil.UpdateKey("ContentUrl", textBoxContentUrl.Text.Trim());
            FileUtil.UpdateKey("ApiVersion", textBoxApiVersion.Text.Trim());
            FileUtil.UpdateKey("SearchDefaultLimit", textBoxSearchDefault.Text.Trim());
            FileUtil.UpdateKey("DefaultAccessToken", textBoxDefaultAccess.Text.Trim());
            FileUtil.UpdateKey("DefaultProvisionToken", textBoxDefaultProvision.Text.Trim());

            Configuration config = ConfigurationManager.OpenExeConfiguration(FileUtil.GetAppPath() + "DfBAdminToolkit.exe");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            FileUtil.ResetConfigMechanism();
        }

        private void GetConfigSettings()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(FileUtil.GetAppPath() + "DfBAdminToolkit.exe");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            FileUtil.ResetConfigMechanism();

            textBoxDefaultAccess.Text = ApplicationResource.DefaultAccessToken;
            textBoxDefaultProvision.Text = ApplicationResource.DefaultProvisionToken;
            textBoxSearchDefault.Text = Convert.ToString(ApplicationResource.SearchDefaultLimit);
            textBoxBaseUrl.Text = ApplicationResource.BaseUrl;
            textBoxContentUrl.Text = ApplicationResource.ContentUrl;
            textBoxApiVersion.Text = ApplicationResource.ApiVersion;
        }
    }
}
