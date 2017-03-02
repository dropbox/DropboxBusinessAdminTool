namespace DfBAdminToolkit.Model {

    using System.ComponentModel;

    public class GroupListViewItemModel
        : INotifyPropertyChanged, IModel {
        private string _groupName;
        private string _groupType;
        private string _groupId;
        private string _memberCount;
        private string _email;
        private string _addStatus;
        private bool _isChecked;

        public string GroupName {
            get { return _groupName; }
            set {
                _groupName = value;
                OnPropertyChanged("GroupName");
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

        public string GroupId {
            get { return _groupId; }
            set {
                _groupId = value;
                OnPropertyChanged("GroupId");
            }
        }

        public string MemberCount {
            get { return _memberCount; }
            set {
                _memberCount = value;
                OnPropertyChanged("MemberCount");
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

        public string AddStatus
        {
            get { return _addStatus; }
            set
            {
                _addStatus = value;
                OnPropertyChanged("AddStatus");
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

        public GroupListViewItemModel() {
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