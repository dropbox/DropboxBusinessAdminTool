namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;
    using System.IO;

    public class DataMigrationModel
        : IDataMigrationModel {
        public List<ContentDisplayListViewItemModel> Contents { get; set; }
        public string AccessToken { get; set; }
        public string OutputFileName { get; set; }

        public DataMigrationModel() {
            Initialize();
        }

        public void CleanUp() {
        }

        public void Initialize() {
            // TODO: any necessary initialization here
            Contents = new List<ContentDisplayListViewItemModel>();
            AccessToken = ApplicationResource.DefaultAccessToken;
            OutputFileName = Directory.GetCurrentDirectory();
        }
    }
}