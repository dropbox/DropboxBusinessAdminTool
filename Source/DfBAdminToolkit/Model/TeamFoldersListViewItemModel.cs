namespace DfBAdminToolkit.Model {

	using System.ComponentModel;

	public class TeamFoldersListViewItemModel
		: INotifyPropertyChanged, IModel {
		private string _teamFolderName;
		private string _teamFolderId;
		//private string _defaultSyncSetting;
		private string _status;
		private bool _isChecked;

		public string TeamFolderName {
			get { return _teamFolderName; }
			set {
				_teamFolderName = value;
				OnPropertyChanged("TeamFolderName");
			}
		}

		public string TeamFolderId {
			get { return _teamFolderId; }
			set {
				_teamFolderId = value;
				OnPropertyChanged("TeamFolderId");
			}
		}

        //public string DefaultSyncSetting
        //{
        //    get { return _defaultSyncSetting; }
        //    set
        //    {
        //        _defaultSyncSetting = value;
        //        OnPropertyChanged("DefaultSyncSetting");
        //    }
        //}

        public string Status {
			get { return _status; }
			set {
				_status = value;
				OnPropertyChanged("Status");
			}
		}

		public bool IsChecked {
			get { return _isChecked; }
			set {
				_isChecked = value;
				OnPropertyChanged("IsChecked");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public TeamFoldersListViewItemModel() {
		}

		public void Initialize() {
		}

		public void CleanUp() {
		}

		private void OnPropertyChanged(string propName) {
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) {
				handler(this, new PropertyChangedEventArgs(propName));
			}
		}
	}
}