using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{
    public class DevicesHeaderRecord
    {
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Email { get; set; }
        public string TeamId { get; set; }
        public string DeviceName { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
        public string ClientType { get; set; }
    }

    public class DevicesHeaderMap : CsvClassMap<DevicesHeaderRecord>
    {
        public DevicesHeaderMap()
        {
            Map(m => m.Created).Name("Created");
            Map(m => m.Updated).Name("Updated");
            Map(m => m.Email).Name("Email");
            Map(m => m.TeamId).Name("TeamId");
            Map(m => m.DeviceName).Name("DeviceName");
            Map(m => m.IpAddress).Name("Item Name");
            Map(m => m.SessionId).Name("SessionId");
            Map(m => m.ClientType).Name("ClientType");
        }
    }
}
