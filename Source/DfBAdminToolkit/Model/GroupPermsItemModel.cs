namespace DfBAdminToolkit.Model
{
    using System.ComponentModel;

    public class GroupPermsItemModel
        : INotifyPropertyChanged, IModel
    {
        private string _groupName;
        private string _groupId;
        private string _groupType;
        private string _accessType;
        private string _sharedFolderName;
        private string _sharedFolderId;
        private string _isInherited;
        private string _isTeamFolder;
        private string _isInsideTeamFolder;
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

        public string AccessType
        {
            get { return _accessType; }
            set
            {
                _accessType = value;
                OnPropertyChanged("AccessType");
            }
        }

        public string SharedFolderName
        {
            get { return _sharedFolderName; }
            set
            {
                _sharedFolderName = value;
                OnPropertyChanged("SharedFolderName");
            }
        }

        public string SharedFolderId
        {
            get { return _sharedFolderId; }
            set
            {
                _sharedFolderId = value;
                OnPropertyChanged("SharedFolderId");
            }
        }

        public string IsInherited
        {
            get { return _isInherited; }
            set
            {
                _isInherited = value;
                OnPropertyChanged("IsInherited");
            }
        }

        public string IsTeamFolder
        {
            get { return _isTeamFolder; }
            set
            {
                _isTeamFolder = value;
                OnPropertyChanged("IsTeamFolder");
            }
        }

        public string IsInsideTeamFolder
        {
            get { return _isInsideTeamFolder; }
            set
            {
                _isInsideTeamFolder = value;
                OnPropertyChanged("IsInsideTeamFolder");
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

        public GroupPermsItemModel()
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
