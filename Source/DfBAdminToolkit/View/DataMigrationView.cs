namespace DfBAdminToolkit.View {

    using BrightIdeasSoftware;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    public partial class DataMigrationView
        : Form, IDataMigrationView {
        public event EventHandler DataChanged;
        public event EventHandler CommandDisplayContent;
        public event EventHandler CommandExportContent;
        public event EventHandler CommandExportContentExcel;

        public SynchronizationContext SyncContext { get; set; }
        public bool ComponentEventsWired { get; set; }
        public List<ContentDisplayListViewItemModel> Contents { get; set; }
        public string OutputFileName { get; set; }

        public enum OlvContentIndex : int {
            OwnerName,
            OwnerLogin,
            ItemPathDisplay,
            ItemPathId,
            ItemName,
            ItemId,
            ItemType,
            ItemSize,
            Created,
            LastModified,
            Uploaded
        }

        public DataMigrationView() {
            InitializeComponent();
            Initialize();
            InitializeOLVContentDisplay();
            WireComponentEvents();
        }

        ~DataMigrationView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired) {
                this.buttonEx_DataMigrationDisplayContent.Click += ButtonEx_DataMigrationDisplayContent_Click;
                this.buttonEx_DataMigrationExportReport.Click += ButtonEx_DataMigrationExportReport_Click;
                this.buttonEx_DataMigrationExportExcel.Click += ButtonEx_DataMigrationExportExcel_Click;
                this.buttonEx_DataMigrationSelectFolder.Click += ButtonEx_DataMigrationSelectFolder_Click;
                this.textBox_DataMigrationOutputPath.OnDragDropEnd += TextBox_DataMigrationOutputFolderPath_OnDragDropEnd;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents() {
            if (ComponentEventsWired) {
                this.buttonEx_DataMigrationDisplayContent.Click -= ButtonEx_DataMigrationDisplayContent_Click;
                this.buttonEx_DataMigrationExportReport.Click -= ButtonEx_DataMigrationExportReport_Click;
                this.buttonEx_DataMigrationExportExcel.Click += ButtonEx_DataMigrationExportExcel_Click;
                this.buttonEx_DataMigrationSelectFolder.Click -= ButtonEx_DataMigrationSelectFolder_Click;
                this.textBox_DataMigrationOutputPath.OnDragDropEnd -= TextBox_DataMigrationOutputFolderPath_OnDragDropEnd;
                ComponentEventsWired = false;
            }
        }

        public void Initialize() {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;

            this.tableLayoutPanel_DataMigrationExportGroup.Enabled = false;
            this.buttonEx_DataMigrationExportReport.Enabled = false;
            this.buttonEx_DataMigrationExportExcel.Enabled = false;
        }

        private void InitializeOLVContentDisplay() {
            this.fastObjectListView_DataMigrationContentDisplay.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.fastObjectListView_DataMigrationContentDisplay.UseExplorerTheme = false;
            this.fastObjectListView_DataMigrationContentDisplay.UseTranslucentHotItem = true;
            this.fastObjectListView_DataMigrationContentDisplay.FullRowSelect = true;
            this.fastObjectListView_DataMigrationContentDisplay.HotTracking = true;
            this.fastObjectListView_DataMigrationContentDisplay.ShowGroups = false;
            this.fastObjectListView_DataMigrationContentDisplay.HeaderToolTip.IsBalloon = false;
            this.fastObjectListView_DataMigrationContentDisplay.GridLines = true;
            TypedObjectListView<ContentDisplayListViewItemModel> olv = new TypedObjectListView<ContentDisplayListViewItemModel>(
                this.fastObjectListView_DataMigrationContentDisplay
            );

            olv.GetColumn((int)OlvContentIndex.OwnerName).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.OwnerName : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.OwnerLogin).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.Email : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemPathDisplay).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemPathDisplay : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemId).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemId : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemName).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemName : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemId).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemId : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemType).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemType : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.ItemSize).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.ItemSize : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.Created).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.Created : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.LastModified).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.LastModified : string.Empty;
                };

            olv.GetColumn((int)OlvContentIndex.Uploaded).AspectGetter
                = delegate (ContentDisplayListViewItemModel model) {
                    return (model != null) ? model.Uploaded : string.Empty;
                };
        }

        public void ShowView() {
            this.Show();
        }

        public void HideView() {
            this.Hide();
        }

        #region Slots

        public void RenderContentSearchResult() {
            this.fastObjectListView_DataMigrationContentDisplay.SetObjects(
                Contents
            );
        }

        public void EnableExportControl(bool enable) {
            this.tableLayoutPanel_DataMigrationExportGroup.Enabled = enable;
            this.tableLayoutPanel_DataMigrationExportGroup.Update();
        }

        public void EnableExportButton(bool enable) {
            this.buttonEx_DataMigrationExportReport.Enabled = enable;
            this.buttonEx_DataMigrationExportReport.Update();
            this.buttonEx_DataMigrationExportExcel.Enabled = enable;
            this.buttonEx_DataMigrationExportExcel.Update();
        }

        #endregion Slots

        #region Events

        private void ButtonEx_DataMigrationDisplayContent_Click(object sender, EventArgs e) {
            if (CommandDisplayContent != null) {
                CommandDisplayContent(sender, e);
            }
        }

        private void ButtonEx_DataMigrationSelectFolder_Click(object sender, EventArgs e) {
            SaveFileDialog outputFileDlg = new SaveFileDialog();
            outputFileDlg.Filter = "CSV|*.csv|Excel|*.xls";
            outputFileDlg.Title = "Please provide report file name";
            outputFileDlg.ShowDialog();
            if (!string.IsNullOrEmpty(outputFileDlg.FileName)) {
                OutputFileName = outputFileDlg.FileName;
                this.textBox_DataMigrationOutputPath.Text = OutputFileName;
                this.EnableExportButton(true);
            }
        }

        private void ButtonEx_DataMigrationExportReport_Click(object sender, EventArgs e) {
            InvokeDataChanged(sender, e);
            if (CommandExportContent != null) {
                CommandExportContent(sender, e);
            }
        }

        private void ButtonEx_DataMigrationExportExcel_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportContentExcel != null)
            {
                CommandExportContentExcel(sender, e);
            }
        }

        private void TextBox_DataMigrationOutputFolderPath_OnDragDropEnd(object sender, EventArgs e) {
            OutputFileName = this.textBox_DataMigrationOutputPath.Text;
            EnableExportControl(true);
        }

        private void InvokeDataChanged(object sender, EventArgs e) {
            if (DataChanged != null) {
                DataChanged(sender, e);
            }
        }

        #endregion Events
    }
}