namespace DfBAdminToolkit.Presenter
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using DfBAdminToolkit.Common.Services;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class ProvisioningPresenter
        : PresenterBase, IProvisioningPresenter
    {
        public ProvisioningPresenter(IProvisioningModel model, IProvisioningView view)
            : base(model, view)
        {
        }

        protected override void Initialize()
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetViewPropertiesFromModel<IProvisioningView, IProvisioningModel>(
                ref view, model
            );

            SyncContext.Post(delegate
            {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents()
        {
            if (!IsViewEventsWired)
            {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged += OnDataChanged;
                view.CommandProvision += OnCommandProvision;
                view.CommandLoadInputFile += OnCommandLoadInputFile;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents()
        {
            if (IsViewEventsWired)
            {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged -= OnDataChanged;
                view.CommandProvision -= OnCommandProvision;
                view.CommandLoadInputFile -= OnCommandLoadInputFile;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp()
        {
        }

        public bool LoadInputFile(IProvisioningModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.InputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.Members.Clear();
                    CsvConfiguration config = new CsvConfiguration()
                    {
                        HasHeaderRecord = false
                    };
                    using (CsvReader reader = new CsvReader(new StreamReader(fInfo.FullName), config))
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                MemberListViewItemModel lvItem = new MemberListViewItemModel()
                                {
                                    Email = reader.GetField<string>(0),
                                    FirstName = reader.GetField<string>(1),
                                    LastName = reader.GetField<string>(2),
                                    IsChecked = true
                                };
                                model.Members.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Members.Any())
                        {
                            loaded = true;
                        }
                    }
                }
                else
                {
                    throw new InvalidDataException(ErrorMessages.MISSING_CSV_FILE);
                }
            }
            catch (Exception e)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(e.Message, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return loaded;
        }

        #region REST Service

        private string ProvisionRoles(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.AddMemberUrl = ApplicationResource.ActionAddMember;
            foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
            {
                IServiceResponse response = service.AddMember(new MemberData()
                {
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    SendWelcomeEmail = model.SendWelcomeEmail,
                    RoleName = model.SelectedRole
                }, model.AccessToken);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            presenter.UpdateProgressInfo(string.Format("Updated Member: {0}: {1} {2}", item.Email, item.FirstName, item.LastName));
                        }, null);
                    }
                }
                else
                {
                    errorMessage = ErrorMessages.FAILED_TO_ADD_MEMBER;
                }
            }
            return errorMessage;
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadInputFile(object sender, EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading Input File...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread load = new Thread(() =>
            {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    bool loaded = this.LoadInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            view.RenderMemberList(model.Members);
                            presenter.UpdateProgressInfo("CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            view.EnableProvisionButton(loaded);
                        }, null);
                    }
                }
            });
            load.Start();
        }

        private void OnCommandProvision(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread provision = new Thread(() =>
            {
                if (string.IsNullOrEmpty(model.AccessToken))
                {
                    SyncContext.Post(delegate
                    {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                }
                else if (string.IsNullOrEmpty(model.SelectedRole))
                {
                    SyncContext.Post(delegate
                    {
                        presenter.ShowErrorMessage(ErrorMessages.MISSING_ROLE, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                }
                else
                {
                    string error = this.ProvisionRoles(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
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

        private void OnDataChanged(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetModelPropertiesFromView<IProvisioningModel, IProvisioningView>(
                ref model, view
            );
        }

        #endregion Events
    }
}