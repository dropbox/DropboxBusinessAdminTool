namespace DfBAdminToolkit.Presenter {

    using Common.Services;
    using Common.Utils;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;

    public class TeamHealthPresenter
        : PresenterBase, ITeamHealthPresenter {

        public TeamHealthPresenter(ITeamHealthModel model, ITeamHealthView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
            PresenterBase.SetViewPropertiesFromModel<ITeamHealthView, ITeamHealthModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                ITeamHealthView view = base._view as ITeamHealthView;
                view.DataChanged += OnDataChanged;
                view.CommandRefresh += OnCommandLoadHealth;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                ITeamHealthView view = base._view as ITeamHealthView;
                view.DataChanged -= OnDataChanged;
                view.CommandRefresh -= OnCommandLoadHealth;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private void RefreshHealth(ITeamHealthModel model, IMainPresenter presenter)
        {
            string fileAccessToken = ApplicationResource.DefaultAccessToken;
            //set default values so we have something
            int licensed = 0;
            int provisioned = 0;
            string name = string.Empty;
            string activityStartDate = string.Empty;
            int adds = 0;
            int edits = 0;
            int deletes = 0;
            int activeSharedFolders7Day = 0;
            int activeUsers7Day = 0;
            string devicesStartDate = string.Empty;
            int windows = 0;
            int macos = 0;
            int linux = 0;
            int ios = 0;
            int android = 0;
            int other = 0;
            int total = 0;
            string storageStartDate = string.Empty;
            UInt64 totalStorage = 0;
            UInt64 sharedStorage = 0;
            UInt64 unsharedStorage = 0;
            int sharedFolders = 0;

            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.GetInfoUrl = ApplicationResource.ActionGetInfo;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            IDataResponse response = service.GetInfo(fileAccessToken);

            IMemberServices serviceActivity = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            serviceActivity.GetActivityUrl = ApplicationResource.ActionGetActivity;
            serviceActivity.UserAgentVersion = ApplicationResource.UserAgent;
            IDataResponse responseActivity = serviceActivity.GetActivity(fileAccessToken);

            IMemberServices serviceDevices = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            serviceDevices.GetDevicesReportUrl = ApplicationResource.ActionGetDevices;
            serviceDevices.UserAgentVersion = ApplicationResource.UserAgent;
            IDataResponse responseDevices = serviceDevices.GetDevicesReport(fileAccessToken);

            IMemberServices serviceStorage = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            serviceStorage.GetStorageUrl = ApplicationResource.ActionGetStorage;
            serviceStorage.UserAgentVersion = ApplicationResource.UserAgent;
            IDataResponse responseStorage = serviceStorage.GetStorage(fileAccessToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    name = jsonData["name"];
                    licensed = jsonData["num_licensed_users"];
                    provisioned = jsonData["num_provisioned_users"];
                    model.TeamName = name;
                    model.LicensedUsers = licensed.ToString();
                    model.ProvisionedUsers = provisioned.ToString();
                }
            }
            if (responseActivity.StatusCode == HttpStatusCode.OK)
            {
                if (responseActivity.Data != null)
                {
                    string data = responseActivity.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    activityStartDate = jsonData["start_date"];
                    if (jsonData["adds"][0] != null)
                    {
                        int addsCount = (jsonData["adds"].Count) - 2;
                        adds = jsonData["adds"][addsCount];
                    }
                    if (jsonData["edits"][0] != null)
                    {
                        int editsCount = (jsonData["edits"].Count) - 2;
                        edits = jsonData["edits"][editsCount];
                    }
                    if (jsonData["deletes"][0] != null)
                    {
                        int deletesCount = (jsonData["deletes"].Count) - 2;
                        deletes = jsonData["deletes"][deletesCount];
                    }
                    if (jsonData["active_shared_folders_7_day"][0] != null)
                    {
                        int activeSharedCount = (jsonData["active_shared_folders_7_day"].Count) - 2;
                        activeSharedFolders7Day = jsonData["active_shared_folders_7_day"][activeSharedCount];
                    }
                    if (jsonData["active_users_7_day"][0] != null)
                    {
                        int activeUsers = (jsonData["active_users_7_day"].Count) - 2;
                        activeUsers7Day = jsonData["active_users_7_day"][activeUsers];
                    }
                    model.Adds = adds.ToString();
                    model.Edits = edits.ToString();
                    model.Deletes = deletes.ToString();
                    model.ActiveSharedFolders7Day = activeSharedFolders7Day.ToString();
                    model.ActiveUsers7Day = activeUsers7Day.ToString();
                }
            }
            if (responseDevices.StatusCode == HttpStatusCode.OK)
            {
                if (responseDevices.Data != null)
                {
                    string data = responseDevices.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    devicesStartDate = jsonData["start_date"];
                    if (jsonData["active_7_day"] != null)
                    {
                        if (jsonData["active_7_day"]["windows"][0] != null)
                        {
                            int windowsUsers = (jsonData["active_7_day"]["windows"].Count) - 2;
                            windows = jsonData["active_7_day"]["windows"][windowsUsers];
                        }
                        if (jsonData["active_7_day"]["macos"][0] != null)
                        {
                            int macosUsers = (jsonData["active_7_day"]["macos"].Count) - 2;
                            macos = jsonData["active_7_day"]["macos"][macosUsers];
                        }
                        if (jsonData["active_7_day"]["linux"][0] != null)
                        {
                            int linuxUsers = (jsonData["active_7_day"]["linux"].Count) - 2;
                            linux = jsonData["active_7_day"]["linux"][linuxUsers];
                        }
                        if (jsonData["active_7_day"]["ios"][0] != null)
                        {
                            int iosUsers = (jsonData["active_7_day"]["ios"].Count) - 2;
                            ios = jsonData["active_7_day"]["ios"][iosUsers];
                        }
                        if (jsonData["active_7_day"]["android"][0] != null)
                        {
                            int androidUsers = (jsonData["active_7_day"]["android"].Count) - 2;
                            android = jsonData["active_7_day"]["android"][androidUsers];
                        }
                        if (jsonData["active_7_day"]["other"][0] != null)
                        {
                            int otherUsers = (jsonData["active_7_day"]["other"].Count) - 2;
                            other = jsonData["active_7_day"]["other"][otherUsers];
                        }
                        if (jsonData["active_7_day"]["total"][0] != null)
                        {
                            int totalUsers = (jsonData["active_7_day"]["total"].Count) - 2;
                            total = jsonData["active_7_day"]["total"][totalUsers];
                        }
                    }
                    model.windows = windows.ToString();
                    model.macos = macos.ToString();
                    model.linux = linux.ToString();
                    model.ios = ios.ToString();
                    model.android = android.ToString();
                    model.other = other.ToString();
                    model.total = total.ToString();
                }
            }
            if (responseStorage.StatusCode == HttpStatusCode.OK)
            {
                if (responseStorage.Data != null)
                {
                    string data = responseStorage.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    storageStartDate = jsonData["start_date"];
                    if (jsonData["total_usage"][0] != null)
                    {
                        int totalCount = (jsonData["total_usage"].Count) - 2;
                        totalStorage = jsonData["total_usage"][totalCount];
                        double totalStorageDec = FileUtil.FormatFileSizeTB(totalStorage);
                        model.TotalUsage = totalStorageDec.ToString() + " TB";
                    }
                    if (jsonData["shared_usage"][0] != null)
                    {
                        int sharedCount = (jsonData["shared_usage"].Count) - 2;
                        sharedStorage = jsonData["shared_usage"][sharedCount];
                        double sharedStorageDec = FileUtil.FormatFileSizeTB(sharedStorage);
                        model.SharedUsage = sharedStorageDec.ToString() + " TB";
                    }
                    if (jsonData["unshared_usage"][0] != null)
                    {
                        int unsharedCount = (jsonData["unshared_usage"].Count) - 2;
                        unsharedStorage = jsonData["unshared_usage"][unsharedCount];
                        double unsharedStorageDec = FileUtil.FormatFileSizeTB(unsharedStorage);
                        model.UnsharedUsage = unsharedStorageDec.ToString() + " TB";
                    }
                    if (jsonData["shared_folders"][0] != null)
                    {
                        int sharedFolderCount = (jsonData["shared_folders"].Count) - 2;
                        sharedFolders = jsonData["shared_folders"][sharedFolderCount];
                        model.SharedFolders = sharedFolders.ToString();
                    }     
                }
            }
            model.RefreshDateTime = DateTime.Now;
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadHealth(object sender, EventArgs e)
        {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Pulling health report stats...");
                }, null);
            }
            Thread healthrefresh = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    this.RefreshHealth(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view with model.
                            view.LoadViewHealthItems(model);
                            presenter.UpdateProgressInfo("Health stats refreshed at [" + model.RefreshDateTime.ToString() + "]");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            healthrefresh.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
            PresenterBase.SetModelPropertiesFromView<ITeamHealthModel, ITeamHealthView>(
                ref model, view
            );
        }

        #endregion Events
    }
}