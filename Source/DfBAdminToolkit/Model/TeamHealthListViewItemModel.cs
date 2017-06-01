namespace DfBAdminToolkit.Model {

	using System.ComponentModel;
    using System;

	public class TeamHealthListViewItemModel
		: INotifyPropertyChanged, IModel {
		private string _usage;
		private string _provisionedUsers;
		private string _status;

		public string Usage {
			get { return _usage; }
			set {
				_usage = value;
				OnPropertyChanged("Usage");
			}
		}

		public string ProvisionedUsers
		{
			get { return _provisionedUsers; }
			set {
				_provisionedUsers = value;
				OnPropertyChanged("ProvisionedUsers");
			}
		}

		public string Status {
			get { return _status; }
			set {
				_status = value;
				OnPropertyChanged("Status");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public TeamHealthListViewItemModel() {
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