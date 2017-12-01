namespace DfBAdminToolkit.Presenter
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using Common.Services;
    using Common.Utils;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;
    using System.Collections.Generic;

    public class DevicesPresenter
        : PresenterBase, IDevicesPresenter {
        public string[] ContextMenuItemText { get; set; }

        public DevicesPresenter(IDevicesModel model, IDevicesView view)
            : base(model, view)
        {
        }

        protected override void Initialize()
        {
            // read data from model
            IDevicesView view = base._view as IDevicesView;
            IDevicesModel model = base._model as IDevicesModel;
            PresenterBase.SetViewPropertiesFromModel<IDevicesView, IDevicesModel>(
                ref view, model
            );
            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents()
        {
            if (!IsViewEventsWired)
            {
                IDevicesView view = base._view as IDevicesView;
                view.DataChanged += OnDataChanged;
                view.CommandGetDevices += OnCommandGetDevices;
                view.CommandDumpDevices += OnCommandDumpDevices;
                view.CommandExportDevices += OnCommandExportDevices;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents()
        {
            if (IsViewEventsWired)
            {
                IDevicesView view = base._view as IDevicesView;
                view.DataChanged -= OnDataChanged;
                view.CommandGetDevices -= OnCommandGetDevices;
                view.CommandDumpDevices -= OnCommandDumpDevices;
                view.CommandExportDevices -= OnCommandExportDevices;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp()
        {
        }

        public void UpdateSettings()
        {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Services

        private void DumpDevices(IDevicesModel model, IDevicesView view, IMainPresenter presenter) {
            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.UpdateProgressInfo("Preparing Device Removal...");
                }, null);
            }
            bool remoteWipe = view.RemoteWipe;
            int counter = 0;
            int total = model.DeviceList.Where(d => d.IsChecked && !string.IsNullOrEmpty(d.SessionId)).ToList().Count;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.DumpDevicesUrl = ApplicationResource.ActionDumpDevices;
            service.UserAgentVersion = ApplicationResource.UserAgent;

            foreach (DeviceListViewItemModel lvItem in model.DeviceList)
            {
                if (lvItem.IsChecked && !string.IsNullOrEmpty(lvItem.SessionId)) {
                    // notify progress
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            presenter.UpdateProgressInfo(string.Format("Removing device: {0}/{1}", ++counter, total));
                        }, null);
                    }

                    service.DumpDevices(
                        new MemberData() {
                            SessionId = lvItem.SessionId,
                            MemberId = lvItem.TeamId,
                            ClientType = lvItem.ClientType
                        },
                        model.UserAccessToken, remoteWipe
                    );
                }
            }
        }

        private void GetDevices(IDevicesModel model, IMainPresenter presenter)
        {
            if (!string.IsNullOrEmpty(model.UserAccessToken))
            {
                IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.GetDevicesUrl = ApplicationResource.ActionListTeamDevices;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                List<string[]> members = new List<string[]>();

                //BEGIN GET MEMBERS
                MemberServices serviceMembers = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                serviceMembers.ListMembersUrl = ApplicationResource.ActionListMembers;
                IDataResponse responseMembers = serviceMembers.ListMembers(new MemberData()
                {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, ApplicationResource.DefaultAccessToken);

                if (responseMembers.StatusCode == HttpStatusCode.OK)
                {
                    if (responseMembers.Data != null)
                    {
                        string data = responseMembers.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic idObj = jsonData["members"][i]["profile"]["team_member_id"];
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            string teamId = idObj.Value as string;
                            string email = emailObj.Value as string;

                            string[] str = new string[2];
                            str[0] = teamId;
                            str[1] = email;
                            members.Add(str);
                        }
                        //if the memberID count is above limit - grab the cursor and call continue
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            serviceMembers.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            IDataResponse responseMembersCont = serviceMembers.ListMembersContinuation(new MemberData()
                            {
                                Cursor = cursor
                            }, ApplicationResource.DefaultAccessToken);

                            string dataCont = responseMembersCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic idObj = jsonDataCont["members"][i]["profile"]["team_member_id"];
                                dynamic emailObj = jsonDataCont["members"][i]["profile"]["email"];
                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;

                                string[] str = new string[2];
                                str[0] = teamId;
                                str[1] = email;
                                members.Add(str);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
                //END GET MEMBERS
                bool FilterCriteriaContains = false;
                bool FilterCriteriaNotContains = false;
                bool FilterCriteriaBeginsWith = false;
                bool FilterCriteriaEndsWith = false;
                if (model.FilterCriteria == "CONTAINS") {
                    FilterCriteriaContains = true;
                }
                if (model.FilterCriteria == "NOT CONTAINS") {
                    FilterCriteriaNotContains = true;
                }
                if (model.FilterCriteria == "BEGINS WITH") {
                    FilterCriteriaBeginsWith = true;
                }
                if (model.FilterCriteria == "ENDS WITH") {
                    FilterCriteriaEndsWith = true;
                }
                IDataResponse response = service.FindDevices(new MemberData()
                {
                    //no cursor needed on first hit
                }, model.UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK) {
                    if (response.Data != null) {
                        string data = response.Data.ToString();
                        dynamic jsonDevicesData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.DeviceList.Clear();
                        
                        //user count
                        int resultCount = jsonDevicesData["devices"].Count;
                        if (resultCount > 0)
                        {
                            for (int i = 0; i < resultCount; i++)
                            {
                                DateTime created = new DateTime();
                                DateTime updated = new DateTime();
                                string teamId = string.Empty;
                                string deviceName = string.Empty;
                                string ipAddress = string.Empty;
                                string sessionId = string.Empty;
                                string clientType = string.Empty;
                                string email = string.Empty;

                                dynamic idObj = jsonDevicesData["devices"][i]["team_member_id"];
                                int resultWebCount = jsonDevicesData["devices"][i]["web_sessions"].Count;
                                int resultDesktopCount = jsonDevicesData["devices"][i]["desktop_clients"].Count;
                                int resultMobileCount = jsonDevicesData["devices"][i]["mobile_clients"].Count;

                                if (resultWebCount > 0)
                                {
                                    for (int i2 = 0; i2 < resultWebCount; i2++)
                                    {
                                        dynamic deviceNameObj = jsonDevicesData["devices"][i]["web_sessions"][i2]["user_agent"];
                                        dynamic ipAddressObj = jsonDevicesData["devices"][i]["web_sessions"][i2]["ip_address"];
                                        dynamic sessionIdObj = jsonDevicesData["devices"][i]["web_sessions"][i2]["session_id"];
                                        clientType = "Web";
                                        dynamic createdObj = jsonDevicesData["devices"][i]["web_sessions"][i2]["created"];
                                        dynamic updatedObj = jsonDevicesData["devices"][i]["web_sessions"][i2]["updated"];
                                        if (idObj != null)
                                        {
                                            teamId = idObj.Value as string;
                                        }
                                        if (deviceNameObj != null)
                                        {
                                            deviceName = deviceNameObj.Value as string;
                                        }
                                        if (ipAddressObj != null)
                                        {
                                            ipAddress = ipAddressObj.Value as string;
                                        }
                                        if (sessionIdObj != null)
                                        {
                                            sessionId = sessionIdObj.Value as string;
                                        }
                                        if (createdObj != null)
                                        {
                                            created = jsonDevicesData["devices"][i]["web_sessions"][i2]["created"];
                                        }
                                        if (updatedObj != null)
                                        {
                                            updated = jsonDevicesData["devices"][i]["web_sessions"][i2]["updated"];
                                        }
                                        foreach (string[] lvitem in members)
                                        {
                                            if (teamId == lvitem[0])
                                            {
                                                email = lvitem[1];
                                            }
                                        }
                                        // update model
                                        DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                        {
                                            Created = created,
                                            Updated = updated,
                                            TeamId = teamId,
                                            DeviceName = deviceName,
                                            IpAddress = ipAddress,
                                            SessionId = sessionId,
                                            ClientType = clientType,
                                            Email = email
                                        };
                                        if (string.IsNullOrEmpty(model.Filter))
                                        {
                                            model.DeviceList.Add(lvItem);
                                        }
                                        if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter)))) {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                    }      
                                }
                                if (resultDesktopCount > 0)
                                {
                                    for (int i3 = 0; i3 < resultDesktopCount; i3++)
                                    {
                                        dynamic deviceNameObj = jsonDevicesData["devices"][i]["desktop_clients"][i3]["host_name"];
                                        dynamic ipAddressObj = jsonDevicesData["devices"][i]["desktop_clients"][i3]["ip_address"];
                                        dynamic sessionIdObj = jsonDevicesData["devices"][i]["desktop_clients"][i3]["session_id"];
                                        clientType = "Desktop";
                                        dynamic createdObj = jsonDevicesData["devices"][i]["desktop_clients"][i3]["created"];
                                        dynamic updatedObj = jsonDevicesData["devices"][i]["desktop_clients"][i3]["updated"];
                                        if (idObj != null)
                                        {
                                            teamId = idObj.Value as string;
                                        }
                                        if (deviceNameObj != null)
                                        {
                                            deviceName = deviceNameObj.Value as string;
                                        }
                                        if (ipAddressObj != null)
                                        {
                                            ipAddress = ipAddressObj.Value as string;
                                        }
                                        if (sessionIdObj != null)
                                        {
                                            sessionId = sessionIdObj.Value as string;
                                        }
                                        if (createdObj != null)
                                        {
                                            created = jsonDevicesData["devices"][i]["desktop_clients"][i3]["created"];
                                        }
                                        if (updatedObj != null)
                                        {
                                            updated = jsonDevicesData["devices"][i]["desktop_clients"][i3]["updated"];
                                        }
                                        foreach (string[] lvitem in members)
                                        {
                                            if (teamId == lvitem[0])
                                            {
                                                email = lvitem[1];
                                            }
                                        }
                                        // update model
                                        DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                        {
                                            Created = created,
                                            Updated = updated,
                                            TeamId = teamId,
                                            DeviceName = deviceName,
                                            IpAddress = ipAddress,
                                            SessionId = sessionId,
                                            ClientType = clientType,
                                            Email = email
                                        };
                                        if (string.IsNullOrEmpty(model.Filter))
                                        {
                                            model.DeviceList.Add(lvItem);
                                        }
                                        if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter))))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                    }
                                }
                                if (resultMobileCount > 0)
                                {
                                    for (int i4 = 0; i4 < resultMobileCount; i4++)
                                    {
                                        dynamic deviceNameObj = jsonDevicesData["devices"][i]["mobile_clients"][i4]["device_name"];
                                        dynamic ipAddressObj = jsonDevicesData["devices"][i]["mobile_clients"][i4]["ip_address"];
                                        dynamic sessionIdObj = jsonDevicesData["devices"][i]["mobile_clients"][i4]["session_id"];
                                        clientType = "Mobile";
                                        dynamic createdObj = jsonDevicesData["devices"][i]["mobile_clients"][i4]["created"];
                                        dynamic updatedObj = jsonDevicesData["devices"][i]["mobile_clients"][i4]["updated"];
                                        if (idObj != null)
                                        {
                                            teamId = idObj.Value as string;
                                        }
                                        if (deviceNameObj != null)
                                        {
                                            deviceName = deviceNameObj.Value as string;
                                        }
                                        if (ipAddressObj != null)
                                        {
                                            ipAddress = ipAddressObj.Value as string;
                                        }
                                        if (sessionIdObj != null)
                                        {
                                            sessionId = sessionIdObj.Value as string;
                                        }
                                        if (createdObj != null)
                                        {
                                            created = jsonDevicesData["devices"][i]["mobile_clients"][i4]["created"];
                                        }
                                        if (updatedObj != null)
                                        {
                                            updated = jsonDevicesData["devices"][i]["mobile_clients"][i4]["updated"];
                                        }
                                        foreach (string[] lvitem in members)
                                        {
                                            if (teamId == lvitem[0])
                                            {
                                                email = lvitem[1];
                                            }
                                        }
                                        // update model
                                        DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                        {
                                            Created = created,
                                            Updated = updated,
                                            TeamId = teamId,
                                            DeviceName = deviceName,
                                            IpAddress = ipAddress,
                                            SessionId = sessionId,
                                            ClientType = clientType,
                                            Email = email
                                        };
                                        if (string.IsNullOrEmpty(model.Filter))
                                        {
                                            model.DeviceList.Add(lvItem);
                                        }
                                        if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                            {
                                                //do nothing, don't add to list
                                            }
                                            if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter))))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                        if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                        {
                                            if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                            if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                            {
                                                model.DeviceList.Add(lvItem);
                                            }
                                        }
                                    }
                                }
                            }
                            //if the device count has more, we need to pull next batch from cursor value
                            bool hasMore = jsonDevicesData["has_more"];
                            string cursor = jsonDevicesData["cursor"];

                            while (hasMore)
                            {
                                service.GetDevicesUrl = ApplicationResource.ActionListTeamDevices;
                                IDataResponse responseCont = service.FindDevices(new MemberData()
                                {
                                    Cursor = cursor
                                }, model.UserAccessToken);

                                string dataCont = responseCont.Data.ToString();
                                dynamic jsonDevicesDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                                int resultCountCont = jsonDevicesDataCont["devices"].Count;
                                if (resultCountCont > 0)
                                {
                                    for (int i = 0; i < resultCountCont; i++)
                                    {
                                        DateTime created = new DateTime();
                                        DateTime updated = new DateTime();
                                        string teamId = string.Empty;
                                        string deviceName = string.Empty;
                                        string ipAddress = string.Empty;
                                        string sessionId = string.Empty;
                                        string clientType = string.Empty;
                                        string email = string.Empty;

                                        dynamic idObj = jsonDevicesDataCont["devices"][i]["team_member_id"];
                                        int resultWebCount = jsonDevicesDataCont["devices"][i]["web_sessions"].Count;
                                        int resultDesktopCount = jsonDevicesDataCont["devices"][i]["desktop_clients"].Count;
                                        int resultMobileCount = jsonDevicesDataCont["devices"][i]["mobile_clients"].Count;

                                        if (resultWebCount > 0)
                                        {
                                            for (int i2 = 0; i2 < resultWebCount; i2++)
                                            {
                                                dynamic deviceNameObj = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["user_agent"];
                                                dynamic ipAddressObj = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["ip_address"];
                                                dynamic sessionIdObj = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["session_id"];
                                                clientType = "Web";
                                                dynamic createdObj = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["created"];
                                                dynamic updatedObj = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["updated"];
                                                if (idObj != null)
                                                {
                                                    teamId = idObj.Value as string;
                                                }
                                                if (deviceNameObj != null)
                                                {
                                                    deviceName = deviceNameObj.Value as string;
                                                }
                                                if (ipAddressObj != null)
                                                {
                                                    ipAddress = ipAddressObj.Value as string;
                                                }
                                                if (sessionIdObj != null)
                                                {
                                                    sessionId = sessionIdObj.Value as string;
                                                }
                                                if (createdObj != null)
                                                {
                                                    created = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["created"];
                                                }
                                                if (updatedObj != null)
                                                {
                                                    updated = jsonDevicesDataCont["devices"][i]["web_sessions"][i2]["updated"];
                                                }
                                                foreach (string[] lvitem in members)
                                                {
                                                    if (teamId == lvitem[0])
                                                    {
                                                        email = lvitem[1];
                                                    }
                                                }
                                                // update model
                                                DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                                {
                                                    Created = created,
                                                    Updated = updated,
                                                    TeamId = teamId,
                                                    DeviceName = deviceName,
                                                    IpAddress = ipAddress,
                                                    SessionId = sessionId,
                                                    ClientType = clientType,
                                                    Email = email
                                                };
                                                if (string.IsNullOrEmpty(model.Filter))
                                                {
                                                    model.DeviceList.Add(lvItem);
                                                }
                                                if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter))))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                            }
                                        }
                                        if (resultDesktopCount > 0)
                                        {
                                            for (int i3 = 0; i3 < resultDesktopCount; i3++)
                                            {
                                                dynamic deviceNameObj = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["host_name"];
                                                dynamic ipAddressObj = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["ip_address"];
                                                dynamic sessionIdObj = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["session_id"];
                                                clientType = "Desktop";
                                                dynamic createdObj = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["created"];
                                                dynamic updatedObj = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["updated"];
                                                if (idObj != null)
                                                {
                                                    teamId = idObj.Value as string;
                                                }
                                                if (deviceNameObj != null)
                                                {
                                                    deviceName = deviceNameObj.Value as string;
                                                }
                                                if (ipAddressObj != null)
                                                {
                                                    ipAddress = ipAddressObj.Value as string;
                                                }
                                                if (sessionIdObj != null)
                                                {
                                                    sessionId = sessionIdObj.Value as string;
                                                }
                                                if (createdObj != null)
                                                {
                                                    created = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["created"];
                                                }
                                                if (updatedObj != null)
                                                {
                                                    updated = jsonDevicesDataCont["devices"][i]["desktop_clients"][i3]["updated"];
                                                }
                                                foreach (string[] lvitem in members)
                                                {
                                                    if (teamId == lvitem[0])
                                                    {
                                                        email = lvitem[1];
                                                    }
                                                }
                                                // update model
                                                DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                                {
                                                    Created = created,
                                                    Updated = updated,
                                                    TeamId = teamId,
                                                    DeviceName = deviceName,
                                                    IpAddress = ipAddress,
                                                    SessionId = sessionId,
                                                    ClientType = clientType,
                                                    Email = email
                                                };
                                                if (string.IsNullOrEmpty(model.Filter))
                                                {
                                                    model.DeviceList.Add(lvItem);
                                                }
                                                if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter))))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                            }
                                        }
                                        if (resultMobileCount > 0) {
                                            for (int i4 = 0; i4 < resultMobileCount; i4++)
                                            {
                                                dynamic deviceNameObj = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["device_name"];
                                                dynamic ipAddressObj = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["ip_address"];
                                                dynamic sessionIdObj = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["session_id"];
                                                clientType = "Mobile";
                                                dynamic createdObj = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["created"];
                                                dynamic updatedObj = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["updated"];
                                                if (idObj != null)
                                                {
                                                    teamId = idObj.Value as string;
                                                }
                                                if (deviceNameObj != null)
                                                {
                                                    deviceName = deviceNameObj.Value as string;
                                                }
                                                if (ipAddressObj != null)
                                                {
                                                    ipAddress = ipAddressObj.Value as string;
                                                }
                                                if (sessionIdObj != null)
                                                {
                                                    sessionId = sessionIdObj.Value as string;
                                                }
                                                if (createdObj != null)
                                                {
                                                    created = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["created"];
                                                }
                                                if (updatedObj != null)
                                                {
                                                    updated = jsonDevicesDataCont["devices"][i]["mobile_clients"][i4]["updated"];
                                                }
                                                foreach (string[] lvitem in members)
                                                {
                                                    if (teamId == lvitem[0])
                                                    {
                                                        email = lvitem[1];
                                                    }
                                                }
                                                // update model
                                                DeviceListViewItemModel lvItem = new DeviceListViewItemModel()
                                                {
                                                    Created = created,
                                                    Updated = updated,
                                                    TeamId = teamId,
                                                    DeviceName = deviceName,
                                                    IpAddress = ipAddress,
                                                    SessionId = sessionId,
                                                    ClientType = clientType,
                                                    Email = email
                                                };
                                                if (string.IsNullOrEmpty(model.Filter))
                                                {
                                                    model.DeviceList.Add(lvItem);
                                                }
                                                if (FilterCriteriaContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaNotContains && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.Contains(model.Filter))
                                                    {
                                                        //do nothing, don't add to list
                                                    }
                                                    if ((model.FilterType == "IpAddress" && (!ipAddress.Contains(model.Filter))) || (model.FilterType == "DeviceName" && (!deviceName.Contains(model.Filter)))) {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaBeginsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.StartsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                                if (FilterCriteriaEndsWith && !string.IsNullOrEmpty(model.Filter))
                                                {
                                                    if (model.FilterType == "IpAddress" && ipAddress.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                    if (model.FilterType == "DeviceName" && deviceName.EndsWith(model.Filter))
                                                    {
                                                        model.DeviceList.Add(lvItem);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                hasMore = jsonDevicesDataCont["has_more"];
                                cursor = jsonDevicesDataCont["cursor"];
                            }
                        }
                    }
                }
            }
        }

        #endregion REST Services

        #region Events

        private void OnDataChanged(object sender, EventArgs e)
        {
            IDevicesView view = base._view as IDevicesView;
            IDevicesModel model = base._model as IDevicesModel;
            PresenterBase.SetModelPropertiesFromView<IDevicesModel, IDevicesView>(
                ref model, view
            );
        }

        private void OnCommandGetDevices(object sender, EventArgs e)
        {
            IDevicesView view = base._view as IDevicesView;
            IDevicesModel model = base._model as IDevicesModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Gathering device list...");
                }, null);
            }
            Thread getDevices = new Thread(() => 
            {
                if (string.IsNullOrEmpty(model.UserAccessToken))
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                }
                else
                {
                    // perform search
                    GetDevices(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IDevicesView, IDevicesModel>(
                                ref view, model
                            );
                            view.RenderDeviceSearchResult();
                            if (model.DeviceList.Count > 0)
                            {
                                view.EnableDeviceButton(true);
                            }
                            presenter.UpdateProgressInfo("Completed");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            getDevices.Start();
        }

        private void OnCommandDumpDevices(object sender, EventArgs e)
        {
            IDevicesView view = base._view as IDevicesView;
            IDevicesModel model = base._model as IDevicesModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread dumpDevices = new Thread(() => 
            {
                if (string.IsNullOrEmpty(model.UserAccessToken))
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                }
                else
                {
                    // dump devices selected
                    this.DumpDevices(model, view, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IDevicesView, IDevicesModel>(
                                ref view, model
                            );
                            view.RenderDeviceSearchResult();
                            if (model.DeviceList.Count > 0)
                            {
                                view.EnableDeviceButton(true);
                            }
                            presenter.UpdateProgressInfo("Completed");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            dumpDevices.Start();
        }

        private void OnCommandExportDevices(object sender, EventArgs e)
        {
            // Export to CSV
            IDevicesView view = base._view as IDevicesView;
            IDevicesModel model = base._model as IDevicesModel;
            PresenterBase.SetModelPropertiesFromView<IDevicesModel, IDevicesView>(
                ref model, view
            );
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            try
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.EnableControl(false);
                        presenter.ActivateSpinner(true);
                        presenter.UpdateProgressInfo("Preparing Report...");
                    }, null);
                }

                FileInfo fileInfo = new FileInfo(model.OutputFileName);
                if (Directory.Exists(fileInfo.DirectoryName))
                {
                    Thread writeReport = new Thread(() => 
                    {
                        CsvConfiguration config = new CsvConfiguration()
                        {
                            HasHeaderRecord = true,
                            Delimiter = ",",
                            Encoding = System.Text.Encoding.UTF8
                        };
                        config.RegisterClassMap(new DevicesHeaderMap());
                        int total = model.DeviceList.Count;
                        using (CsvWriter writer = new CsvWriter(new StreamWriter(model.OutputFileName), config))
                        {
                            writer.WriteHeader<DevicesHeaderRecord>();
                            for (int i = 0; i < model.DeviceList.Count; i++)
                            {
                                DeviceListViewItemModel lvItem = model.DeviceList[i];
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.Created.ToString()) ? lvItem.Created.ToString() : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.Updated.ToString()) ? lvItem.Updated.ToString() : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.Email) ? lvItem.Email : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.TeamId) ? lvItem.TeamId : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.DeviceName) ? lvItem.DeviceName : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.IpAddress) ? lvItem.IpAddress : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.SessionId) ? lvItem.SessionId : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.ClientType) ? lvItem.ClientType : "");
                                writer.NextRecord();

                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Writing Record: {0}/{1}", (i + 1), total));
                                    }, null);
                                }
                            }
                        }

                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate 
                            {
                                presenter.EnableControl(true);
                                presenter.ActivateSpinner(false);
                                presenter.UpdateProgressInfo("Completed");
                            }, null);
                        }
                    });
                    writeReport.Start();
                }
                else
                {
                    throw new InvalidDataException(ErrorMessages.INVALID_EXPORT_FOLDER);
                }
            }
            catch (Exception ex)
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("Completed with exception: " + ex.Message);
                    }, null);
                }
            }
        }

        #endregion Events
    }
}