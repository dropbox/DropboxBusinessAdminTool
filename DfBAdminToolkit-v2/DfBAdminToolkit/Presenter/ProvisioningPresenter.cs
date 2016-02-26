namespace DfBAdminToolkit.Presenter {

    using CsvHelper;
    using CsvHelper.Configuration;
    using DfBAdminToolkit.Common.Services;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;

    public class ProvisioningPresenter
        : PresenterBase, IProvisioningPresenter {

        public ProvisioningPresenter(IProvisioningModel model, IProvisioningView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetViewPropertiesFromModel<IProvisioningView, IProvisioningModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged += OnDataChanged;
                view.CommandProvision += OnCommandProvision;
                view.CommandDeprovision += OnCommandDeprovision;
                view.CommandLoadInputFile += OnCommandLoadInputFile;
                view.CommandCreateCSV += OnCommandListMembersCreateCSV;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged -= OnDataChanged;
                view.CommandProvision -= OnCommandProvision;
                view.CommandDeprovision -= OnCommandDeprovision;
                view.CommandLoadInputFile -= OnCommandLoadInputFile;
                view.CommandCreateCSV -= OnCommandListMembersCreateCSV;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public bool LoadInputFile(IProvisioningModel model, IMainPresenter presenter) {
            bool loaded = true;
            try {
                FileInfo fInfo = new FileInfo(model.InputFilePath);
                if (fInfo.Exists) {
                    // try load.
                    model.Members.Clear();
                    CsvConfiguration config = new CsvConfiguration() {
                        HasHeaderRecord = false
                    };
                    using (CsvReader reader = new CsvReader(new StreamReader(fInfo.FullName), config)) {
                        while (reader.Read()) {
                            try {
                                MemberListViewItemModel lvItem = new MemberListViewItemModel() {
                                    Email = reader.GetField<string>(0),
                                    FirstName = reader.GetField<string>(1),
                                    LastName = reader.GetField<string>(2),
                                    IsChecked = true
                                };
                                model.Members.Add(lvItem);
                            } catch {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Members.Any()) {
                            loaded = true;
                        }
                    }
                } else {
                    throw new InvalidDataException(ErrorMessages.MISSING_CSV_FILE);
                }
            } catch (Exception e) {
                // error message.
                SyncContext.Post(delegate {
                    presenter.ShowErrorMessage(e.Message, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return loaded;
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private string ProvisionRoles(IProvisioningModel model, IMainPresenter presenter) {
            string errorMessage = string.Empty;
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.AddMemberUrl = ApplicationResource.ActionAddMember;
            foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList()) {
                IServiceResponse response = service.AddMember(new MemberData() {
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    SendWelcomeEmail = model.SendWelcomeEmail,
                    RoleName = model.SelectedRole
                }, model.AccessToken);

                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            presenter.UpdateProgressInfo(string.Format("Updated Member: {0}: {1} {2}", item.Email, item.FirstName, item.LastName));
                        }, null);
                    }
                } else {
                    errorMessage = ErrorMessages.FAILED_TO_ADD_MEMBER;
                }
            }
            return errorMessage;
        }

        private string DeprovisionRoles(IProvisioningModel model, IMainPresenter presenter) {
            string errorMessage = string.Empty;
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.RemoveMemberUrl = ApplicationResource.ActionRemoveMember;
            foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList()) {
                IServiceResponse response = service.RemoveMember(new MemberData() {
                    Email = item.Email
                }, model.AccessToken);

                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            presenter.UpdateProgressInfo(string.Format("Removed Member: {0}", item.Email));
                        }, null);
                    }
                } else {
                    errorMessage = ErrorMessages.FAILED_TO_REMOVE_MEMBER;
                }
            }
            return errorMessage;
        }

        private void SearchMembersCreateCSV(IProvisioningModel model) {
            string UserAccessToken = ConfigurationManager.AppSettings.Get("DefaultAccessToken");
            if (!string.IsNullOrEmpty(UserAccessToken)) {
                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                IDataResponse response = service.ListMembers(new MemberData() {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK) {
                    if (response.Data != null) {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.Members.Clear();

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++) {
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            dynamic statusObj = jsonData["members"][i]["profile"]["status"][".tag"];
                            dynamic firstNameObj = jsonData["members"][i]["profile"]["name"]["given_name"];
                            dynamic lastNameObj = jsonData["members"][i]["profile"]["name"]["surname"];
                            dynamic roleObj = jsonData["members"][i]["role"][".tag"];
                            string email = emailObj.Value as string;
                            string status = statusObj.Value as string;
                            string firstName = firstNameObj.Value as string;
                            string lastName = lastNameObj.Value as string;
                            string role = roleObj.Value as string;

                            // update model
                            MemberListViewItemModel lvItem = new MemberListViewItemModel() {
                                Email = email,
                                FirstName = firstName,
                                LastName = lastName,
                                Status = status,
                                Role = role
                            };

                            model.Members.Add(lvItem);
                        }
                        //if the memberID count is above limit - default 1000 we need to grab the cursor and call continue
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore) {
                            service.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            IDataResponse responseCont = service.ListMembersContinuation(new MemberData() {
                                Cursor = cursor
                            }, UserAccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++) {
                                dynamic emailObj = jsonDataCont["members"][i]["profile"]["email"];
                                dynamic statusObj = jsonDataCont["members"][i]["profile"]["status"][".tag"];
                                dynamic firstNameObj = jsonDataCont["members"][i]["profile"]["name"]["given_name"];
                                dynamic lastNameObj = jsonDataCont["members"][i]["profile"]["name"]["surname"];
                                dynamic roleObj = jsonDataCont["members"][i]["role"][".tag"];
                                string email = emailObj.Value as string;
                                string status = statusObj.Value as string;
                                string firstName = firstNameObj.Value as string;
                                string lastName = lastNameObj.Value as string;
                                string role = roleObj.Value as string;

                                // update model
                                MemberListViewItemModel lvItem = new MemberListViewItemModel() {
                                    Email = email,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Status = status,
                                    Role = role
                                };

                                model.Members.Add(lvItem);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadInputFile(object sender, EventArgs e) {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading Input File...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread load = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken)) {
                    bool loaded = this.LoadInputFile(model, presenter);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderMemberList(model.Members);
                            presenter.UpdateProgressInfo("CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            view.EnableProvisionButton(loaded);
                            view.EnableDeprovisionButton(loaded);
                        }, null);
                    }
                }
            });
            load.Start();
        }

        private void OnCommandProvision(object sender, System.EventArgs e) {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread provision = new Thread(() => {
                if (string.IsNullOrEmpty(model.AccessToken)) {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                } else if (string.IsNullOrEmpty(model.SelectedRole)) {
                    SyncContext.Post(delegate {
                        presenter.ShowErrorMessage(ErrorMessages.MISSING_ROLE, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                } else {
                    string error = ProvisionRoles(model, presenter);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            if (!string.IsNullOrEmpty(error)) {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            } else {
                                presenter.UpdateProgressInfo("Completed");
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            provision.Start();
        }

        private void OnCommandDeprovision(object sender, System.EventArgs e) {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread deprovision = new Thread(() => {
                if (string.IsNullOrEmpty(model.AccessToken)) {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                } else {
                    string error = DeprovisionRoles(model, presenter);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            if (!string.IsNullOrEmpty(error)) {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            } else {
                                presenter.UpdateProgressInfo("Completed");
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            deprovision.Start();
        }

        private void OnCommandListMembersCreateCSV(object sender, EventArgs e) {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            // notify view to mark start of process
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Creating CSV file...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread createCSV = new Thread(() => {
                if (string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("DefaultAccessToken"))) {
                    SyncContext.Post(delegate {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                } else {
                    // perform search
                    this.SearchMembersCreateCSV(model);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IProvisioningView, IProvisioningModel>(
                                ref view, model
                            );
                            //view.RenderMembersFileSearchResult();
                            string sPath = string.Empty;
                            if (model.Members.Count > 0) {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DBMembers.csv";

                                StreamWriter SaveFile = new StreamWriter(sPath);
                                foreach (var item in model.Members) {
                                    SaveFile.WriteLine(item.Email + "," + item.FirstName + "," + item.LastName + "," + item.Status + "," + item.Role);
                                }
                                SaveFile.Close();
                            }
                            presenter.UpdateProgressInfo("Completed. Exported file located at " + sPath);
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            // start async search
            createCSV.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetModelPropertiesFromView<IProvisioningModel, IProvisioningView>(
                ref model, view
            );
        }

        #endregion Events
    }
}