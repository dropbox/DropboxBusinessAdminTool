namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IDevicesModel
        : IModel {
        string UserAccessToken { get; set; }

        string Filter { get; set; }

        string FilterType { get; set; }

        string FilterCriteria { get; set; }

        List<DeviceListViewItemModel> DeviceList { get; set; }
    }
}