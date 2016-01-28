namespace DfBAdminToolkit.Model
{
    using System.ComponentModel;

    public class TeamListViewItemModel
        : INotifyPropertyChanged, IModel
    {
        private string _email;
        private string _teamId;
        private string _filePath;
        private string _fileName;
        private string _fileSize;
        private bool _isChecked;

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
            set
            {
                _teamId = value;
                OnPropertyChanged("TeamId");
            }
        }

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                OnPropertyChanged("FilePath");
            }
        }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged("FileName");
            }
        }

        public string FileSize
        {
            get { return _fileSize; }
            set
            {
                _fileSize = value;
                OnPropertyChanged("FileSize");
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

        public TeamListViewItemModel()
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