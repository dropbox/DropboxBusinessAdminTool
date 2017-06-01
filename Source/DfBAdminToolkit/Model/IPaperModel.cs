namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IPaperModel
        : IModel {

        string AccessToken { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        List<PaperListViewItemModel> Paper { get; set; }
    }
}