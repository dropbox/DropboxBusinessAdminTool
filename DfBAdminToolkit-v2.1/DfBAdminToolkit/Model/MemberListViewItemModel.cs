namespace DfBAdminToolkit.Model {

    using System.ComponentModel;

    public class MemberListViewItemModel
        : INotifyPropertyChanged, IModel {
        private string _email;
        private string _memberId;
        private string _path;
        private string _firstName;
        private string _lastName;
        private string _status;
        private string _role;
        private decimal _usage;
        private bool _isChecked;

        public string Email {
            get { return _email; }
            set {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string MemberId {
            get { return _memberId; }
            set {
                _memberId = value;
                OnPropertyChanged("MemberId");
            }
        }

        public string Path {
            get { return _path; }
            set {
                _path = value;
                OnPropertyChanged("Path");
            }
        }

        public string FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Role {
            get { return _role; }
            set {
                _role = value;
                OnPropertyChanged("Role");
            }
        }

        public string Status {
            get { return _status; }
            set {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        public decimal Usage
        {
            get { return _usage; }
            set
            {
                _usage = value;
                OnPropertyChanged("Usage");
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

        public MemberListViewItemModel() {
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