namespace DfBAdminToolkit.View
{
    using BrightIdeasSoftware;
    using Model;
    using DfBAdminToolkit.Common.Utils;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class TeamFoldersView : Form, ITeamFoldersView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandGetTeamFolders;
        public event EventHandler CommandCreateTeamFolder;
        public event EventHandler CommandSetFolderStatus;
        public event EventHandler CommandSetFolderSyncSetting;
        public event EventHandler CommandLoadTeamFolders;
        public event EventHandler CommandExportTeamFolders;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public string TeamFolderName { get; set; }

        public string TeamFolderId { get; set; }

        public string TeamFoldersInputFilePath { get; set; }

        public bool SyncSetting { get; set; }

        public bool ActiveSetting { get; set; }

        public string UserEmail { get; set; }

        public List<TeamFoldersListViewItemModel> TeamFolders { get; set; }

        public enum OlvMembersIndex : int
        {
            TeamFolderName,
            //DefaultSyncSetting,
            TeamFolderId,
            Status
        }

        public TeamFoldersView()
        {
            InitializeComponent();
            Initialize();
            InitializeOLVMembers();
            WireComponentEvents();
            this.objectListView_TeamFoldersMembers.RebuildColumns();
        }

        ~TeamFoldersView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.textBox_TeamFoldersAccessToken.TextChanged += TextBox_TeamFoldersAccessToken_TextChanged;
                this.buttonEx_TeamFoldersLoadTeamFolders.Click += buttonEx_TeamFoldersLoadTeamFolders_Click;
                this.buttonEx_TeamFoldersCreateTeamFolder.Click += buttonEx_TeamFoldersCreateTeamFolder_Click;
                this.buttonEx_TeamFoldersSetFolderStatus.Click += buttonEx_TeamFoldersSetFolderStatus_Click;
                this.buttonEx_TeamFoldersSetFolderSyncSetting.Click += buttonEx_TeamFoldersSetFolderSyncSetting_Click;
                this.buttonEx_TeamFoldersExportToCSV.Click += buttonEx_TeamFoldersExportToCSV_Click;
                this.buttonEx_TeamFoldersLoadFromCSV.Click += buttonEx_TeamFoldersLoadFromCSV_Click;
                this.radioButtonSync.CheckedChanged += radioButtonSync_CheckedChanged;
                this.radioButton_Active.CheckedChanged += radioButtonActive_CheckedChanged;
                this.textBoxTeamFolder.TextChanged += TextBox_textBoxTeamFolder_TextChanged;
                this.objectListView_TeamFoldersMembers.ItemChecked += ObjectListView_TeamFoldersMembers_ItemChecked;
                this.objectListView_TeamFoldersMembers.HeaderCheckBoxChanging += ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.textBox_TeamFoldersAccessToken.TextChanged -= TextBox_TeamFoldersAccessToken_TextChanged;
                this.buttonEx_TeamFoldersLoadTeamFolders.Click -= buttonEx_TeamFoldersLoadTeamFolders_Click;
                this.buttonEx_TeamFoldersCreateTeamFolder.Click -= buttonEx_TeamFoldersCreateTeamFolder_Click;
                this.buttonEx_TeamFoldersSetFolderStatus.Click -= buttonEx_TeamFoldersSetFolderStatus_Click;
                this.buttonEx_TeamFoldersSetFolderSyncSetting.Click -= buttonEx_TeamFoldersSetFolderSyncSetting_Click;
                this.buttonEx_TeamFoldersExportToCSV.Click -= buttonEx_TeamFoldersExportToCSV_Click;
                this.buttonEx_TeamFoldersLoadFromCSV.Click -= buttonEx_TeamFoldersLoadFromCSV_Click;
                this.radioButtonSync.CheckedChanged -= radioButtonSync_CheckedChanged;
                this.radioButton_Active.CheckedChanged -= radioButtonActive_CheckedChanged;
                this.textBoxTeamFolder.TextChanged -= TextBox_textBoxTeamFolder_TextChanged;
                this.objectListView_TeamFoldersMembers.ItemChecked -= ObjectListView_TeamFoldersMembers_ItemChecked;
                this.objectListView_TeamFoldersMembers.HeaderCheckBoxChanging -= ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            TeamFolders = new List<TeamFoldersListViewItemModel>();
            this.buttonEx_TeamFoldersLoadTeamFolders.Enabled = true;

            //set default for radio buttons
            this.radioButtonSync.Checked = true;
            this.radioButton_Active.Checked = true;
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_TeamFoldersMembers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_TeamFoldersMembers.UseExplorerTheme = false;
            this.objectListView_TeamFoldersMembers.UseTranslucentHotItem = true;
            this.objectListView_TeamFoldersMembers.FullRowSelect = false;
            this.objectListView_TeamFoldersMembers.HotTracking = false;
            this.objectListView_TeamFoldersMembers.HeaderToolTip.IsBalloon = false;
            this.objectListView_TeamFoldersMembers.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_TeamFoldersMembers.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<TeamFoldersListViewItemModel> olv = new TypedObjectListView<TeamFoldersListViewItemModel>(
                this.objectListView_TeamFoldersMembers
            );

