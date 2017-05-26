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

	public partial class TeamAuditingView : Form, ITeamAuditingView
	{
		public event EventHandler DataChanged;
        public event EventHandler CommandLoadTeamAuditing;

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

		public TeamAuditingView()
		{
			InitializeComponent();
			Initialize();
			InitializeOLVMembers();
			WireComponentEvents();
			this.objectListView_TeamAuditingMembers.RebuildColumns();
		}

		~TeamAuditingView()
		{
			UnWireComponentEvents();
		}

		public void WireComponentEvents()
		{
			if (!ComponentEventsWired)
			{
				this.buttonEx_TeamAuditingLoadTeamFolders.Click += buttonEx_TeamAuditingLoadTeamAuditing_Click;
				this.objectListView_TeamAuditingMembers.ItemChecked += ObjectListView_TeamAuditingMembers_ItemChecked;
				this.objectListView_TeamAuditingMembers.HeaderCheckBoxChanging += ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging;
				ComponentEventsWired = true;
			}
		}

		public void UnWireComponentEvents()
		{
			if (ComponentEventsWired)
			{
				this.buttonEx_TeamAuditingLoadTeamFolders.Click -= buttonEx_TeamAuditingLoadTeamAuditing_Click;
				this.objectListView_TeamAuditingMembers.ItemChecked -= ObjectListView_TeamAuditingMembers_ItemChecked;
				this.objectListView_TeamAuditingMembers.HeaderCheckBoxChanging -= ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging;
				ComponentEventsWired = false;
			}
		}

		public void Initialize()
		{
			ComponentEventsWired = false;
			SyncContext = SynchronizationContext.Current;
			TopLevel = false;
			Dock = DockStyle.Fill;
			//this.buttonEx_TeamFoldersLoadTeamFolders.Enabled = true;
		}

		private void InitializeOLVMembers()
		{
			// don't allow edit
			this.objectListView_TeamAuditingMembers.CellEditActivation = ObjectListView.CellEditActivateMode.None;
			this.objectListView_TeamAuditingMembers.UseExplorerTheme = false;
			this.objectListView_TeamAuditingMembers.UseTranslucentHotItem = true;
			this.objectListView_TeamAuditingMembers.FullRowSelect = false;
			this.objectListView_TeamAuditingMembers.HotTracking = false;
			this.objectListView_TeamAuditingMembers.HeaderToolTip.IsBalloon = false;
			this.objectListView_TeamAuditingMembers.HotItemStyle.BackColor = Color.AliceBlue;
			this.objectListView_TeamAuditingMembers.HotItemStyle.ForeColor = Color.MediumBlue;

			TypedObjectListView<TeamAuditingListViewItemModel> olv = new TypedObjectListView<TeamAuditingListViewItemModel>(
				this.objectListView_TeamAuditingMembers
			);

			olv.GetColumn((int)OlvMembersIndex.TeamFolderName).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.TeamFolderName : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.TeamFolderId).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.TeamFolderId : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Status).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
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
            textBox_TeamAuditingAccessToken.Text = AccessToken;
		}

		private void TextBox_textBoxTeamAuditing_TextChanged(object sender, EventArgs e)
		{
			TeamFolderName = this.textBoxTeamAuditing.Text;
		}

		public void RenderTeamAuditingList()
		{
			//this.objectListView_TeamAuditingMembers.SetObjects(TeamAuditing);
			if (this.objectListView_TeamAuditingMembers.GetItemCount() == this.objectListView_TeamAuditingMembers.CheckedObjects.Count)
			{
				this.objectListView_TeamAuditingMembers.CheckHeaderCheckBox(olvColumnTeamFolders_TeamFolderName);
			}
		}

		private void UncheckHeaderCheckbox(ObjectListView olv, OLVColumn col)
		{
			// unbind event temporarily and uncheck header box
			olv.HeaderCheckBoxChanging -= ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging;
			olv.UncheckHeaderCheckBox(col);
			olv.HeaderCheckBoxChanging += ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging;
		}

		#endregion Slots

		#region Events

		private void buttonEx_TeamAuditingLoadTeamAuditing_Click(object sender, EventArgs e)
		{
			InvokeDataChanged(sender, e);
			//if (CommandGetTeamFolders != null)
			//{
			//	CommandGetTeamFolders(sender, e);
			//}
		}

		private void TextBox_TeamAuditingAccessToken_TextChanged(object sender, EventArgs e)
		{
			AccessToken = this.textBox_TeamAuditingAccessToken.Text;
		}
		
		private void ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging(object sender, HeaderCheckBoxChangingEventArgs e)
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

		private void ObjectListView_TeamAuditingMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
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