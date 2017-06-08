namespace DfBAdminToolkit.View
{
	using BrightIdeasSoftware;
	using Model;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;

	public partial class TeamAuditingView : Form, ITeamAuditingView
	{
		public event EventHandler DataChanged;
		public event EventHandler CommandLoadTeamEvents;
		public event EventHandler CommandLoadCSV;
		public event EventHandler CommandExportToCSV;
		public event EventHandler CommandFilterMembers;

		public SynchronizationContext SyncContext { get; set; }

		public bool ComponentEventsWired { get; set; }

		public string AccessToken { get; set; }

		public DateTime StartTime { get; set; }

		public DateTime EndTime { get; set; }

		public string TeamAuditingInputFilePath { get; set; }

		public string EventCategory { get; set; }

        List<TeamAuditingListViewItemModel> newAudit;

        public enum OlvMembersIndex : int
		{
			Timestamp,
			ActorType,
			Email,
			Context,
			EventType,
			Origin,
			IpAddress,
			City,
			Region,
			Country,
			Participants,
			Assets
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
				this.buttonEx_TeamAuditingLoadTeamEvents.Click += buttonEx_TeamAuditingLoadTeamAuditing_Click;
				this.buttonEx_TeamAuditingLoadFromCSV.Click += buttonEx_TeamAuditingLoadFromCSV_Click;
				this.buttonEx_TeamAuditingExportToCSV.Click += buttonEx_TeamAuditingExportToCSV_Click;
				this.buttonEx_TeamAuditingFilterMembers.Click += buttonEx_TeamAuditingFilterMembers_Click;
				this.objectListView_TeamAuditingMembers.ItemChecked += ObjectListView_TeamAuditingMembers_ItemChecked;
				this.objectListView_TeamAuditingMembers.HeaderCheckBoxChanging += ObjectListView_TeamAuditingMembers_HeaderCheckBoxChanging;
				ComponentEventsWired = true;
			}
		}

		public void UnWireComponentEvents()
		{
			if (ComponentEventsWired)
			{
				this.buttonEx_TeamAuditingLoadTeamEvents.Click -= buttonEx_TeamAuditingLoadTeamAuditing_Click;
				this.buttonEx_TeamAuditingLoadFromCSV.Click -= buttonEx_TeamAuditingLoadFromCSV_Click;
				this.buttonEx_TeamAuditingExportToCSV.Click -= buttonEx_TeamAuditingExportToCSV_Click;
				this.buttonEx_TeamAuditingFilterMembers.Click -= buttonEx_TeamAuditingFilterMembers_Click;
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
			this.comboBox_EventCategory.Text = "All Events";
			EventCategory = comboBox_EventCategory.Text;

			// Initialize From picker to yesterday and set format
			dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
			dateTimePickerFrom.CustomFormat = "MM-dd-yyyy  hh:mm:ss";
			DateTime resultFrom = DateTime.Now.Subtract(TimeSpan.FromDays(1));
			dateTimePickerFrom.Value = resultFrom;
			StartTime = resultFrom;
			//set To picker to now and set format. 
			dateTimePickerTo.Format = DateTimePickerFormat.Custom;
			dateTimePickerTo.CustomFormat = "MM-dd-yyyy  hh:mm:ss";
			DateTime resultTo = DateTime.Now;
			dateTimePickerTo.Value = resultTo;
			EndTime = resultTo;

            buttonEx_TeamAuditingExportToCSV.Enabled = false;
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

			olv.GetColumn((int)OlvMembersIndex.Timestamp).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Timestamp : DateTime.Now;
				};
			olv.GetColumn((int)OlvMembersIndex.ActorType).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.ActorType : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Email).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Email : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Context).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Context : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.EventType).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.EventType : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Origin).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Origin : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.IpAddress).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.IpAddress : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.City).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.City : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Region).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Region : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Country).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Country : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Participants).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Participants : string.Empty;
				};
			olv.GetColumn((int)OlvMembersIndex.Assets).AspectGetter
				= delegate (TeamAuditingListViewItemModel model)
				{
					return (model != null) ? model.Assets : string.Empty;
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

		public void RenderTeamAuditingList(List<TeamAuditingListViewItemModel> TeamAuditing)
		{
			this.objectListView_TeamAuditingMembers.SetObjects(TeamAuditing);
			if (this.objectListView_TeamAuditingMembers.GetItemCount() == this.objectListView_TeamAuditingMembers.CheckedObjects.Count)
			{
				this.objectListView_TeamAuditingMembers.CheckHeaderCheckBox(olvColumnTeamAuditing_Timestamp);
			}
		}

		public List<TeamAuditingListViewItemModel> RenderTeamAuditingFilteredMemberList(List<MemberListViewItemModel> members, List<TeamAuditingListViewItemModel> TeamAuditing, List<TeamAuditingListViewItemModel> newAudit)
		{
			if (textBoxTeamAuditing.Text != "Upload Member(s) Filter File...")
			{
				foreach (TeamAuditingListViewItemModel item in TeamAuditing)
				{
					foreach (MemberListViewItemModel member in members)
						if (member.Email == item.Email)
						{
							newAudit.Add(item);         
						}
				}
				this.objectListView_TeamAuditingMembers.SetObjects(newAudit);
				if (this.objectListView_TeamAuditingMembers.GetItemCount() == this.objectListView_TeamAuditingMembers.CheckedObjects.Count)
				{
					this.objectListView_TeamAuditingMembers.CheckHeaderCheckBox(olvColumnTeamAuditing_Timestamp);
				}
			}
            return newAudit;
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
			if (CommandLoadTeamEvents != null)
			{
				CommandLoadTeamEvents(sender, e);
			}
            this.buttonEx_TeamAuditingExportToCSV.Enabled = true;
		}

		private void buttonEx_TeamAuditingLoadFromCSV_Click(object sender, EventArgs e)
		{
			OpenFileDialog inputFile = new OpenFileDialog();
			inputFile.Title = "Please select a CSV file";
			inputFile.Filter = "CSV File|*.csv";
			DialogResult result = inputFile.ShowDialog();

			if (result == DialogResult.OK)
			{
				textBoxTeamAuditing.Text = inputFile.FileName;
				TeamAuditingInputFilePath = inputFile.FileName;
				InvokeDataChanged(sender, e);
				if (CommandLoadCSV != null)
				{
					CommandLoadCSV(sender, e);
				}
			}
		}

		private void buttonEx_TeamAuditingExportToCSV_Click(object sender, EventArgs e)
		{
			InvokeDataChanged(sender, e);
			if (CommandExportToCSV != null)
			{
				CommandExportToCSV(sender, e);
			}
		}

		private void buttonEx_TeamAuditingFilterMembers_Click(object sender, EventArgs e)
		{
			InvokeDataChanged(sender, e);
			if (CommandFilterMembers != null)
			{
				CommandFilterMembers(sender, e);
			}
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
				olv.CheckHeaderCheckBox(olvColumnTeamAuditing_Timestamp);
			}
			else
			{
				UncheckHeaderCheckbox(olv, olvColumnTeamAuditing_Timestamp);
			}
		}

		private void InvokeDataChanged(object sender, EventArgs e)
		{
			if (DataChanged != null)
			{
				DataChanged(sender, e);
			}
		}

		private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
		{
			StartTime = dateTimePickerFrom.Value;
		}

		private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
		{
			EndTime = dateTimePickerTo.Value;
		}  

		private void comboBox_EventCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			EventCategory = comboBox_EventCategory.Text;
		}

		#endregion Events
	}
}