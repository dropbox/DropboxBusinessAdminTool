namespace DfBAdminToolkit.Model {

    using System.ComponentModel;

    public class ContentDisplayListViewItemModel
        : INotifyPropertyChanged, IModel {
        private string _email;  // login
        private string _firstName;
        private string _lastName;
        private string _memberId;
        private string _itemPath;
        private string _itemPathId;
        private string _itemName;
        private string _itemId;
        private string _itemType;
        private string _itemSize;
        private string _created;
        private string _lastModified;
        private string _uploaded;
        private string _itemPathDisplay;
        private long _itemSizeByte;

        public string Email {
            get { return _email; }
            set {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string OwnerName {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
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

        public string MemberId {
            get { return _memberId; }
            set {
                _memberId = value;
                OnPropertyChanged("MemberId");
            }
        }

        public string ItemPath {
            get { return _itemPath; }
            set {
                _itemPath = value;
                OnPropertyChanged("ItemPath");
            }
        }

        public string ItemPathId {
            get { return _itemPathId; }
            set {
                _itemPathId = value;
                OnPropertyChanged("ItemPathId");
            }
        }

        public string ItemName {
            get { return _itemName; }
            set {
                _itemName = value;
                OnPropertyChanged("ItemName");
            }
        }

        public string ItemId {
            get { return _itemId; }
            set {
                _itemId = value;
                OnPropertyChanged("ItemId");
            }
        }

        public string ItemType {
            get { return _itemType; }
            set {
                _itemType = value;
                OnPropertyChanged("ItemType");
            }
        }

        public string ItemSize {
            get { return _itemSize; }
            set {
                _itemSize = value;
                OnPropertyChanged("ItemSize");
            }
        }

        public long ItemSizeByte {
            get { return _itemSizeByte; }
            set { _itemSizeByte = value; }
        }

        public string ItemPathDisplay {
            get { return _itemPathDisplay; }
            set {
                _itemPathDisplay = value;
                OnPropertyChanged("ItemPathDisplay");
            }
        }

        public string Created {
            get { return _created; }
            set {
                _created = value;
                OnPropertyChanged("Created");
            }
        }

        public string LastModified {
            get { return _lastModified; }
            set {
                _lastModified = value;
                OnPropertyChanged("LastModified");
            }
        }

        public string Uploaded {
            get { return _uploaded; }
            set {
                _uploaded = value;
                OnPropertyChanged("Uploaded");
            }
        }

        public void CleanUp() {
        }

        public void Initialize() {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}