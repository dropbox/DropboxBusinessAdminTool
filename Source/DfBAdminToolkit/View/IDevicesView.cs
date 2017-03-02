namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.DataExchange;
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface IDevicesView
        : IView
    {
        event EventHandler CommandGetDevices;
        event EventHandler CommandDumpDevices;
        event EventHandler CommandExportDevices;

        string UserAccessToken { get; set; }

        string Filter { get; set; }

        string FilterType { get; set; }

        string FilterCriteria { get; set; }

        string OutputFileName { get; set; }

        List<DeviceListViewItemModel> DeviceList { get; set; }

        void RefreshAccessToken();

        void RenderDeviceSearchResult();

        void EnableDeviceControl(bool enable);

        void EnableDeviceButton(bool enable);

        void EnableExportButton(bool enable);

        void ShowGroups(bool show);
    }
}