namespace DfBAdminToolkit.View
{
    using BrightIdeasSoftware;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public partial class PaperView : Form, IPaperView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandGetPaper;
        public event EventHandler CommandDeletePaper;
        public event EventHandler CommandDownloadPaper;
        public event EventHandler CommandExportToCSV;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public string PaperName { get; set; }

        public string PaperId { get; set; }

        public bool ArchiveSetting { get; set; }

        public bool PermanentSetting { get; set; }

        public string UserEmail { get; set; }

        public string OutputFolder { get; set; }

        public List<PaperListViewItemModel> Paper { get; set; }

        public enum OlvMembersIndex : int
        {
            PaperName,
            PaperId,
            FolderPath,
            Status,
            Owner,
            CreatedDate,
            LastUpdatedDate,
            LastEditor,
            Revision
        }

        public PaperView()
        {
            InitializeComponent();
            Initialize();
            InitializeOLVMembers();
            WireComponentEvents();
            this.objectListView_PaperMembers.RebuildColumns();
        }

        ~PaperView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.textBox_PaperAccessToken.TextChanged += TextBox_PaperAccessToken_TextChanged;
                this.buttonEx_PaperLoadPaper.Click += buttonEx_PaperLoadPaper_Click;
                this.buttonEx_PaperDownload.Click += buttonEx_PaperDownload_Click;
                this.buttonEx_PaperDelete.Click += buttonEx_PaperDelete_Click;
                this.buttonEx_PaperDownloadFolder.Click += buttonEx_PaperDownloadFolder_Click;
                this.buttonEx_ExportToCSV.Click += buttonEx_ExportToCSV_Click;
                this.radioButton_Archive.CheckedChanged += radioButton_Archive_CheckedChanged;
                this.radioButton_Permanent.CheckedChanged += radioButton_Permanent_CheckedChanged;
                this.textBoxPaper.TextChanged += TextBox_textBoxPaper_TextChanged;
                this.objectListView_PaperMembers.ItemChecked += ObjectListView_PaperMembers_ItemChecked;
                this.objectListView_PaperMembers.HeaderCheckBoxChanging += ObjectListView_PaperMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.textBox_PaperAccessToken.TextChanged -= TextBox_PaperAccessToken_TextChanged;
                this.buttonEx_PaperLoadPaper.Click -= buttonEx_PaperLoadPaper_Click;
                this.buttonEx_PaperDownload.Click -= buttonEx_PaperDownload_Click;
                this.buttonEx_PaperDelete.Click -= buttonEx_PaperDelete_Click;
                this.buttonEx_PaperDownloadFolder.Click -= buttonEx_PaperDownloadFolder_Click;
                this.radioButton_Archive.CheckedChanged -= radioButton_Archive_CheckedChanged;
                this.radioButton_Permanent.CheckedChanged -= radioButton_Permanent_CheckedChanged;
                this.textBoxPaper.TextChanged -= TextBox_textBoxPaper_TextChanged;
                this.objectListView_PaperMembers.ItemChecked -= ObjectListView_PaperMembers_ItemChecked;
                this.objectListView_PaperMembers.HeaderCheckBoxChanging -= ObjectListView_PaperMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            Paper = new List<PaperListViewItemModel>();
            this.buttonEx_PaperLoadPaper.Enabled = true;
            this.buttonEx_PaperDownload.Enabled = false;
            this.textBoxPaper.Enabled = false;
            this.buttonEx_ExportToCSV.Enabled = false;
            this.buttonEx_PaperDelete.Enabled = false;

            //set default for radio buttons
            this.radioButton_Archive.Checked = true;
            this.radioButton_Archive.Enabled = false;
            this.radioButton_Permanent.Enabled = false;
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_PaperMembers.CellEditActivation = ObjectListView.CellEditActivateMode.None;
            this.objectListView_PaperMembers.UseExplorerTheme = false;
            this.objectListView_PaperMembers.UseTranslucentHotItem = true;
            this.objectListView_PaperMembers.FullRowSelect = false;
            this.objectListView_PaperMembers.HotTracking = false;
            this.objectListView_PaperMembers.HeaderToolTip.IsBalloon = false;
            this.objectListView_PaperMembers.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_PaperMembers.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<PaperListViewItemModel> olv = new TypedObjectListView<PaperListViewItemModel>(
                this.objectListView_PaperMembers
            );

