namespace DfBAdminToolkit.View {

    using BrightIdeasSoftware;
    using DfBAdminToolkit.Common.DataExchange;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public partial class DumpUserContentView : Form, IDumpUserContentView {
        private bool _suppressErrorMessage = false;
        private bool _contextMenuInitialized = false;
        private ContextMenu _menu;

        public event EventHandler DataChanged;
        public event EventHandler CommandListMembers;
        public event EventHandler CommandDumpFiles;
        public event EventHandler<DataUpdatedEventArgs> CommandContextMenuClicked;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string UserAccessToken { get; set; }

        public List<TeamListViewItemModel> MemberList { get; set; }

        public string OutputFolder { get; set; }

        public string[] ContextMenuItemText { get; set; }

        public enum OlvTeamIndex : int {
            Email,
            TeamId,
            FilePath,
            FileName,
            FileSize
        }

        public DumpUserContentView() {
            InitializeComponent();
            Initialize();
            WireComponentEvents();
        }

        ~DumpUserContentView() {
            UnWireContextMenuEvent();
            UnWireComponentEvents();
        }

        #region Initialization

        public void Initialize() {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            UserAccessToken = string.Empty;
            MemberList = new List<TeamListViewItemModel>();

            textBox_DumpUserContentOutputDir.AllowDrop = true;
        }

        public void WireComponentEvents() {
            if (!ComponentEventsWired) {
                this.textBox_MemberListAccessToken.TextChanged += TextBox_MemberListAccessToken_TextChanged;
                this.buttonEx_DumpUserContentDisplayMembers.Click += Button_MemberListView_Click;
                this.textBox_DumpUserContentOutputDir.OnDragDropEnd += TextBox_DumpUserContentOutputDir_OnDragDropEnd;
                this.buttonEx_DumpUserContentSelect.Click += Button_DumpUserContentOutputDir_Click;
                this.buttonEx_DumpUserContentDump.Click += Button_DumpUserContentDump_Click;
                this.objectListView_MemberList.ItemChecked += ObjectListView_MemberList_ItemChecked;
                this.objectListView_MemberList.HeaderCheckBoxChanging += ObjectListView_MemberList_HeaderCheckBoxChanging;
                this.objectListView_MemberList.ItemCheck += ObjectListView_MemberList_ItemCheck;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents() {
            if (ComponentEventsWired) {
                this.textBox_MemberListAccessToken.TextChanged -= TextBox_MemberListAccessToken_TextChanged;
                this.buttonEx_DumpUserContentDisplayMembers.Click -= Button_MemberListView_Click;
                this.textBox_DumpUserContentOutputDir.OnDragDropEnd -= TextBox_DumpUserContentOutputDir_OnDragDropEnd;
                this.buttonEx_DumpUserContentSelect.Click -= Button_DumpUserContentOutputDir_Click;
                this.buttonEx_DumpUserContentDump.Click -= Button_DumpUserContentDump_Click;
                this.objectListView_MemberList.ItemChecked -= ObjectListView_MemberList_ItemChecked;
                this.objectListView_MemberList.HeaderCheckBoxChanging -= ObjectListView_MemberList_HeaderCheckBoxChanging;
                this.objectListView_MemberList.ItemCheck -= ObjectListView_MemberList_ItemCheck;
                ComponentEventsWired = false;
            }
        }

        private void WireUpContextMenuEvent() {
            if (!_contextMenuInitialized) {
                foreach (MenuItem item in _menu.MenuItems) {
                    item.Click += Item_Click;
                }
                _contextMenuInitialized = true;
            }
        }

        private void UnWireContextMenuEvent() {
            if (_contextMenuInitialized) {
                foreach (MenuItem item in _menu.MenuItems) {
                    item.Click -= Item_Click;
                }
                _contextMenuInitialized = false;
            }
        }

        private void InitializeOLVMembers() {
            // don't allow edit
            this.objectListView_MemberList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_MemberList.UseExplorerTheme = false;
            this.objectListView_MemberList.UseTranslucentHotItem = false;
            this.objectListView_MemberList.FullRowSelect = true;
            this.objectListView_MemberList.HotTracking = true;
            this.objectListView_MemberList.ShowGroups = false;
            this.objectListView_MemberList.HeaderToolTip.IsBalloon = false;
            this.objectListView_MemberList.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_MemberList.HotItemStyle.ForeColor = Color.MediumBlue;
            //this.objectListView_Members.HotItemStyle.Overlay = new MemberInfoOverlay();

            TypedObjectListView<TeamListViewItemModel> olv = new TypedObjectListView<TeamListViewItemModel>(
                this.objectListView_MemberList
            );

            olv.GetColumn((int)OlvTeamIndex.Email).AspectGetter
                = delegate (TeamListViewItemModel model) {
                    return (model != null) ? model.Email : string.Empty;
                };

            olv.GetColumn((int)OlvTeamIndex.TeamId).AspectGetter
                = delegate (TeamListViewItemModel model) {
                    return (model != null) ? model.TeamId : string.Empty;
                };

            olv.GetColumn((int)OlvTeamIndex.FilePath).AspectGetter
                = delegate (TeamListViewItemModel model) {
                    return (model != null) ? model.FilePath : string.Empty;
                };

            olv.GetColumn((int)OlvTeamIndex.FileName).AspectGetter
                = delegate (TeamListViewItemModel model) {
                    return (model != null) ? model.FileName : string.Empty;
                };

            olv.GetColumn((int)OlvTeamIndex.FileSize).AspectGetter
                = delegate (TeamListViewItemModel model) {
                    return (model != null) ? model.FileSize : string.Empty;
                };
        }

        #endregion Initialization

        public void ShowView() {
            this.Show();
        }

        public void HideView() {
            this.Hide();
        }

        #region Slots

        public void EnableContextMenuItems(bool enable) {
            foreach (MenuItem item in _menu.MenuItems) {
                item.Enabled = enable;
            }
        }

        public void RenderMembersSearchResult() {
            this.objectListView_MemberList.SetObjects(
                MemberList
            );
            // disable row if file doesn't exist
            foreach (Object item in this.objectListView_MemberList.Objects) {
                TeamListViewItemModel model = item as TeamListViewItemModel;
                if (model != null) {
                    if (string.IsNullOrEmpty(model.FileName)) {
                        // force disable row.
                        //this.objectListView_MemberList.DisableObject(item);
                    }
                }
            }

            if (this.objectListView_MemberList.GetItemCount() == this.objectListView_MemberList.CheckedObjects.Count) {
                this.objectListView_MemberList.CheckHeaderCheckBox(olvColumnContent_Email);
            }
        }

        public void RenderMembersFileSearchResult()
        {
            this.objectListView_MemberList.SetObjects(
                MemberList
            );
            foreach (Object item in this.objectListView_MemberList.Objects)
            {
                TeamListViewItemModel model = item as TeamListViewItemModel;
                if (model != null)
                {
                    if (string.IsNullOrEmpty(model.FileName))
                    {
                        // remove all excpet the files that were located under that users group
                        this.objectListView_MemberList.RemoveObject(item);
                    }
                }
            }

            if (this.objectListView_MemberList.GetItemCount() == this.objectListView_MemberList.CheckedObjects.Count)
            {
                this.objectListView_MemberList.CheckHeaderCheckBox(olvColumnContent_Email);
            }
        }

        public void EnableDumpControl(bool enable) {
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Enabled = enable;
            this.tableLayoutPanel_DumpUserContentFileCommandGroup.Update();
        }

        public void EnableDumpButton(bool enable) {
            this.buttonEx_DumpUserContentDump.Enabled = enable;
            this.buttonEx_DumpUserContentDump.Update();
        }

        public void RefreshAccessToken() {
            this.textBox_MemberListAccessToken.Text = this.UserAccessToken;
        }

        public void SetContextMenuItemText(string[] menuItemsText) {
            ContextMenuItemText = menuItemsText;
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col) {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_MemberList_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_MemberList_HeaderCheckBoxChanging;
        }

        public void ShowGroups(bool show) {
            this.objectListView_MemberList.ShowGroups = show;
            this.objectListView_MemberList.Refresh();
        }

        public void LazyInitializeContextMenu() {
            // bind context menu to OLV
            // has to be run after OLV is initialized
            if (!_contextMenuInitialized) {
                _menu = new ContextMenu();
                foreach (string text in ContextMenuItemText) {
                    _menu.MenuItems.Add(new MenuItem(text));
                }
                this.objectListView_MemberList.ContextMenu = _menu;
                WireUpContextMenuEvent();
                _contextMenuInitialized = true;
            }
        }

        #endregion Slots

        #region Events

        private void Item_Click(object sender, EventArgs e) {
            UnWireContextMenuEvent();
            if (CommandContextMenuClicked != null) {
                CommandContextMenuClicked(sender, new DataUpdatedEventArgs(
                    this.objectListView_MemberList.SelectedObjects)
                );
            }
            WireUpContextMenuEvent();
        }

        private void Button_MemberListView_Click(object sender, EventArgs e) {
            InvokeDataChanged(sender, e);
            if (CommandListMembers != null) {
                CommandListMembers(sender, e);
            }
        }

        private void TextBox_MemberListAccessToken_TextChanged(object sender, EventArgs e) {
            UserAccessToken = this.textBox_MemberListAccessToken.Text;
        }

        private void TextBox_DumpUserContentOutputDir_OnDragDropEnd(object sender, EventArgs e) {
            OutputFolder = this.textBox_DumpUserContentOutputDir.Text;
            this.EnableDumpButton(true);
        }

        private void Button_DumpUserContentDump_Click(object sender, EventArgs e) {
            InvokeDataChanged(sender, e);
            if (CommandDumpFiles != null) {
                CommandDumpFiles(sender, e);
            }
        }

        private void Button_DumpUserContentOutputDir_Click(object sender, EventArgs e) {
            FolderBrowserDialog outputFolderDlg = new FolderBrowserDialog();
            outputFolderDlg.Description = "Please select an output folder";
            outputFolderDlg.ShowNewFolderButton = true;
            DialogResult result = outputFolderDlg.ShowDialog();

            if (result == DialogResult.OK) {
                textBox_DumpUserContentOutputDir.Text = outputFolderDlg.SelectedPath;
                OutputFolder = outputFolderDlg.SelectedPath;
                this.EnableDumpButton(true);
            }
        }

        private void ObjectListView_MemberList_ItemCheck(object sender, ItemCheckEventArgs e) {
            // first of all, if user tries to check mark item which files were NOT loaded yet,
            // show warning and don't allow user to check mark
            ObjectListView olv = sender as ObjectListView;
            TeamListViewItemModel item = olv.GetModelObject(e.Index) as TeamListViewItemModel;
            if (item != null) {
                if (string.IsNullOrEmpty(item.FileName)) {
                    if (!_suppressErrorMessage) {
                        MessageBoxUtil.ShowError(this, ErrorMessages.MISSING_FILES);
                    }
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }

        private void ObjectListView_MemberList_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ObjectListView olv = sender as ObjectListView;

            if (olv.GetItemCount() == olv.CheckedObjects.Count) {
                olv.CheckHeaderCheckBox(olvColumnContent_Email);
            } else {
                UncheckHeaderCheckbox(olv, olvColumnContent_Email);
            }
        }

        private void ObjectListView_MemberList_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e) {
            ObjectListView olv = sender as ObjectListView;
            CheckState newState = e.NewCheckState;
            if (newState == CheckState.Checked) {
                // suppress message box
                _suppressErrorMessage = true;
                if (olv.Objects != null) {
                    olv.CheckAll();
                }
                _suppressErrorMessage = false;
            } else if (newState == CheckState.Unchecked) {
                if (olv.Objects != null && olv.CheckedObjects.Count > 0) {
                    olv.UncheckAll();
                }
            }
        }

        private void InvokeDataChanged(object sender, EventArgs e) {
            if (DataChanged != null) {
                DataChanged(sender, e);
            }
        }

        #endregion Events
    }
}