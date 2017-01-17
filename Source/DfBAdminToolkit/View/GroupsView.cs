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
        public event EventHandler CommandAddMember;
        public event EventHandler CommandDeleteMember;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public string AccessToken { get; set; }

        public string GroupName { get; set; }

        public string GroupType { get; set; }

        public string UserEmail { get; set; }

        public List<GroupListViewItemModel> Groups { get; set; }

        public enum OlvMembersIndex : int
        {
            GroupName,
            MemberCount,
            GroupType,
            GroupId
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
                this.buttonEx_GroupsExportGroups.Click += buttonEx_GroupsExportGroups_Click;
                this.buttonEx_GroupsAddMember.Click += buttonEx_GroupsAddMember_Click;
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
                this.buttonEx_GroupsExportGroups.Click -= buttonEx_GroupsExportGroups_Click;
                this.buttonEx_GroupsAddMember.Click -= buttonEx_GroupsAddMember_Click;
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
            this.radioCompany.Checked = true;
            GroupType = "company_managed";
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_GroupsMembers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
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
            InvokeDataChanged(sender, e);
            if (CommandGetGroups != null)
            {
                CommandGetGroups(sender, e);
            }
        }

        private void buttonEx_GroupsCreateGroup_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandCreateGroup != null)
            {
                CommandCreateGroup(sender, e);
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

        private void buttonEx_GroupsAddMember_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandAddMember != null)
            {
                CommandAddMember(sender, e);
            }
        }

        private void buttonEx_GroupsDeleteMember_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandDeleteMember != null)
            {
                CommandDeleteMember(sender, e);
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