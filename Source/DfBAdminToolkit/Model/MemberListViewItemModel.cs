namespace DfBAdminToolkit.Model {

    using System.ComponentModel;
    using System;

    public class MemberListViewItemModel
        : INotifyPropertyChanged, IModel {
        private string _email;
        private string _memberId;
        private string _path;
        private string _firstName;
        private string _lastName;
        private string _persistentId;
        private string _status;
        private string _role;
        private decimal _usage;
        private string _newEmail;
        private string _newExternalId;
        private string _provisionStatus;
        private DateTime _joinedOn;
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

        public string PersistentId {
            get { return _persistentId; }
            set
            {
                _persistentId = value;
                OnPropertyChanged("PersistentId");
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

        public string NewEmail
        {
            get { return _newEmail; }
            set
            {
                _newEmail = value;
                OnPropertyChanged("NewEmail");
            }
        }

        public string NewExternalId
        {
            get { return _newExternalId; }
            set
            {
                _newExternalId = value;
                OnPropertyChanged("NewExternalId");
            }
        }

        public string ProvisionStatus
        {
            get { return _provisionStatus; }
            set
            {
                _provisionStatus = value;
                OnPropertyChanged("ProvisionStatus");
            }
        }

        public DateTime JoinedOn
        {
            get { return _joinedOn; }
            set
            {
                _joinedOn = value;
                OnPropertyChanged("JoinedOn");
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