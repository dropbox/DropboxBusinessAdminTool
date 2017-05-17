namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class PaperModel
       : IPaperModel {

        public string AccessToken { get; set; }

        public string TeamFoldersInputFilePath { get; set; }

        public List<PaperListViewItemModel> Paper { get; set; }

        public PaperModel() {
            Initialize();
        }

        public void Initialize() {
            Paper = new List<PaperListViewItemModel>();
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}