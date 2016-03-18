namespace DfBAdminToolkit.Model {

    using System.ComponentModel;

    public class DeviceListViewItemModel
        : INotifyPropertyChanged, IModel {
        private System.DateTime _created;
        private string _email;
        private string _teamId;
        private string _deviceName;
        private string _ipAddress;
        private string _sessionId;
        private string _clientType;
        private bool _isChecked;

        public System.DateTime Created {
            get { return _created; }
            set {
                _created = value;
                OnPropertyChanged("Created");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string TeamId
        {
            get { return _teamId; }
            set {
                _teamId = value;
                OnPropertyChanged("TeamId");
            }
        }

        public string DeviceName {
            get { return _deviceName; }
            set {
                _deviceName = value;
                OnPropertyChanged("DeviceName");
            }
        }

        public string IpAddress {
            get { return _ipAddress; }
            set {
                _ipAddress = value;
                OnPropertyChanged("IpAddress");
            }
        }

        public string SessionId {
            get { return _sessionId; }
            set {
                _sessionId = value;
                OnPropertyChanged("SessionId");
            }
        }

        public string ClientType {
            get { return _clientType; }
            set {
                _clientType = value;
                OnPropertyChanged("ClientType");
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

        public DeviceListViewItemModel() {
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