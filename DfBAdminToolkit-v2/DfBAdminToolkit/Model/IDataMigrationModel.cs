namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IDataMigrationModel
        : IModel {
        List<ContentDisplayListViewItemModel> Contents { get; set; }
        string AccessToken { get; set; }
        string OutputFileName { get; set; }
    }
}