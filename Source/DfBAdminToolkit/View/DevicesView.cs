namespace DfBAdminToolkit.View
{

    using BrightIdeasSoftware;
    using DfBAdminToolkit.Common.DataExchange;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public partial class DevicesView : Form, IDevicesView
    {
        private bool _suppressErrorMessage = false;

        public event EventHandler DataChanged;
        public event EventHandler CommandGetDevices;
        public event EventHandler CommandDumpDevices;
        public event EventHandler CommandExportDevices;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string UserAccessToken { get; set; }

        public string Filter { get; set; }

        public string FilterType { get; set; }

        public string FilterCriteria { get; set; }

        public string OutputFileName { get; set; }

        public bool RemoteWipe { get; set; }

        public List<DeviceListViewItemModel> DeviceList { get; set; }

        public enum OlvDeviceIndex : int
        {   
            Email,
            TeamId,
            DeviceName,
            IpAddress,
            ClientType,
            Created,
            Updated,
            SessionId   
        }

        public DevicesView()
        {
            InitializeComponent();
            Initialize();
            WireComponentEvents();
            this.radioIpAddress.Checked = true;
            this.comboFilterCriteria.Text = "CONTAINS";
            this.buttonEx_ExportDevices.Enabled = false;
        }

        ~DevicesView()
        {
            UnWireComponentEvents();
        }

        #region Initialization

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            UserAccessToken = string.Empty;
            DeviceList = new List<DeviceListViewItemModel>();
            checkBoxRemoteWipe.Checked = false;
            RemoteWipe = false;
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.textBoxDeviceFilter.TextChanged += textBoxDeviceFilter_TextChanged;
                this.radioIpAddress.CheckedChanged += radioIpAddress_CheckedChanged;
                this.radioDeviceFilter.CheckedChanged += radioDeviceFilter_CheckedChanged;
                this.checkBoxRemoteWipe.CheckedChanged += checkBoxRemoteWipe_CheckedChanged;
                this.comboFilterCriteria.TextChanged += comboFilterCriteria_TextChanged;
                this.buttonEx_DevicesDump.Click += Button_DevicesDump_Click;
                this.buttonLoadDevices.Click += Button_DevicesList_Click;
                this.buttonEx_ExportDevices.Click += ButtonEx_ExportDevices_Click;
                this.buttonEx_DevicesSelectFolder.Click += ButtonEx_DevicesSelectFolder_Click;
                this.objectListView_DeviceList.ItemChecked += ObjectListView_DeviceList_ItemChecked;
                this.objectListView_DeviceList.HeaderCheckBoxChanging += ObjectListView_DeviceList_HeaderCheckBoxChanging;
                this.objectListView_DeviceList.ItemCheck += ObjectListView_DeviceList_ItemCheck;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.textBoxDeviceFilter.TextChanged -= textBoxDeviceFilter_TextChanged;
                this.radioIpAddress.CheckedChanged -= radioIpAddress_CheckedChanged;
                this.radioDeviceFilter.CheckedChanged -= radioDeviceFilter_CheckedChanged;
                this.checkBoxRemoteWipe.CheckedChanged -= checkBoxRemoteWipe_CheckedChanged;
                this.comboFilterCriteria.TextChanged -= comboFilterCriteria_TextChanged;
                this.buttonEx_DevicesDump.Click -= Button_DevicesDump_Click;
                this.buttonLoadDevices.Click -= Button_DevicesList_Click;
                this.buttonEx_ExportDevices.Click -= ButtonEx_ExportDevices_Click;
                this.buttonEx_DevicesSelectFolder.Click -= ButtonEx_DevicesSelectFolder_Click;
                this.objectListView_DeviceList.ItemChecked -= ObjectListView_DeviceList_ItemChecked;
                this.objectListView_DeviceList.HeaderCheckBoxChanging -= ObjectListView_DeviceList_HeaderCheckBoxChanging;
                this.objectListView_DeviceList.ItemCheck -= ObjectListView_DeviceList_ItemCheck;
                ComponentEventsWired = false;
            }
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_DeviceList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_DeviceList.UseExplorerTheme = false;
            this.objectListView_DeviceList.UseTranslucentHotItem = false;
            this.objectListView_DeviceList.FullRowSelect = true;
            this.objectListView_DeviceList.HotTracking = true;
            this.objectListView_DeviceList.ShowGroups = false;
            this.objectListView_DeviceList.HeaderToolTip.IsBalloon = false;
            this.objectListView_DeviceList.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_DeviceList.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<DeviceListViewItemModel> olv = new TypedObjectListView<DeviceListViewItemModel>(
                this.objectListView_DeviceList
            );

            olv.GetColumn((int)OlvDeviceIndex.Created).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.Created : System.DateTime.MinValue;
                };

            olv.GetColumn((int)OlvDeviceIndex.Updated).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.Updated : System.DateTime.MinValue;
                };

            olv.GetColumn((int)OlvDeviceIndex.Email).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.Email : string.Empty;
                };

            olv.GetColumn((int)OlvDeviceIndex.TeamId).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.TeamId : string.Empty;
                };

            olv.GetColumn((int)OlvDeviceIndex.DeviceName).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.DeviceName : string.Empty;
                };

            olv.GetColumn((int)OlvDeviceIndex.IpAddress).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.IpAddress : string.Empty;
                };

            olv.GetColumn((int)OlvDeviceIndex.SessionId).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.SessionId : string.Empty;
                };

            olv.GetColumn((int)OlvDeviceIndex.ClientType).AspectGetter
                = delegate (DeviceListViewItemModel model) {
                    return (model != null) ? model.ClientType : string.Empty;
                };
        }

        #endregion Initialization

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        #region Slots

        public void RenderDeviceSearchResult()
        {
            this.objectListView_DeviceList.SetObjects(
                DeviceList
            );
            // disable row if device name doesn't exist
            foreach (Object item in this.objectListView_DeviceList.Objects)
            {
                DeviceListViewItemModel model = item as DeviceListViewItemModel;
                if (model != null)
                {
                    if (string.IsNullOrEmpty(model.DeviceName))
                    {
                        // force disable row.
                        this.objectListView_DeviceList.DisableObject(item);
                    }
                }
            }

            if (this.objectListView_DeviceList.GetItemCount() == this.objectListView_DeviceList.CheckedObjects.Count)
            {
                this.objectListView_DeviceList.CheckHeaderCheckBox(olvColumnContent_TeamId);
            }
        }

        public void EnableDeviceControl(bool enable)
        {
            this.tableLayoutPanel_DevicesFileCommandGroup.Enabled = enable;
            this.tableLayoutPanel_DevicesFileCommandGroup.Update();
        }

        public void EnableDeviceButton(bool enable)
        {
            this.buttonEx_DevicesDump.Enabled = true;
            this.buttonEx_DevicesDump.Update();
        }

        public void RefreshAccessToken()
        {
            this.textBox_DeviceListAccessToken.Text = this.UserAccessToken;
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
        {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_DeviceList_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_DeviceList_HeaderCheckBoxChanging;
        }

        public void EnableExportButton(bool enable)
        {
            this.buttonEx_ExportDevices.Enabled = enable;
            this.buttonEx_ExportDevices.Update();
        }

        public void ShowGroups(bool show)
        {
            this.objectListView_DeviceList.ShowGroups = show;
            this.objectListView_DeviceList.Refresh();
        }

        #endregion Slots

        #region Events

        private void Button_DevicesList_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandGetDevices != null)
            {
                CommandGetDevices(sender, e);
            }
        }

        private void ButtonEx_ExportDevices_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportDevices != null)
            {
                CommandExportDevices(sender, e);
            }
        }

        private void ButtonEx_DevicesSelectFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog outputFileDlg = new SaveFileDialog();
            outputFileDlg.Filter = "CSV|*.csv|Excel|*.xls";
            outputFileDlg.Title = "Please provide CSV file name";
            outputFileDlg.ShowDialog();
            if (!string.IsNullOrEmpty(outputFileDlg.FileName))
            {
                OutputFileName = outputFileDlg.FileName;
                this.textBox_DevicesOutputPath.Text = OutputFileName;
                this.EnableExportButton(true);
            }
        }

        private void TextBox_MemberListAccessToken_TextChanged(object sender, EventArgs e)
        {
            UserAccessToken = this.textBox_DeviceListAccessToken.Text;
        }

        private void textBoxDeviceFilter_TextChanged(object sender, EventArgs e)
        {
            Filter = this.textBoxDeviceFilter.Text;
            FilterCriteria = this.comboFilterCriteria.Text;
            if (radioIpAddress.Checked == true)
            {
                FilterType = "IpAddress";
            }
            if (radioDeviceFilter.Checked == true)
            {
                FilterType = "DeviceName";
            }
        }

        private void radioIpAddress_CheckedChanged(object sender, EventArgs e)
        {
            Filter = this.textBoxDeviceFilter.Text;
            FilterCriteria = this.comboFilterCriteria.Text;
            if (radioIpAddress.Checked == true)
            {
                FilterType = "IpAddress";
            }
            else
            {
                FilterType = "DeviceName";
            }     
        }

        private void radioDeviceFilter_CheckedChanged(object sender, EventArgs e)
        {
            Filter = this.textBoxDeviceFilter.Text;
            FilterCriteria = this.comboFilterCriteria.Text;
            if (radioDeviceFilter.Checked == true)
            {
                FilterType = "DeviceName";
            }
            else
            {
                FilterType = "IpAddress";
            }
        }

        private void checkBoxRemoteWipe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemoteWipe.Checked == true)
            {
                RemoteWipe = true;
            }
            if (checkBoxRemoteWipe.Checked == false)
            {
                RemoteWipe = false;
            }
        }

        private void comboFilterCriteria_TextChanged(object sender, EventArgs e)
        {
            FilterCriteria = this.comboFilterCriteria.Text;
        }

        private void Button_DevicesDump_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandDumpDevices != null)
            {
                CommandDumpDevices(sender, e);
            }
        }

        private void ObjectListView_DeviceList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // first of all, if user tries to check mark item which files were NOT loaded yet,
            // show warning and don't allow user to check mark
            ObjectListView olv = sender as ObjectListView;
            DeviceListViewItemModel item = olv.GetModelObject(e.Index) as DeviceListViewItemModel;
            if (item != null)
            {
                if (string.IsNullOrEmpty(item.DeviceName))
                {
                    if (!_suppressErrorMessage)
                    {
                        MessageBoxUtil.ShowError(this, ErrorMessages.MISSING_FILES);
                    }
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }

        private void ObjectListView_DeviceList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;

            if (olv.GetItemCount() == olv.CheckedObjects.Count)
            {
                olv.CheckHeaderCheckBox(olvColumnContent_TeamId);
            }
            else {
                UncheckHeaderCheckbox(olv, olvColumnContent_TeamId);
            }
        }

        private void ObjectListView_DeviceList_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            CheckState newState = e.NewCheckState;
            if (newState == CheckState.Checked)
            {
                // suppress message box
                _suppressErrorMessage = true;
                if (olv.Objects != null)
                {
                    olv.CheckAll();
                }
                _suppressErrorMessage = false;
            }
            else if (newState == CheckState.Unchecked)
            {
                if (olv.Objects != null && olv.CheckedObjects.Count > 0)
                {
                    olv.UncheckAll();
                }
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