            olv.GetColumn((int)OlvMembersIndex.PaperName).AspectGetter
                = delegate (PaperListViewItemModel model)
                {
                    return (model != null) ? model.PaperName : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.PaperId).AspectGetter
                = delegate (PaperListViewItemModel model)
                {
                    return (model != null) ? model.PaperId : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.FolderPath).AspectGetter
                = delegate (PaperListViewItemModel model)
                {
                    return (model != null) ? model.FolderPath : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.Status).AspectGetter
                = delegate (PaperListViewItemModel model)
                {
                    return (model != null) ? model.Status : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.Owner).AspectGetter
               = delegate (PaperListViewItemModel model)
               {
                   return (model != null) ? model.Owner : string.Empty;
               };
            olv.GetColumn((int)OlvMembersIndex.CreatedDate).AspectGetter
               = delegate (PaperListViewItemModel model)
               {
                   return (model != null) ? model.CreatedDate : DateTime.Now;
               };
            olv.GetColumn((int)OlvMembersIndex.LastUpdatedDate).AspectGetter
               = delegate (PaperListViewItemModel model)
               {
                   return (model != null) ? model.LastUpdatedDate : DateTime.Now;
               };
            olv.GetColumn((int)OlvMembersIndex.LastEditor).AspectGetter
               = delegate (PaperListViewItemModel model)
               {
                   return (model != null) ? model.LastEditor : string.Empty;
               };
            olv.GetColumn((int)OlvMembersIndex.Revision).AspectGetter
               = delegate (PaperListViewItemModel model)
               {
                   return (model != null) ? model.Revision : 0;
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
            textBox_PaperAccessToken.Text = AccessToken;
        }

        public void EnableDownloadButton(bool enable)
        {
            this.buttonEx_PaperDownload.Enabled = enable;
            this.buttonEx_PaperDownload.Update();
        }

        private void TextBox_textBoxPaper_TextChanged(object sender, EventArgs e)
        {
            PaperName = this.textBoxPaper.Text;
        }

        public void RenderPaperList()
        {
            this.objectListView_PaperMembers.SetObjects(Paper);
            if (this.objectListView_PaperMembers.GetItemCount() == this.objectListView_PaperMembers.CheckedObjects.Count)
            {
                this.objectListView_PaperMembers.CheckHeaderCheckBox(olvColumnPaper_PaperName);
            }
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
        {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_PaperMembers_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_PaperMembers_HeaderCheckBoxChanging;
        }

        #endregion Slots

        #region Events

        private void buttonEx_PaperLoadPaper_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandGetPaper != null)
            {
                CommandGetPaper(sender, e);
            }
            this.buttonEx_ExportToCSV.Enabled = true;
            this.buttonEx_PaperDelete.Enabled = true;
            this.radioButton_Archive.Enabled = true;
            this.radioButton_Permanent.Enabled = true;
        }

        private void buttonEx_PaperDelete_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandDeletePaper != null)
            {
                CommandDeletePaper(sender, e);
            }
        }

        private void buttonEx_PaperDownload_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandDownloadPaper != null)
            {
                CommandDownloadPaper(sender, e);
            }
        }

        private void buttonEx_PaperDownloadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputFolderDlg = new FolderBrowserDialog();
            outputFolderDlg.Description = "Please select an output folder";
            outputFolderDlg.ShowNewFolderButton = true;
            DialogResult result = outputFolderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxPaper.Text = outputFolderDlg.SelectedPath;
                OutputFolder = outputFolderDlg.SelectedPath;
                this.EnableDownloadButton(true);
                this.textBoxPaper.Enabled = true;
            }
        }

        private void buttonEx_ExportToCSV_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportToCSV != null)
            {
                CommandExportToCSV(sender, e);
            }
        }

        private void TextBox_PaperAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_PaperAccessToken.Text;
        }

        private void radioButton_Archive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Archive.Checked == true)
            {
                ArchiveSetting = true;
            }
            else
            {
                ArchiveSetting = false;
            }
        }

        private void radioButton_Permanent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Permanent.Checked == true)
            {
                PermanentSetting = true;
            }
            else
            {
                PermanentSetting = false;
            }
        }

        private void ObjectListView_PaperMembers_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
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

        private void ObjectListView_PaperMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            if (olv.GetItemCount() == olv.CheckedObjects.Count)
            {
                olv.CheckHeaderCheckBox(olvColumnPaper_PaperName);
            }
            else
            {
                UncheckHeaderCheckbox(olv, olvColumnPaper_PaperName);
            }
        }

        private void InvokeDataChanged(object sender, EventArgs e)
        {
            if (DataChanged != null)
            {
                DataChanged(sender, e);
            }
        }

        public PaperModel GetPaperIds()
        {
            PaperModel objectModel = new PaperModel();
            foreach (var selectedObject in objectListView_PaperMembers.Objects)
            {
                if (((PaperListViewItemModel)selectedObject).IsChecked)
                {
                    string paperName = ((PaperListViewItemModel)selectedObject).PaperName;
                    string paperId = ((PaperListViewItemModel)selectedObject).PaperId;

                    // update model
                    PaperListViewItemModel lvItem = new PaperListViewItemModel()
                    {
                        PaperName = paperName,
                        PaperId = paperId
                    };
                    objectModel.Paper.Add(lvItem);
                }
            }
            return objectModel;
        }

        #endregion Events

        private void legacyWarningLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/lp/developers/reference/paper-migration-guide");
        }
    }
}