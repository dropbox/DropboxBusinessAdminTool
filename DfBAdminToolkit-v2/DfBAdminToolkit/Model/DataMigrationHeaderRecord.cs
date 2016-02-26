using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model {

    public class DataMigrationHeaderRecord {
        public string OwnerName { get; set; }
        public string OwnerLogin { get; set; }
        public string Path { get; set; }
        public string PathId { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public string ItemType { get; set; }
        public string Size { get; set; }
        public string Created { get; set; }
        public string LastModified { get; set; }
        public string Uploaded { get; set; }
    }

    public class DataMigrationHeaderMap : CsvClassMap<DataMigrationHeaderRecord> {

        public DataMigrationHeaderMap() {
            Map(m => m.OwnerName).Name("Owner Name");
            Map(m => m.OwnerLogin).Name("Owner Login");
            Map(m => m.Path).Name("Path");
            Map(m => m.PathId).Name("Path ID");
            Map(m => m.ItemName).Name("Item Name");
            Map(m => m.ItemId).Name("Item ID");
            Map(m => m.ItemType).Name("Item Type");
            Map(m => m.Size).Name("Size");
            Map(m => m.Created).Name("Created");
            Map(m => m.LastModified).Name("Last Modified");
            Map(m => m.Uploaded).Name("Uploaded");
        }
    }
}