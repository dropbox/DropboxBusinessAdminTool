namespace DfBAdminToolkit.Presenter
{
    using Common.Services;
    using Common.Utils;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using View;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using Excel = Microsoft.Office.Interop.Excel;

    public class DataMigrationPresenter
        : PresenterBase, IDataMigrationPresenter
    {
        private static readonly object insertLock = new object();

        public DataMigrationPresenter()
            : this(new DataMigrationModel(), new DataMigrationView())
        {
        }

        public DataMigrationPresenter(IDataMigrationModel model, IDataMigrationView view)
            : base(model, view) {
        }

        protected override void Initialize()
        {
            IDataMigrationView view = base._view as IDataMigrationView;
            IDataMigrationModel model = base._model as IDataMigrationModel;
            PresenterBase.SetViewPropertiesFromModel<IDataMigrationView, IDataMigrationModel>(
                ref view, model
            );
        }

        protected override void WireViewEvents()
        {
            if (!IsViewEventsWired) {
                IDataMigrationView view = base._view as IDataMigrationView;
                view.DataChanged += OnDataChanged;
                view.CommandDisplayContent += OnCommandDisplayContent;
                view.CommandExportContent += OnCommandExportContent;
                view.CommandExportContentExcel += OnCommandExportContentExcel;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents()
        {
            if (IsViewEventsWired) {
                IDataMigrationView view = base._view as IDataMigrationView;
                view.DataChanged -= OnDataChanged;
                view.CommandDisplayContent -= OnCommandDisplayContent;
                view.CommandExportContent -= OnCommandExportContent;
                view.CommandExportContentExcel -= OnCommandExportContentExcel;
                IsViewEventsWired = false;
            }
        }

        public void UpdateSettings()
        {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service call

        private void SearchItems(
            IMemberServices service,
            TeamListViewItemModel owner,
            IDataMigrationModel model,
            IMainPresenter presenter)
        {
            bool SuppressStatus = ApplicationResource.SuppressFilenamesInStatus;
            try
            {
                service.ListFolderUrl = ApplicationResource.ActionListFolder;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.ListFolders(
                   new MemberData() {
                       MemberId = owner.TeamId
                   }, model.AccessToken);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string content = response.Data as string;
                        dynamic jsonDataSearch = JsonConvert.DeserializeObject<dynamic>(content);
                        IDictionary<string, long> folderMap = new Dictionary<string, long>();
                        int entryCount = jsonDataSearch["entries"].Count;
                        int foundTotal = 0;
                        for (int i = 0; i < entryCount; i++)
                        {
                            dynamic entry = jsonDataSearch["entries"][i];
                            string type = entry[".tag"].ToString();
                            ContentDisplayListViewItemModel lvItem = null;
                            if (type.Equals("folder"))
                            {
                                lvItem = new ContentDisplayListViewItemModel()
                                {
                                    ItemType = type,
                                    Email = owner.Email,
                                    MemberId = owner.TeamId,
                                    FirstName = owner.FirstName,
                                    LastName = owner.LastName,
                                    ItemName = entry["name"].ToString(),
                                    ItemPath = entry["path_lower"].ToString(),
                                    ItemPathDisplay = entry["path_display"].ToString(),
                                    ItemSizeByte = 0
                                };
                            }
                            else
                            {
                                string serverModified = entry["server_modified"].ToString();
                                string serverModifiedDate = string.Empty;
                                if (!string.IsNullOrEmpty(serverModified))
                                {
                                    DateTime lastModified = DateTime.SpecifyKind(
                                        DateTime.Parse(serverModified),
                                        DateTimeKind.Utc
                                    );
                                    serverModifiedDate = lastModified.ToString("dd MMM yyyy");
                                }
                                string fileSizeStr = jsonDataSearch["entries"][i]["size"].ToString();
                                long fileSize = 0;
                                long.TryParse(fileSizeStr, out fileSize);
                                lvItem = new ContentDisplayListViewItemModel()
                                {
                                    ItemType = type,
                                    Email = owner.Email,
                                    MemberId = owner.TeamId,
                                    FirstName = owner.FirstName,
                                    LastName = owner.LastName,
                                    ItemName = entry["name"].ToString(),
                                    ItemPath = entry["path_lower"].ToString(),
                                    ItemPathDisplay = entry["path_display"].ToString(),
                                    ItemSize = FileUtil.FormatFileSize(fileSize),
                                    ItemSizeByte = fileSize,
                                    LastModified = serverModifiedDate,
                                    Uploaded = serverModifiedDate,
                                    Created = serverModifiedDate
                                };
                            }
                            lock (insertLock)
                            {
                                model.Contents.Add(lvItem);
                            }
                            if (SyncContext != null)
                            {
                                SyncContext.Post(delegate
                                {
                                    if (!SuppressStatus)
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Owner: [{0}] Item: [{1}] {2}/{3}", lvItem.Email, lvItem.ItemName, (++foundTotal), entryCount));
                                    }
                                    else
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Owner: [{0}] Item: [{1}] {2}/{3}", lvItem.Email, "Suppressing filename status", (++foundTotal), entryCount));
                                    }
                                    
                                }, null);
                            }
                        }
                        bool hasMore = jsonDataSearch["has_more"];
                        string cursor = jsonDataSearch["cursor"];

                        while (hasMore)
                        {
                            service.ListFolderUrl = ApplicationResource.ActionListFolderContinuation;
                            IDataResponse responseCont = service.ListFolders(
                            new MemberData()
                            {
                                MemberId = owner.TeamId,
                                Cursor = cursor
                            }, model.AccessToken);

                            string contentCont = responseCont.Data as string;
                            dynamic jsonDataSearchCont = JsonConvert.DeserializeObject<dynamic>(contentCont);
                            IDictionary<string, long> folderMapCont = new Dictionary<string, long>();
                            int entryCountCont = jsonDataSearchCont["entries"].Count;
                            int foundTotalCont = 0;
                            for (int i = 0; i < entryCountCont; i++)
                            {
                                dynamic entry = jsonDataSearchCont["entries"][i];
                                string type = entry[".tag"].ToString();
                                ContentDisplayListViewItemModel lvItem = null;
                                if (type.Equals("folder"))
                                {
                                    lvItem = new ContentDisplayListViewItemModel()
                                    {
                                        ItemType = type,
                                        Email = owner.Email,
                                        MemberId = owner.TeamId,
                                        FirstName = owner.FirstName,
                                        LastName = owner.LastName,
                                        ItemName = entry["name"].ToString(),
                                        ItemPath = entry["path_lower"].ToString(),
                                        ItemPathDisplay = entry["path_display"].ToString(),
                                        ItemSizeByte = 0
                                    };
                                }
                                else
                                {
                                    string serverModified = entry["server_modified"].ToString();
                                    string serverModifiedDate = string.Empty;
                                    if (!string.IsNullOrEmpty(serverModified))
                                    {
                                        DateTime lastModified = DateTime.SpecifyKind(
                                            DateTime.Parse(serverModified),
                                            DateTimeKind.Utc
                                        );
                                        serverModifiedDate = lastModified.ToString("dd MMM yyyy");
                                    }
                                    string fileSizeStr = jsonDataSearchCont["entries"][i]["size"].ToString();
                                    long fileSize = 0;
                                    long.TryParse(fileSizeStr, out fileSize);
                                    lvItem = new ContentDisplayListViewItemModel()
                                    {
                                        ItemType = type,
                                        Email = owner.Email,
                                        MemberId = owner.TeamId,
                                        FirstName = owner.FirstName,
                                        LastName = owner.LastName,
                                        ItemName = entry["name"].ToString(),
                                        ItemPath = entry["path_lower"].ToString(),
                                        ItemPathDisplay = entry["path_display"].ToString(),
                                        ItemSize = FileUtil.FormatFileSize(fileSize),
                                        ItemSizeByte = fileSize,
                                        LastModified = serverModifiedDate,
                                        Uploaded = serverModifiedDate,
                                        Created = serverModifiedDate
                                    };
                                }
                                lock (insertLock)
                                {
                                    model.Contents.Add(lvItem);
                                }
                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate
                                    {
                                        if (!SuppressStatus)
                                        {
                                            presenter.UpdateProgressInfo(string.Format("Owner: [{0}] Item: [{1}] {2}/{3}", lvItem.Email, lvItem.ItemName, (++foundTotalCont), entryCountCont));
                                        }
                                        else
                                        {
                                            presenter.UpdateProgressInfo(string.Format("Owner: [{0}] Item: [{1}] {2}/{3}", lvItem.Email, "Suppressing filename status", (++foundTotalCont), entryCountCont));
                                        }
                                        
                                    }, null);
                                }
                            }
                            hasMore = jsonDataSearchCont["has_more"];
                            cursor = jsonDataSearchCont["cursor"];     
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private IList<TeamListViewItemModel> SearchOwner(
            IDataMigrationModel model,
            IMainPresenter presenter) {
            IList<TeamListViewItemModel> members = new List<TeamListViewItemModel>();
            if (!string.IsNullOrEmpty(model.AccessToken)) {
                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.ListMembers(new MemberData() {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, model.AccessToken);

                if (SyncContext != null) {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo("Searching Owners...");
                    }, null);
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);
                        int resultCount = jsonData["members"].Count;
                        int total = 0;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic profile = jsonData["members"][i]["profile"];
                            dynamic idObj = profile["team_member_id"];
                            dynamic emailObj = profile["email"];
                            dynamic name = profile["name"];
                            dynamic status = profile["status"];
                            if (status != null && (status[".tag"].ToString().Equals("active") || status[".tag"].ToString().Equals("suspended") || status[".tag"].ToString().Equals("invited")))
                            {
                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;
                                string firstName = name["given_name"].ToString();
                                string surName = name["surname"].ToString();

                                // update model
                                TeamListViewItemModel lvItem = new TeamListViewItemModel() {
                                    Email = email,
                                    TeamId = teamId,
                                    FirstName = firstName,
                                    LastName = surName
                                };
                                members.Add(lvItem);
                            }

                            if (SyncContext != null) {
                                SyncContext.Post(delegate {
                                    presenter.UpdateProgressInfo("Scanning Account(s): " + (++total));
                                }, null);
                            }
                        }

                        // collect more.
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            service.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            IDataResponse responseCont = service.ListMembersContinuation(new MemberData() {
                                Cursor = cursor
                            }, model.AccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic profile = jsonDataCont["members"][i]["profile"];
                                dynamic idObj = profile["team_member_id"];
                                dynamic emailObj = profile["email"];
                                dynamic name = profile["name"];
                                dynamic status = profile["status"];

                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;
                                string firstName = name["given_name"].ToString();
                                string surName = name["surname"].ToString();

                                if (status != null && (status[".tag"].ToString().Equals("active") || status[".tag"].ToString().Equals("suspended") || status[".tag"].ToString().Equals("invited")))
                                {
                                    // update model
                                    TeamListViewItemModel lvItem = new TeamListViewItemModel() {
                                        Email = email,
                                        TeamId = teamId,
                                        FirstName = firstName,
                                        LastName = surName
                                    };
                                    members.Add(lvItem);
                                }
                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate {
                                        presenter.UpdateProgressInfo("Scanning Account(s): " + (++total));
                                    }, null);
                                }
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
            return members;
        }

        #endregion REST Service call

        #region Events

        private void OnDataChanged(object sender, System.EventArgs e)
        {
            IDataMigrationView view = base._view as IDataMigrationView;
            IDataMigrationModel model = base._model as IDataMigrationModel;
            PresenterBase.SetModelPropertiesFromView<IDataMigrationModel, IDataMigrationView>(
                ref model, view
            );
        }

        private void OnCommandExportContent(object sender, EventArgs e)
        {
            // Export to CSV
            IDataMigrationView view = base._view as IDataMigrationView;
            IDataMigrationModel model = base._model as IDataMigrationModel;
            PresenterBase.SetModelPropertiesFromView<IDataMigrationModel, IDataMigrationView>(
                ref model, view
            );
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            try
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(false);
                        presenter.ActivateSpinner(true);
                        presenter.UpdateProgressInfo("Preparing Report...");
                    }, null);
                }

                FileInfo fileInfo = new FileInfo(model.OutputFileName);
                if (Directory.Exists(fileInfo.DirectoryName))
                {
                    Thread writeReport = new Thread(() => {
                        CsvConfiguration config = new CsvConfiguration() {
                            HasHeaderRecord = true,
                            Delimiter = ",",
                            Encoding = System.Text.Encoding.UTF8
                        };
                        config.RegisterClassMap(new DataMigrationHeaderMap());
                        int total = model.Contents.Count;
                        using (CsvWriter writer = new CsvWriter(new StreamWriter(model.OutputFileName), config))
                        {
                            writer.WriteHeader<DataMigrationHeaderRecord>();
                            for (int i = 0; i < model.Contents.Count; i++)
                            {
                                ContentDisplayListViewItemModel lvItem = model.Contents[i];
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.OwnerName) ? lvItem.OwnerName : "");
                                writer.WriteField<string>(lvItem.Email);
                                writer.WriteField<string>(lvItem.ItemPathDisplay);
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.ItemPathId) ? lvItem.ItemPathId : "");
                                writer.WriteField<string>(lvItem.ItemName);
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.ItemId) ? lvItem.ItemId : "");
                                writer.WriteField<string>(lvItem.ItemType);
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.ItemSize) ? lvItem.ItemSize : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.Created) ? lvItem.Created : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.LastModified) ? lvItem.LastModified : "");
                                writer.WriteField<string>(!string.IsNullOrEmpty(lvItem.Uploaded) ? lvItem.Uploaded : "");
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
                            SyncContext.Post(delegate {
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
                    SyncContext.Post(delegate {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("Completed with exception: " + ex.Message);
                    }, null);
                }
            }
        }

        private void OnCommandExportContentExcel(object sender, EventArgs e)
        {
            // Export to Excel
            IDataMigrationView view = base._view as IDataMigrationView;
            IDataMigrationModel model = base._model as IDataMigrationModel;
            PresenterBase.SetModelPropertiesFromView<IDataMigrationModel, IDataMigrationView>(
                ref model, view
            );
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            try
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(false);
                        presenter.ActivateSpinner(true);
                        presenter.UpdateProgressInfo("Preparing Report...");
                    }, null);
                }

                FileInfo fileInfo = new FileInfo(model.OutputFileName);
                if (Directory.Exists(fileInfo.DirectoryName))
                {
                    Thread writeReportExcel = new Thread(() => {
                        int total = model.Contents.Count;
                        //set max rows per sheet to 1 million. Actual number Excel pukes on is anything over 1,048,576
                        int maxRowsPerSheet = 1000000;
                        int sheetCount = 1;
                        int modelStartRow = 0;
                        int modelEndRow = 1;
                        int totalRowsLeft = 0;
                        bool complete = false;

                        //get inital rows left
                        totalRowsLeft = model.Contents.Count - maxRowsPerSheet;

                        //round up for number of sheets based on rowcount
                        int totalSheets = Convert.ToInt32(Math.Ceiling((double)total / (double)maxRowsPerSheet));

                        Excel.Application xlApp = new Excel.Application();
                        xlApp.DisplayAlerts = false;

                        //Give error if Excel not installed on system
                        if (xlApp == null)
                        {
                            SyncContext.Post(delegate 
                            {
                                presenter.EnableControl(true);
                                presenter.ActivateSpinner(false);
                                presenter.UpdateProgressInfo(ErrorMessages.EXCEL_MISSING);
                            }, null);
                            return;
                        }

                        Excel.Workbook xlWorkBook;
                        Excel.Worksheet xlWorkSheet = null;
                        object misValue = Missing.Value;

                        xlWorkBook = xlApp.Workbooks.Add(misValue);
                        
                        //need code to add extra worksheets, based on how many rows we have above
                        Excel.Sheets worksheets = xlWorkBook.Worksheets;

                        while (!complete)
                        {
                            while (sheetCount <= totalSheets)
                            {
                                var xlNewSheet = (Excel.Worksheet)worksheets.Add(worksheets[sheetCount], Type.Missing, Type.Missing, Type.Missing);
                                xlNewSheet.Name = sheetCount.ToString();

                                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheetCount);

                                //write headers
                                xlWorkSheet.Cells[1, 1] = "Owner Name";
                                xlWorkSheet.Cells[1, 2] = "Owner Login";
                                xlWorkSheet.Cells[1, 3] = "Path";
                                xlWorkSheet.Cells[1, 4] = "Path ID";
                                xlWorkSheet.Cells[1, 5] = "Item Name";
                                xlWorkSheet.Cells[1, 6] = "Item ID";
                                xlWorkSheet.Cells[1, 7] = "Item Type";
                                xlWorkSheet.Cells[1, 8] = "Size";
                                xlWorkSheet.Cells[1, 9] = "Created";
                                xlWorkSheet.Cells[1, 10] = "Last Modified";
                                xlWorkSheet.Cells[1, 11] = "Uploaded";

                                int endRow = 0;
                                //over 1 million rows, setting values for output to Excel sheets
                                if (totalRowsLeft > 0 && totalRowsLeft > maxRowsPerSheet)
                                {
                                    endRow = endRow + maxRowsPerSheet;
                                }
                                if (totalRowsLeft > 0 && totalRowsLeft < maxRowsPerSheet)
                                {
                                    endRow = endRow + totalRowsLeft;
                                }
                                modelEndRow = modelEndRow + endRow;

                                if (modelEndRow < model.Contents.Count)
                                {
                                    modelEndRow--;
                                }
                                if (modelEndRow > model.Contents.Count)
                                {
                                    modelEndRow = model.Contents.Count;
                                }
                                //we only need one sheet
                                if (totalRowsLeft < 0)
                                {
                                    modelEndRow = model.Contents.Count;
                                }
                                //start at 1 for each sheet so we can increment past header row
                                int rowCount = 1;

                                for (int i2 = modelStartRow; i2 < modelEndRow; i2++)
                                {
                                    ContentDisplayListViewItemModel lvItem = model.Contents[i2];
                                    rowCount++;
                                    endRow++;

                                    xlWorkSheet.Cells[rowCount, 1] = (!string.IsNullOrEmpty(lvItem.OwnerName) ? lvItem.OwnerName : "");
                                    xlWorkSheet.Cells[rowCount, 2] = (lvItem.Email);
                                    xlWorkSheet.Cells[rowCount, 3] = (lvItem.ItemPathDisplay);
                                    xlWorkSheet.Cells[rowCount, 4] = (!string.IsNullOrEmpty(lvItem.ItemPathId) ? lvItem.ItemPathId : "");
                                    xlWorkSheet.Cells[rowCount, 5] = (lvItem.ItemName);
                                    xlWorkSheet.Cells[rowCount, 6] = (!string.IsNullOrEmpty(lvItem.ItemId) ? lvItem.ItemId : "");
                                    xlWorkSheet.Cells[rowCount, 7] = (lvItem.ItemType);
                                    xlWorkSheet.Cells[rowCount, 8] = (!string.IsNullOrEmpty(lvItem.ItemSize) ? lvItem.ItemSize : "");
                                    xlWorkSheet.Cells[rowCount, 9] = (!string.IsNullOrEmpty(lvItem.Created) ? lvItem.Created : "");
                                    xlWorkSheet.Cells[rowCount, 10] = (!string.IsNullOrEmpty(lvItem.LastModified) ? lvItem.LastModified : "");
                                    xlWorkSheet.Cells[rowCount, 11] = (!string.IsNullOrEmpty(lvItem.Uploaded) ? lvItem.Uploaded : "");

                                    if (SyncContext != null)
                                    {
                                        SyncContext.Post(delegate
                                        {
                                            presenter.UpdateProgressInfo(string.Format("Writing Record: {0}/{1}", (i2 + 1), total));
                                        }, null);
                                    }
                                }
                                //move one row count to make up for the header row
                                modelEndRow++;
                                  
                                modelStartRow = modelEndRow;
                                modelStartRow--;
                                sheetCount++;
                                //are we done?
                                if (modelEndRow >= model.Contents.Count)
                                {
                                    complete = true;
                                }
                                
                            }
                        }
                        //delete default sheet and save to output file name specified in UI
                        xlWorkBook.Sheets["Sheet1"].Delete();
                        xlWorkBook.SaveAs(model.OutputFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        //release all resources   
                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(xlApp);
                        Marshal.ReleaseComObject(xlWorkSheet);

                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate {
                                presenter.EnableControl(true);
                                presenter.ActivateSpinner(false);
                                presenter.UpdateProgressInfo("Completed");
                            }, null);
                        }
                    });
                    writeReportExcel.Start();
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
                    SyncContext.Post(delegate {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("Completed with exception: " + ex.Message);
                    }, null);
                }
            }
        }

        private void OnCommandDisplayContent(object sender, System.EventArgs e)
        {
            IDataMigrationView view = base._view as IDataMigrationView;
            IDataMigrationModel model = base._model as IDataMigrationModel;
            IList<ContentDisplayListViewItemModel> items = model.Contents;

            if (items != null)
            {
                IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

                // lock UI
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(false);
                        presenter.ActivateSpinner(true);
                        presenter.UpdateProgressInfo("Searching...");
                    }, null);
                }

                Thread search = new Thread(() => {
                    TimerUtils util = new TimerUtils();
                    util.Start();
                    if (string.IsNullOrEmpty(model.AccessToken))
                    {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }
                    else
                    {
                        MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                        // search all owners first.
                        IList<TeamListViewItemModel> owners = SearchOwner(model, presenter);
                        model.Contents.Clear(); // clear existing contents
                        Parallel.ForEach(owners, (owner) => {
                            if (SyncContext != null) {
                                SyncContext.Post(delegate {
                                    presenter.UpdateProgressInfo(string.Format("Retrieving Owner's Content: {0}", owner.Email));
                                }, null);
                            }
                            SearchItems(service, owner, model, presenter);
                        });

                        // compute folder size.
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate {
                                presenter.UpdateProgressInfo(string.Format("Sorting Data..."));
                            }, null);
                        }
                        // sort by email then by folder path
                        model.Contents = model.Contents.OrderBy(s => s.Email).ThenBy(s => s.ItemPathDisplay).ToList();
                        ContentDisplayListViewItemModel currentFolderSelected = null;
                        foreach (ContentDisplayListViewItemModel lvItem in model.Contents)
                        {
                            if (lvItem.ItemType.ToLower().Equals("folder"))
                            {
                                if (currentFolderSelected != null)
                                { 
                                    // had previously selected folder.
                                    currentFolderSelected.ItemSize = FileUtil.FormatFileSize(currentFolderSelected.ItemSizeByte);
                                    if (SyncContext != null) {
                                        SyncContext.Post(delegate {
                                            presenter.UpdateProgressInfo(string.Format("Calculating Folder Size: {0}", currentFolderSelected.ItemName));
                                        }, null);
                                    }
                                }
                                currentFolderSelected = lvItem;
                            }
                            else if (lvItem.ItemType.ToLower().Equals("file"))
                            {
                                if (currentFolderSelected != null)
                                {
                                    currentFolderSelected.ItemSizeByte += lvItem.ItemSizeByte; 
                                }
                            }
                        }
                    }

                    if (SyncContext != null)
                    {
                        TimeSpan diff = util.Stop();

                        SyncContext.Post(delegate {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IDataMigrationView, IDataMigrationModel>(
                                ref view, model
                            );
                            view.RenderContentSearchResult();
                            view.EnableExportControl(true);
                            presenter.UpdateProgressInfo(
                                string.Format("Completed. Total Content(s) Count: {0} Elapsed Time: {1}", model.Contents.Count, TimerUtils.ToTimeStamp(diff))
                            );
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                });
                search.Start();
            }
        }

        #endregion Events
    }
}