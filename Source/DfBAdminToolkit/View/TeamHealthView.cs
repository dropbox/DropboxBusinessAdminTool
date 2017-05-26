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

    public partial class TeamHealthView : Form, ITeamHealthView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandLoadTeamHealthFolders;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public string TeamFolderName { get; set; }

        public string TeamFolderId { get; set; }

        public string TeamFoldersInputFilePath { get; set; }

        public bool SyncSetting { get; set; }

        public bool ActiveSetting { get; set; }

        public string UserEmail { get; set; }

        public enum OlvMembersIndex : int
        {
            TeamFolderName,
            TeamFolderId,
            Status
        }

        public TeamHealthView()
        {
            InitializeComponent();
            Initialize();
            InitializeOLVMembers();
            WireComponentEvents();
            this.objectListView_TeamHealthMembers.RebuildColumns();
        }

        ~TeamHealthView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.buttonEx_TeamFoldersLoadTeamFolders.Click += buttonEx_TeamFoldersLoadTeamFolders_Click;
                this.objectListView_TeamHealthMembers.ItemChecked += ObjectListView_TeamFoldersMembers_ItemChecked;
                this.objectListView_TeamHealthMembers.HeaderCheckBoxChanging += ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.buttonEx_TeamFoldersLoadTeamFolders.Click -= buttonEx_TeamFoldersLoadTeamFolders_Click;
                this.objectListView_TeamHealthMembers.ItemChecked -= ObjectListView_TeamFoldersMembers_ItemChecked;
                this.objectListView_TeamHealthMembers.HeaderCheckBoxChanging -= ObjectListView_TeamFoldersMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            this.buttonEx_TeamFoldersLoadTeamFolders.Enabled = true;
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_TeamHealthMembers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_TeamHealthMembers.UseExplorerTheme = false;
            this.objectListView_TeamHealthMembers.UseTranslucentHotItem = true;
            this.objectListView_TeamHealthMembers.FullRowSelect = false;
            this.objectListView_TeamHealthMembers.HotTracking = false;
            this.objectListView_TeamHealthMembers.HeaderToolTip.IsBalloon = false;
            this.objectListView_TeamHealthMembers.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_TeamHealthMembers.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<TeamHealthListViewItemModel> olv = new TypedObjectListView<TeamHealthListViewItemModel>(
                this.objectListView_TeamHealthMembers
            );

            olv.GetColumn((int)OlvMembersIndex.TeamFolderName).AspectGetter
                = delegate (TeamHealthListViewItemModel model)
                {
                    return (model != null) ? model.TeamFolderName : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.TeamFolderId).AspectGetter
                = delegate (TeamHealthListViewItemModel model)
                {
                    return (model != null) ? model.TeamFolderId : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.Status).AspectGetter
                = delegate (TeamHealthListViewItemModel model)
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

        private void TextBox_textBoxTeamFolder_TextChanged(object sender, EventArgs e)
        {
            TeamFolderName = this.textBoxTeamFolder.Text;
        }

        public void RenderTeamHealthList()
        {
            //this.objectListView_TeamHealthMembers.SetObjects(TeamHealth);
            if (this.objectListView_TeamHealthMembers.GetItemCount() == this.objectListView_TeamHealthMembers.CheckedObjects.Count)
            {
                this.objectListView_TeamHealthMembers.CheckHeaderCheckBox(olvColumnTeamFolders_TeamFolderName);
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
            //if (CommandGetTeamFolders != null)
            //{
            //    CommandGetTeamFolders(sender, e);
            //}
        }

        private void TextBox_TeamFoldersAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_TeamFoldersAccessToken.Text;
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

        #endregion Events
    }
}