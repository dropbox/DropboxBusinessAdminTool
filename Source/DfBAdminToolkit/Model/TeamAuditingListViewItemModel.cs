namespace DfBAdminToolkit.Model {

	using System.ComponentModel;
    using System;

public class TeamAuditingListViewItemModel
		: INotifyPropertyChanged, IModel {
		private DateTime _timestamp;
        private string _actorType;
        private string _email;
		private string _context;
        private string _eventType;
        private string _details;
        private string _origin;
        private string _ipAddress;
        private string _city;
        private string _region;
        private string _country;
        private string _participants;
        private string _assets;
        private bool _isChecked;

		public DateTime Timestamp {
			get { return _timestamp; }
			set {
                _timestamp = value;
				OnPropertyChanged("Timestamp");
			}
		}

        public string ActorType
        {
            get { return _actorType; }
            set
            {
                _actorType = value;
                OnPropertyChanged("ActorType");
            }
        }

        public string Email {
			get { return _email; }
			set {
                _email = value;
				OnPropertyChanged("Email");
			}
		}

		public string Context {
			get { return _context; }
			set {
                _context = value;
				OnPropertyChanged("Context");
			}
		}

        public string EventType
        {
            get { return _eventType; }
            set
            {
                _eventType = value;
                OnPropertyChanged("EventType");
            }
        }

        public string Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        public string Origin
        {
            get { return _origin; }
            set
            {
                _origin = value;
                OnPropertyChanged("Origin");
            }
        }

        public string IpAddress
        {
            get { return _ipAddress; }
            set
            {
                _ipAddress = value;
                OnPropertyChanged("IpAddress");
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        public string Region
        {
            get { return _region; }
            set
            {
                _region = value;
                OnPropertyChanged("Region");
            }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged("Country");
            }
        }

        public string Participants
        {
            get { return _participants; }
            set
            {
                _participants = value;
                OnPropertyChanged("Participants");
            }
        }

        public string Assets
        {
            get { return _assets; }
            set
            {
                _assets = value;
                OnPropertyChanged("Assets");
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

		public TeamAuditingListViewItemModel() {
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