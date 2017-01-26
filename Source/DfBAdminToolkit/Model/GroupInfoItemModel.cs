namespace DfBAdminToolkit.Model
{
    using System.ComponentModel;

    public class GroupInfoItemModel
        : INotifyPropertyChanged, IModel
    {
        private string _groupName;
        private string _groupId;
        private string _groupType;
        private string _teamMemberId;
        private string _email;
        private string _emailVerified;
        private string _status;
        private string _membershipType;
        private string _accessType;
        private string _joinedOn;
        private bool _isChecked;

        public string GroupName
        {
            get { return _groupName; }
            set
            {
                _groupName = value;
                OnPropertyChanged("GroupName");
            }
        }

        public string GroupId
        {
            get { return _groupId; }
            set
            {
                _groupId = value;
                OnPropertyChanged("GroupId");
            }
        }

        public string GroupType
        {
            get { return _groupType; }
            set
            {
                _groupType = value;
                OnPropertyChanged("GroupType");
            }
        }

        public string TeamMemberId
        {
            get { return _teamMemberId; }
            set
            {
                _teamMemberId = value;
                OnPropertyChanged("TeamMemberId");
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

        public string EmailVerified
        {
            get { return _emailVerified; }
            set
            {
                _emailVerified = value;
                OnPropertyChanged("EmailVerified");
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        public string MembershipType
        {
            get { return _membershipType; }
            set
            {
                _membershipType = value;
                OnPropertyChanged("MembershipType");
            }
        }

        public string AccessType
        {
            get { return _accessType; }
            set
            {
                _accessType = value;
                OnPropertyChanged("AccessType");
            }
        }

        public string JoinedOn
        {
            get { return _joinedOn; }
            set
            {
                _joinedOn = value;
                OnPropertyChanged("JoinedOn");
            }
        }

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public GroupInfoItemModel()
        {
        }

        public void Initialize()
        {
        }

        public void CleanUp()
        {
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
