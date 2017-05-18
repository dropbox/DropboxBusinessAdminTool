namespace DfBAdminToolkit.Model {

	using System.ComponentModel;
    using System;

	public class PaperListViewItemModel
		: INotifyPropertyChanged, IModel {
		private string _paperName;
		private string _paperId;
		private string _status;
        private string _owner;
        private DateTime _createdDate;
        private DateTime _lastUpdatedDate;
        private string _lastEditor;
        private UInt64 _revision;
        private bool _isChecked;

		public string PaperName
        {
			get { return _paperName; }
			set {
                _paperName = value;
				OnPropertyChanged("PaperName");
			}
		}

		public string PaperId
        {
			get { return _paperId; }
			set {
                _paperId = value;
				OnPropertyChanged("PaperId");
			}
		}

        public string Status {
			get { return _status; }
			set {
				_status = value;
				OnPropertyChanged("Status");
			}
		}

        public string Owner
        {
            get { return _owner; }
            set
            {
                _owner = value;
                OnPropertyChanged("Owner");
            }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                _createdDate = value;
                OnPropertyChanged("CreatedDate");
            }
        }

        public DateTime LastUpdatedDate
        {
            get { return _lastUpdatedDate; }
            set
            {
                _lastUpdatedDate = value;
                OnPropertyChanged("LastUpdatedDate");
            }
        }

        public string LastEditor
        {
            get { return _lastEditor; }
            set
            {
                _lastEditor = value;
                OnPropertyChanged("LastEditor");
            }
        }

        public UInt64 Revision
        {
            get { return _revision; }
            set
            {
                _revision = value;
                OnPropertyChanged("Revision");
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

		public PaperListViewItemModel() {
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