namespace DfBAdminToolkit.View
{
    using BrightIdeasSoftware;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.Common.Utils;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class GroupsView : Form, IGroupsView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandGetGroups;
        public event EventHandler CommandCreateGroup;
        public event EventHandler CommandExportGroups;
        public event EventHandler CommandExportGroupPerms;
        public event EventHandler CommandAddMember;
        public event EventHandler CommandDeleteMember;
        public event EventHandler CommandLoadGroupsInputFile;
        public event EventHandler CommandLoadGroupsMembersInputFile;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public string GroupName { get; set; }

        public string GroupType { get; set; }

        public string UserEmail { get; set; }

        public string AddStatus { get; set; }

        public string GroupInputFilePath { get; set; }

        public string GroupMemberInputFilePath { get; set; }

        public List<GroupListViewItemModel> Groups { get; set; }

        public enum OlvMembersIndex : int
        {
            GroupName,
            MemberCount,
            GroupType,
            GroupId,
            Email,
            AddStatus
        }

        public GroupsView()
        {
            InitializeComponent();
            Initialize();
            InitializeOLVMembers();
            WireComponentEvents();
            this.objectListView_GroupsMembers.RebuildColumns();
        }

        ~GroupsView()
        {
            UnWireComponentEvents();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.textBox_GroupsAccessToken.TextChanged += TextBox_GroupsAccessToken_TextChanged;
                this.buttonEx_GroupsLoadGroups.Click += buttonEx_GroupsLoadGroups_Click;
                this.buttonEx_GroupsCreateGroup.Click += buttonEx_GroupsCreateGroup_Click;
                this.buttonEx_GroupFileInputSelect.Click += buttonEx_GroupFileInputSelect_Click;
                this.buttonEx_GroupsExportGroups.Click += buttonEx_GroupsExportGroups_Click;
                this.buttonEx_GroupExportPerms.Click += buttonEx_GroupExportPerms_Click;
                this.buttonEx_GroupsAddMember.Click += buttonEx_GroupsAddMember_Click;
                this.buttonEx_GroupMemberFileInput.Click += buttonEx_GroupMemberFileInput_Click;
                this.buttonEx_GroupsDeleteMember.Click += buttonEx_GroupsDeleteMember_Click;
                this.textBoxGroup.TextChanged += TextBox_textBoxGroup_TextChanged;
                this.textBoxAddMember.TextChanged += TextBox_textBoxAddMember_TextChanged;
                this.radioCompany.CheckedChanged += radioCompany_CheckedChanged;
                this.radioUser.CheckedChanged += radioUser_CheckedChanged;
                this.objectListView_GroupsMembers.ItemChecked += ObjectListView_GroupsMembers_ItemChecked;
                this.objectListView_GroupsMembers.HeaderCheckBoxChanging += ObjectListView_GroupsMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.textBox_GroupsAccessToken.TextChanged -= TextBox_GroupsAccessToken_TextChanged;
                this.buttonEx_GroupsLoadGroups.Click -= buttonEx_GroupsLoadGroups_Click;
                this.buttonEx_GroupsCreateGroup.Click -= buttonEx_GroupsCreateGroup_Click;
                this.buttonEx_GroupFileInputSelect.Click -= buttonEx_GroupFileInputSelect_Click;
                this.buttonEx_GroupsExportGroups.Click -= buttonEx_GroupsExportGroups_Click;
                this.buttonEx_GroupExportPerms.Click -= buttonEx_GroupExportPerms_Click;
                this.buttonEx_GroupsAddMember.Click -= buttonEx_GroupsAddMember_Click;
                this.buttonEx_GroupMemberFileInput.Click -= buttonEx_GroupMemberFileInput_Click;
                this.buttonEx_GroupsDeleteMember.Click -= buttonEx_GroupsDeleteMember_Click;
                this.textBoxGroup.TextChanged -= TextBox_textBoxGroup_TextChanged;
                this.textBoxAddMember.TextChanged -= TextBox_textBoxAddMember_TextChanged;
                this.radioCompany.CheckedChanged -= radioCompany_CheckedChanged;
                this.radioUser.CheckedChanged -= radioUser_CheckedChanged;
                this.objectListView_GroupsMembers.ItemChecked -= ObjectListView_GroupsMembers_ItemChecked;
                this.objectListView_GroupsMembers.HeaderCheckBoxChanging -= ObjectListView_GroupsMembers_HeaderCheckBoxChanging;
                ComponentEventsWired = false;
            }
        }

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            Groups = new List<GroupListViewItemModel>();
            this.buttonEx_GroupsLoadGroups.Enabled = true;
            this.radioUser.Checked = true;
            GroupType = "company_managed";
            olvColumnGroups_AddStatus.IsVisible = false;
            olvColumnGroups_Email.IsVisible = false;
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_GroupsMembers.CellEditActivation = ObjectListView.CellEditActivateMode.None;
            this.objectListView_GroupsMembers.UseExplorerTheme = false;
            this.objectListView_GroupsMembers.UseTranslucentHotItem = true;
            this.objectListView_GroupsMembers.FullRowSelect = false;
            this.objectListView_GroupsMembers.HotTracking = false;
            this.objectListView_GroupsMembers.HeaderToolTip.IsBalloon = false;
            this.objectListView_GroupsMembers.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_GroupsMembers.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<GroupListViewItemModel> olv = new TypedObjectListView<GroupListViewItemModel>(
                this.objectListView_GroupsMembers
            );

            olv.GetColumn((int)OlvMembersIndex.GroupName).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.GroupName : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.GroupType).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.GroupType : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.MemberCount).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.MemberCount : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.GroupId).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.GroupId : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.Email).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.Email : string.Empty;
                };
            olv.GetColumn((int)OlvMembersIndex.AddStatus).AspectGetter
                = delegate (GroupListViewItemModel model)
                {
                    return (model != null) ? model.AddStatus : string.Empty;
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
            textBox_GroupsAccessToken.Text = AccessToken;
        }

        private void TextBox_textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            GroupName = this.textBoxGroup.Text;
        }

        private void TextBox_textBoxAddMember_TextChanged(object sender, EventArgs e)
        {
            UserEmail = this.textBoxAddMember.Text;
        }

        private void radioCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCompany.Checked == true)
            {
                GroupType = "company_managed";
            }
            else
            {
                GroupType = "user_managed";
            }
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUser.Checked == true)
            {
                GroupType = "user_managed";
            }
            else
            {
                GroupType = "company_managed";
            }
        }

        public void RenderGroupList()
        {
            this.objectListView_GroupsMembers.SetObjects(Groups);
            if (this.objectListView_GroupsMembers.GetItemCount() == this.objectListView_GroupsMembers.CheckedObjects.Count)
            {
                this.objectListView_GroupsMembers.CheckHeaderCheckBox(olvColumnGroups_GroupName);
            }
        }

        public void RenderGroupsStatus(List<GroupListViewItemModel> groups)
        {
            Groups = groups;
            this.objectListView_GroupsMembers.SetObjects(Groups);
            objectListView_GroupsMembers.BuildList();
        }

        public bool MultiGroupCreateCheck()
        {
            bool check = false;

            if ((textBoxGroup.Text).Contains(".csv"))
            {
                check = true;
            }
            return check;
        }

        public bool MultiGroupMemberCreateCheck()
        {
            bool check = false;

            if ((textBoxAddMember.Text).Contains(".csv"))
            {
                check = true;
            }
            return check;
        }

        private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
        {
            // unbind event temporarily and uncheck header box
            olv.HeaderCheckBoxChanging -= ObjectListView_GroupsMembers_HeaderCheckBoxChanging;
            olv.UncheckHeaderCheckBox(col);
            olv.HeaderCheckBoxChanging += ObjectListView_GroupsMembers_HeaderCheckBoxChanging;
        }

        #endregion Slots

        #region Events

        private void buttonEx_GroupsLoadGroups_Click(object sender, EventArgs e)
        {
            olvColumnGroups_MemberCount.IsVisible = true;
            olvColumnGroups_GroupType.IsVisible = true;
            olvColumnGroups_GroupId.IsVisible = true;
            olvColumnGroups_Email.IsVisible = false;
            olvColumnGroups_AddStatus.IsVisible = false;
            this.objectListView_GroupsMembers.RebuildColumns();

            InvokeDataChanged(sender, e);
            if (CommandGetGroups != null)
            {
                CommandGetGroups(sender, e);
            }
        }

        private void buttonEx_GroupsCreateGroup_Click(object sender, EventArgs e)
        {
            olvColumnGroups_MemberCount.IsVisible = false;
            olvColumnGroups_GroupType.IsVisible = true;
            olvColumnGroups_GroupId.IsVisible = false;
            olvColumnGroups_Email.IsVisible = false;
            olvColumnGroups_AddStatus.IsVisible = true;
            this.objectListView_GroupsMembers.RebuildColumns();

            InvokeDataChanged(sender, e);
            if (CommandCreateGroup != null)
            {
                CommandCreateGroup(sender, e);
            }
        }

        private void buttonEx_GroupFileInputSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFile = new OpenFileDialog();
            inputFile.Title = "Please select a CSV file";
            inputFile.Filter = "CSV File|*.csv";
            DialogResult result = inputFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxGroup.Text = inputFile.FileName;
                GroupInputFilePath = inputFile.FileName;
                InvokeDataChanged(sender, e);

                //make all columns hidden except GroupName, GroupType and AddStatus
                olvColumnGroups_MemberCount.IsVisible = false;
                olvColumnGroups_GroupType.IsVisible = true;
                olvColumnGroups_GroupId.IsVisible = false;
                olvColumnGroups_Email.IsVisible = false;
                olvColumnGroups_AddStatus.IsVisible = true;
                this.objectListView_GroupsMembers.RebuildColumns();

                if (CommandLoadGroupsInputFile != null)
                {
                    CommandLoadGroupsInputFile(sender, e);
                }
            }
        }

        private void buttonEx_GroupsExportGroups_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportGroups != null)
            {
                CommandExportGroups(sender, e);
            }
        }

        private void buttonEx_GroupExportPerms_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandExportGroupPerms != null)
            {
                CommandExportGroupPerms(sender, e);
            }
        }

        private void buttonEx_GroupsAddMember_Click(object sender, EventArgs e)
        {
            olvColumnGroups_MemberCount.IsVisible = false;
            olvColumnGroups_GroupType.IsVisible = false;
            olvColumnGroups_GroupId.IsVisible = true;
            olvColumnGroups_Email.IsVisible = true;
            olvColumnGroups_AddStatus.IsVisible = true;
            this.objectListView_GroupsMembers.RebuildColumns();

            InvokeDataChanged(sender, e);
            if (CommandAddMember != null)
            {
                CommandAddMember(sender, e);
            }
        }

        private void buttonEx_GroupMemberFileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFile = new OpenFileDialog();
            inputFile.Title = "Please select a CSV file";
            inputFile.Filter = "CSV File|*.csv";
            DialogResult result = inputFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxAddMember.Text = inputFile.FileName;
                GroupMemberInputFilePath = inputFile.FileName;
                InvokeDataChanged(sender, e);

                //make columns hidden except GroupName, Email, and AddStatus
                olvColumnGroups_MemberCount.IsVisible = false;
                olvColumnGroups_GroupType.IsVisible = false;
                olvColumnGroups_GroupId.IsVisible = true;
                olvColumnGroups_Email.IsVisible = true;
                olvColumnGroups_AddStatus.IsVisible = true;
                this.objectListView_GroupsMembers.RebuildColumns();

                if (CommandLoadGroupsMembersInputFile != null)
                {
                    CommandLoadGroupsMembersInputFile(sender, e);
                }
            }
        }

        private void buttonEx_GroupsDeleteMember_Click(object sender, EventArgs e)
        {
            bool multiCheck = MultiGroupMemberCreateCheck();

            if (!multiCheck)
            {
                InvokeDataChanged(sender, e);
                if (CommandDeleteMember != null)
                {
                    CommandDeleteMember(sender, e);
                }
            }
            if (multiCheck)
            {
                MessageBoxUtil.ShowError(this, "You cannot mass delete members from groups at this time. Only single members can be deleted from this version of the toolkit.");
            }
        }

        private void TextBox_GroupsAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_GroupsAccessToken.Text;
        }

        private void ObjectListView_GroupsMembers_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
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

        private void ObjectListView_GroupsMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ObjectListView olv = sender as ObjectListView;
            if (olv.GetItemCount() == olv.CheckedObjects.Count)
            {
                olv.CheckHeaderCheckBox(olvColumnGroups_GroupName);
            }
            else
            {
                UncheckHeaderCheckbox(olv, olvColumnGroups_GroupName);
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