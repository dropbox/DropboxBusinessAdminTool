namespace DfBAdminToolkit.View
{
    using BrightIdeasSoftware;
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class ProvisioningView : Form, IProvisioningView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandProvision;
        public event EventHandler CommandLoadInputFile;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public bool SendWelcomeEmail { get; set; }

        public string AccessToken { get; set; }

        public string InputFilePath { get; set; }

        public string SelectedRole { get; set; }

        public List<MemberListViewItemModel> Members { get; set; }

        public enum OlvMembersIndex : int
        {
            Email,
            FirstName,
            LastName
        }

        public ProvisioningView()
        {
            InitializeComponent();
            Initialize();
            InitRoleTooltips();
            InitializeOLVMembers();
            WireComponentEvents();
            EnableProvisionButton(false);
            this.radioButton_ProvisioningRoleMemberOnly.Checked = true;
        }

        ~ProvisioningView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.textBox_ProvisioningAccessToken.TextChanged += TextBox_ProvisioningAccessToken_TextChanged;
                this.textBox_ProvisioningInputFile.OnDragDropEnd += TextBox_ProvisioningInputFile_OnDragDropEnd;
                this.buttonEx_ProvisioningProvision.Click += Button_ProvisioningDoProvision_Click;
                this.buttonEx_ProvisioningFileInputSelect.Click += Button_ProvisioningInputFile_Click;
                this.buttonEx_ProvisioningLoadCSV.Click += Button_ProvisioningLoadInputFile_Click;
                this.checkBox_ProvisioningSendWelcomeEmail.CheckedChanged += CheckBox_ProvisioningSendWelcomeEmail_CheckedChanged;
                this.objectListView_ProvisioningMembers.ItemChecked += ObjectListView_ProvisioningMembers_ItemChecked;
                this.objectListView_ProvisioningMembers.HeaderCheckBoxChanging += ObjectListView_ProvisioningMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.textBox_ProvisioningAccessToken.TextChanged -= TextBox_ProvisioningAccessToken_TextChanged;
                this.textBox_ProvisioningInputFile.OnDragDropEnd -= TextBox_ProvisioningInputFile_OnDragDropEnd;
                this.buttonEx_ProvisioningProvision.Click -= Button_ProvisioningDoProvision_Click;
                this.buttonEx_ProvisioningFileInputSelect.Click -= Button_ProvisioningInputFile_Click;
                this.buttonEx_ProvisioningLoadCSV.Click -= Button_ProvisioningLoadInputFile_Click;
                this.checkBox_ProvisioningSendWelcomeEmail.CheckedChanged -= CheckBox_ProvisioningSendWelcomeEmail_CheckedChanged;
                this.objectListView_ProvisioningMembers.ItemChecked -= ObjectListView_ProvisioningMembers_ItemChecked;
                this.objectListView_ProvisioningMembers.HeaderCheckBoxChanging -= ObjectListView_ProvisioningMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            Members = new List<MemberListViewItemModel>();
            this.textBox_ProvisioningInputFile.AllowDrop = true;
            this.textBox_ProvisioningInputFile.ReadOnly = true;
            this.checkBox_ProvisioningSendWelcomeEmail.Checked = true;
            this.buttonEx_ProvisioningLoadCSV.Enabled = false;
        }

        private void InitRoleTooltips()
        {
            //create tooltips for the user types in Provisioning
            ToolTip ttMemberOnly = new ToolTip();
            ToolTip ttAdmin = new ToolTip();
            ToolTip ttSupport = new ToolTip();
            ToolTip ttTeam = new ToolTip();
            ttMemberOnly.SetToolTip(this.radioButton_ProvisioningRoleMemberOnly, Tooltips.PROVISION_MEMBER_ONLY);
            ttAdmin.SetToolTip(this.radioButton_ProvisioningRoleUserMgmtAdmin, Tooltips.PROVISION_USER_MGMT_ADMIN);
            ttSupport.SetToolTip(this.radioButton_ProvisioningRoleSupportAdmin, Tooltips.PROVISION_SUPPORT_ADMIN);
            ttTeam.SetToolTip(this.radioButton_ProvisioningRoleTeamAdmin, Tooltips.PROVISION_TEAM_ADMIN);
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_ProvisioningMembers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_ProvisioningMembers.UseExplorerTheme = false;
            this.objectListView_ProvisioningMembers.UseTranslucentHotItem = true;
            this.objectListView_ProvisioningMembers.FullRowSelect = false;
            this.objectListView_ProvisioningMembers.HotTracking = false;
            this.objectListView_ProvisioningMembers.HeaderToolTip.IsBalloon = false;
            this.objectListView_ProvisioningMembers.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_ProvisioningMembers.HotItemStyle.ForeColor = Color.MediumBlue;
            //this.objectListView_Members.HotItemStyle.Overlay = new MemberInfoOverlay();

            TypedObjectListView<MemberListViewItemModel> olv = new TypedObjectListView<MemberListViewItemModel>(
                this.objectListView_ProvisioningMembers
            );

            olv.GetColumn((int)OlvMembersIndex.Email).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.Email : string.Empty;
                };

            olv.GetColumn((int)OlvMembersIndex.FirstName).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.FirstName : string.Empty;
                };

            olv.GetColumn((int)OlvMembersIndex.LastName).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.LastName : string.Empty;
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

        public void EnableLoadInputFileButton(bool enable)
        {
            this.buttonEx_ProvisioningLoadCSV.Enabled = enable;
            this.buttonEx_ProvisioningLoadCSV.Update();
        }

        public void EnableProvisionButton(bool enable)
        {
            this.buttonEx_ProvisioningProvision.Enabled = enable;
            this.buttonEx_ProvisioningProvision.Update();
        }

        public void RefreshAccessToken()
        {
            this.textBox_ProvisioningAccessToken.Text = AccessToken;
        }

        public void RenderMemberList(List<MemberListViewItemModel> members)
        {
            Members = members;
            this.objectListView_ProvisioningMembers.SetObjects(Members);
            if (this.objectListView_ProvisioningMembers.GetItemCount() == this.objectListView_ProvisioningMembers.CheckedObjects.Count)
            {
                this.objectListView_ProvisioningMembers.CheckHeaderCheckBox(olvColumnProvisioning_Email);
            }
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
        {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_ProvisioningMembers_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_ProvisioningMembers_HeaderCheckBoxChanging;
        }

        #endregion Slots

        #region Events

        private void CheckBox_ProvisioningSendWelcomeEmail_CheckedChanged(object sender, EventArgs e)
        {
            this.SendWelcomeEmail = this.checkBox_ProvisioningSendWelcomeEmail.Checked;
        }

        private void Button_ProvisioningDoProvision_Click(object sender, EventArgs e)
        {
            Control checkedButton = tableLayoutPanel_ProvisioningRolesSelectionGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            switch (checkedButton.Name)
            {
                case "radioButton_ProvisioningRoleTeamAdmin":
                    SelectedRole = "team_admin";
                    break;

                case "radioButton_ProvisioningRoleUserMgmtAdmin":
                    SelectedRole = "user_management_admin";
                    break;

                case "radioButton_ProvisioningRoleSupportAdmin":
                    SelectedRole = "support_admin";
                    break;

                case "radioButton_ProvisioningRoleMemberOnly":
                default:
                    SelectedRole = "member_only";
                    break;
            }

            InvokeDataChanged(sender, e);
            if (CommandProvision != null)
            {
                CommandProvision(sender, e);
            }
        }

        private void Button_ProvisioningInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFile = new OpenFileDialog();
            inputFile.Title = "Please select a CSV file";
            inputFile.Filter = "CSV File|*.csv";
            DialogResult result = inputFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_ProvisioningInputFile.Text = inputFile.FileName;
                InputFilePath = inputFile.FileName;
                InvokeDataChanged(sender, e);
                EnableLoadInputFileButton(true);
            }
        }

        private void Button_ProvisioningLoadInputFile_Click(object sender, EventArgs e)
        {
            if (CommandLoadInputFile != null)
            {
                CommandLoadInputFile(sender, e);
            }
        }

        private void TextBox_ProvisioningInputFile_OnDragDropEnd(object sender, EventArgs e)
        {
            InputFilePath = this.textBox_ProvisioningInputFile.Text;
            InvokeDataChanged(sender, e);
            EnableLoadInputFileButton(true);
        }

        private void TextBox_ProvisioningAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_ProvisioningAccessToken.Text;
        }

        private void ObjectListView_ProvisioningMembers_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
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

        private void ObjectListView_ProvisioningMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            if (olv.GetItemCount() == olv.CheckedObjects.Count)
            {
                olv.CheckHeaderCheckBox(olvColumnProvisioning_Email);
            }
            else
            {
                UncheckHeaderCheckbox(olv, olvColumnProvisioning_Email);
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