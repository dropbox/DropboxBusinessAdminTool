namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class DevicesModel
        : IDevicesModel {
        public string UserAccessToken { get; set; }

        public string Filter { get; set; }

        public string FilterType { get; set; }

        public string FilterCriteria { get; set; }

        public string OutputFileName { get; set; }

        public List<DeviceListViewItemModel> DeviceList { get; set; }

        public DevicesModel() {
            UserAccessToken = ApplicationResource.DefaultAccessToken;
            DeviceList = new List<DeviceListViewItemModel>();
        }

        public void Initialize() {
        }

        public void CleanUp() {
        }
    }
}