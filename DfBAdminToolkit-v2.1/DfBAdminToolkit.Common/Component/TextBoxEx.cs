namespace DfBAdminToolkit.Common.Component {

    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Windows.Forms;

    public partial class TextBoxEx : TextBox {
        private string[] _fileFilters;

        public event EventHandler OnDragDropEnd;
        public event EventHandler OnTextPasted;

        public TextBoxEx() {
            InitializeComponent();
            InitEvent();
        }

        public TextBoxEx(IContainer container) {
            InitializeComponent();
            container.Add(this);
            InitEvent();
        }

        private void InitEvent() {
            this.DragDrop += new DragEventHandler(TextBoxEx_DragDrop);
            this.DragEnter += new DragEventHandler(TextBoxEx_DragEnter);
        }

        private void TextBoxEx_DragEnter(object sender, DragEventArgs e) {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case 0x302:
                    if (OnTextPasted != null) {
                        string text = (string)m.GetLParam(m.GetType());
                        base.WndProc(ref m);
                        OnTextPasted.Invoke(this, new EventArgs());
                    } else {
                        string text = (string)m.GetLParam(m.GetType());
                        base.WndProc(ref m);
                    }
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void TextBoxEx_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) {
                bool isFile = false;
                try {
                    FileInfo fileInfo = new FileInfo(file);
                    if (_fileFilters.Length == 0) {
                        this.Text = fileInfo.FullName;
                    } else {
                        foreach (string filter in _fileFilters) {
                            if (fileInfo.Extension.ToLower() == filter.ToLower()) {
                                this.Text = fileInfo.FullName;
                                // for now, we only supports single file.
                                // we can easily extend this to support multi files.
                                break;
                            }
                        }
                    }
                    isFile = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                if (!isFile) {
                    DirectoryInfo dirInfo = new DirectoryInfo(file);
                    this.Text = dirInfo.FullName;
                }
            }
            OnDragDropEnd.Invoke(this, new EventArgs());
        }

        #region Properties

        public string[] FileFilter {
            get { return _fileFilters; }
            set { _fileFilters = value; }
        }

        #endregion Properties
    }
}