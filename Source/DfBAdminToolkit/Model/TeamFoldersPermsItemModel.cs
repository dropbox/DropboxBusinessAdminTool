namespace DfBAdminToolkit.Model
{
    using System.ComponentModel;

    public class TeamFoldersPermsItemModel
        : INotifyPropertyChanged, IModel
    {
        private string _teamFolderName;
        private string _teamFolderPath;
        private string _teamFolderMember;
        private string _teamFolderMemberId;
        private string _accessType;
        private string _memberCount;
        private bool _isChecked;

        public string TeamFolderName
        {
            get { return _teamFolderName; }
            set
            {
                _teamFolderName = value;
                OnPropertyChanged("TeamFolderName");
            }
        }

        public string TeamFolderPath
        {
            get { return _teamFolderPath; }
            set
            {
                _teamFolderPath = value;
                OnPropertyChanged("TeamFolderPath");
            }
        }

        public string TeamFolderMember
        {
            get { return _teamFolderMember; }
            set
            {
                _teamFolderMember = value;
                OnPropertyChanged("TeamFolderMember");
            }
        }

        public string TeamFolderMemberId
        {
            get { return _teamFolderMemberId; }
            set
            {
                _teamFolderMemberId = value;
                OnPropertyChanged("TeamFolderMemberId");
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

        public string MemberCount
        {
            get { return _memberCount; }
            set
            {
                _memberCount = value;
                OnPropertyChanged("MemberCount");
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

        public TeamFoldersPermsItemModel()
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