            olv.GetColumn((int)OlvMembersIndex.TeamFolderName).AspectGetter
                = delegate (TeamFoldersListViewItemModel model)
                {
                    return (model != null) ? model.TeamFolderName : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.TeamFolderId).AspectGetter
                = delegate (TeamFoldersListViewItemModel model)
                {
                    return (model != null) ? model.TeamFolderId : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.Status).AspectGetter
                = delegate (TeamFoldersListViewItemModel model)
                {
                    return (model != null) ? model.Status : string.Empty;
                };
        }

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        #region Slots

        public void RefreshAccessToken()
        {
            textBox_TeamFoldersAccessToken.Text = AccessToken;
        }

        public bool MultiTeamFoldersCreateCheck()
        {
            bool check = false;

            if ((textBoxTeamFolder.Text).Contains(".csv"))
            {
                check = true;
            }
            return check;
        }

        private void TextBox_textBoxTeamFolder_TextChanged(object sender, EventArgs e)
        {
            TeamFolderName = this.textBoxTeamFolder.Text;
        }

        public void RenderTeamFoldersList()
        {
            this.objectListView_TeamFoldersMembers.SetObjects(TeamFolders);
            if (this.objectListView_TeamFoldersMembers.GetItemCount() == this.objectListView_TeamFoldersMembers.CheckedObjects.Count)
            {
                this.objectListView_TeamFoldersMembers.CheckHeaderCheckBox(olvColumnTeamFolders_TeamFolderName);
            }
        }

        public void RenderTeamFoldersListFromCSV(List<TeamFoldersListViewItemModel> teamFolders)
        {
            this.objectListView_TeamFoldersMembers.SetObjects(teamFolders);
            if (this.objectListView_TeamFoldersMembers.GetItemCount() == this.objectListView_TeamFoldersMembers.CheckedObjects.Count)
            {
                this.objectListView_TeamFoldersMembers.CheckHeaderCheckBox(olvColumnTeamFolders_TeamFolderName);
            }
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
        {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
        }

        #endregion Slots

        #region Events

        private void buttonEx_TeamFoldersLoadTeamFolders_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandGetTeamFolders != null)
            {
                CommandGetTeamFolders(sender, e);
            }
        }

        private void buttonEx_TeamFoldersCreateTeamFolder_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandCreateTeamFolder != null)
            {
                CommandCreateTeamFolder(sender, e);
            }
        }

        private void buttonEx_TeamFoldersSetFolderStatus_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandSetFolderStatus != null)
            {
                CommandSetFolderStatus(sender, e);
            }
        }

        private void buttonEx_TeamFoldersSetFolderSyncSetting_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandSetFolderStatus != null)
            {
                CommandSetFolderSyncSetting(sender, e);
            }
        }

        private void buttonEx_TeamFoldersExportToCSV_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportTeamFolders != null)
            {
                CommandExportTeamFolders(sender, e);
            }
        }

        private void buttonEx_TeamFoldersLoadFromCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFile = new OpenFileDialog();
            inputFile.Title = "Please select a CSV file";
            inputFile.Filter = "CSV File|*.csv";
            DialogResult result = inputFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                olvColumnTeamFolders_TeamFolderName.IsVisible = true;
                olvColumnTeamFolders_TeamFolderId.IsVisible = true;
                olvColumnTeamFolders_Status.IsVisible = true;
                this.objectListView_TeamFoldersMembers.RebuildColumns();

                textBoxTeamFolder.Text = inputFile.FileName;
                TeamFoldersInputFilePath = inputFile.FileName;
                InvokeDataChanged(sender, e);

                if (CommandLoadTeamFolders != null)
                {
                    CommandLoadTeamFolders(sender, e);
                }
            }

            InvokeDataChanged(sender, e);
            if (CommandLoadTeamFolders != null)
            {
                CommandLoadTeamFolders(sender, e);
            }
        }

        private void TextBox_TeamFoldersAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_TeamFoldersAccessToken.Text;
        }

        private void radioButtonSync_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSync.Checked == true)
            {
                SyncSetting = true;
            }
            else
            {
                SyncSetting = false;
            }
        }

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Active.Checked == true)
            {
                ActiveSetting = true;
            }
            else
            {
                ActiveSetting = false;
            }
        }

        private void ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            CheckState newState = e.NewCheckState;
            if (newState == CheckState.Checked)
            {
                olv.CheckAll();
            }
            else if (newState == CheckState.Unchecked)
            {
                olv.UncheckAll();
            }
        }

        private void ObjectListView_TeamFoldersMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            if (olv.GetItemCount() == olv.CheckedObjects.Count)
            {
                olv.CheckHeaderCheckBox(olvColumnTeamFolders_TeamFolderName);
            }
            else
            {
                UncheckHeaderCheckbox(olv, olvColumnTeamFolders_TeamFolderName);
            }
        }

        private void InvokeDataChanged(object sender, EventArgs e)
        {
            if (DataChanged != null)
            {
                DataChanged(sender, e);
            }
        }

        public TeamFoldersModel GetTeamFolderIds()
        {
            TeamFoldersModel objectModel = new TeamFoldersModel();
            foreach (var selectedObject in objectListView_TeamFoldersMembers.Objects)
            {
                if (((TeamFoldersListViewItemModel)selectedObject).IsChecked)
                {
                    string teamFolderName = ((TeamFoldersListViewItemModel)selectedObject).TeamFolderName;
                    string teamFolderId = ((TeamFoldersListViewItemModel)selectedObject).TeamFolderId;

                    // update model
                    TeamFoldersListViewItemModel lvItem = new TeamFoldersListViewItemModel()
                    {
                        TeamFolderName = teamFolderName,
                        TeamFolderId = teamFolderId
                    };
                    objectModel.TeamFolders.Add(lvItem);
                }
            }
            return objectModel;
        }

        #endregion Events
    }
}