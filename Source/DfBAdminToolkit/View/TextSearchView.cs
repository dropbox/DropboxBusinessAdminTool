namespace DfBAdminToolkit.View
{
    using BrightIdeasSoftware;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class TextSearchView : Form, ITextSearchView
    {
        public event EventHandler DataChanged;
        public event EventHandler CommandMemberSearch;
        public event EventHandler CommandClear;

        public SynchronizationContext SyncContext { get; set; }

        public bool ComponentEventsWired { get; set; }

        public List<MemberListViewItemModel> MemberList { get; set; }

        public string AccessToken { get; set; }

        public string QueryString { get; set; }

        public string SelectedSearchMode { get; set; }

        public List<string> SearchModeList { get; set; }

        public int SearchResultsLimit { get; set; }

        public enum OlvMemberIndex : int
        {
            Email,
            MemberId,
            Path
        }

        public TextSearchView()
        {
            InitializeComponent();
            Initialize();
            InitializeOLVMembers();
            InitializeSearchModes();
            WireComponentEvents();
        }

        ~TextSearchView()
        {
            UnWireComponentEvents();
        }

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        #region Slots

        public void RefreshAccessToken()
        {
            this.textBox_TextSearchAccessToken.Text = this.AccessToken;
        }

        public void RenderMembersSearchResult()
        {       
            this.objectListView_Members.SetObjects(
                MemberList             
            );
            
            IDictionary<string, List<MemberListViewItemModel>> grouped
                = this.MemberList.GroupBy(s => s.Email).ToDictionary(s => s.Key, s => s.ToList());
            this.label_TextSearchMembersCount.Text = grouped.Keys.Count.ToString();

            int result = 0;
            foreach (string key in grouped.Keys)
            {
                IList<MemberListViewItemModel> items = grouped[key]; 
                int itemWithPathCount = items.Count(c => !string.IsNullOrEmpty(c.Path));
                
                if (itemWithPathCount > 0)
                {
                    result += itemWithPathCount;
                }
            }
            this.label_TextSearchResultTotalCount.Text = result.ToString();
            this.label_TextSearchMembersCount.Update();
            this.label_TextSearchResultTotalCount.Update();

            foreach (Object item in this.objectListView_Members.Objects)
            {
                MemberListViewItemModel model = item as MemberListViewItemModel;
                if (model != null)
                {
                    if (string.IsNullOrEmpty(model.Path))
                    {
                        this.objectListView_Members.RemoveObject(item);
                    }
                }
            }
        }

        public void RenderSearchModeSelections()
        {
            this.comboBox_TextSearchMode.Items.Clear();
            foreach (string mode in SearchModeList)
            {
                this.comboBox_TextSearchMode.Items.Add(mode.Replace("_", " "));
            }
            // set selected mode
            foreach (object o in this.comboBox_TextSearchMode.Items)
            {
                string item = o as string;
                if (!string.IsNullOrEmpty(item))
                {
                    if (item.Equals(SelectedSearchMode))
                    {
                        this.comboBox_TextSearchMode.SelectedItem = item;
                        this.comboBox_TextSearchMode.Update();
                        break;
                    }
                }
            }
        }

        public void SetSearchResultLimit(int limit)
        {
            if (limit > this.numericUpDown_TextSearchResultLimit.Maximum)
            {
                limit = Convert.ToInt32(this.numericUpDown_TextSearchResultLimit.Maximum);
            }
            if (limit < 0)
            {
                limit = 0;
            }
            this.SearchResultsLimit = limit;
            this.numericUpDown_TextSearchResultLimit.Value = limit;
        }

        public void RenderComponents()
        {
            RenderMembersSearchResult();
            RenderSearchModeSelections();
            SetSearchResultLimit(SearchResultsLimit);
            SetQueryString(QueryString);
        }

        public void ClearMemberList()
        {
            this.objectListView_Members.ClearObjects();
        }

        private void SetQueryString(string value)
        {
            this.textBox_TextSearchQueryString.Text = value;
        }

        #endregion Slots

        #region Init and Cleanup

        public void Initialize()
        {
            ComponentEventsWired = false;
            SyncContext = SynchronizationContext.Current;
            TopLevel = false;
            Dock = DockStyle.Fill;
            MemberList = new List<MemberListViewItemModel>();
            SearchResultsLimit = ApplicationResource.SearchDefaultLimit;
            this.textBox_TextSearchQueryString.Focus();
        }

        private void InitializeOLVMembers()
        {
            // don't allow edit
            this.objectListView_Members.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None;
            this.objectListView_Members.UseExplorerTheme = false;
            this.objectListView_Members.UseTranslucentHotItem = true;
            this.objectListView_Members.FullRowSelect = false;
            this.objectListView_Members.HotTracking = false;
            this.objectListView_Members.HeaderToolTip.IsBalloon = false;
            this.objectListView_Members.HotItemStyle.BackColor = Color.AliceBlue;
            this.objectListView_Members.HotItemStyle.ForeColor = Color.MediumBlue;

            TypedObjectListView<MemberListViewItemModel> olv = new TypedObjectListView<MemberListViewItemModel>(
                this.objectListView_Members
            );

            olv.GetColumn((int)OlvMemberIndex.Email).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.Email : string.Empty;
                };

            olv.GetColumn((int)OlvMemberIndex.MemberId).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.MemberId : string.Empty;
                };

            olv.GetColumn((int)OlvMemberIndex.Path).AspectGetter
                = delegate (MemberListViewItemModel model)
                {
                    return (model != null) ? model.Path : string.Empty;
                };
        }

        private void InitializeSearchModes()
        {
            SearchModeList = new List<string>();
            this.comboBox_TextSearchMode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_TextSearchMode.Items.Clear();
        }

        public void WireComponentEvents()
        {
            if (!ComponentEventsWired)
            {
                this.buttonEx_TextSearchSearch.Click += Button_TextSearch_Click;
                this.textBox_TextSearchQueryString.TextChanged += TextBox_TextSearchQueryString_TextChanged;
                this.textBox_TextSearchAccessToken.TextChanged += TextBox_TextSearchAccessToken_TextChanged;
                this.numericUpDown_TextSearchResultLimit.ValueChanged += NumericUpDown_TextSearchResultLimit_ValueChanged;
                this.comboBox_TextSearchMode.SelectedValueChanged += ComboBox_TextSearchMode_SelectedValueChanged;
                this.textBox_TextSearchQueryString.KeyPress += TextBox_TextSearchQueryString_KeyPress;
                this.buttonEx_TextSearchClear.Click += Button_TextSearchClear_Click;
                ComponentEventsWired = true;
            }
        }

        public void UnWireComponentEvents()
        {
            if (ComponentEventsWired)
            {
                this.buttonEx_TextSearchSearch.Click -= Button_TextSearch_Click;
                this.textBox_TextSearchQueryString.TextChanged -= TextBox_TextSearchQueryString_TextChanged;
                this.textBox_TextSearchAccessToken.TextChanged -= TextBox_TextSearchAccessToken_TextChanged;
                this.numericUpDown_TextSearchResultLimit.ValueChanged -= NumericUpDown_TextSearchResultLimit_ValueChanged;
                this.comboBox_TextSearchMode.SelectedValueChanged -= ComboBox_TextSearchMode_SelectedValueChanged;
                this.textBox_TextSearchQueryString.KeyPress -= TextBox_TextSearchQueryString_KeyPress;
                this.buttonEx_TextSearchClear.Click -= Button_TextSearchClear_Click;
                ComponentEventsWired = false;
            }
        }

        #endregion Init and Cleanup

        #region Events

        private void Button_TextSearch_Click(object sender, EventArgs e)
        {
            InvokeDataChanged(sender, e);
            if (CommandMemberSearch != null)
            {
                CommandMemberSearch(sender, e);
            }
        }

        private void Button_TextSearchClear_Click(object sender, EventArgs e)
        {
            // clear fields and update model
            if (CommandClear != null)
            {
                CommandClear(sender, e);
            }
        }

        private void TextBox_TextSearchQueryString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Button_TextSearch_Click(sender, e);
            }
        }

        private void TextBox_TextSearchQueryString_TextChanged(object sender, EventArgs e)
        {
            QueryString = this.textBox_TextSearchQueryString.Text;
        }

        private void ComboBox_TextSearchMode_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedSearchMode = this.comboBox_TextSearchMode.SelectedItem.ToString();
        }

        private void NumericUpDown_TextSearchResultLimit_ValueChanged(object sender, EventArgs e)
        {
            SearchResultsLimit = Convert.ToInt32(this.numericUpDown_TextSearchResultLimit.Value);
        }

        private void TextBox_TextSearchAccessToken_TextChanged(object sender, EventArgs e)
        {
            AccessToken = this.textBox_TextSearchAccessToken.Text;
        }

        private void InvokeDataChanged(object sender, EventArgs e)
        {
            if (DataChanged != null)
            {
                DataChanged(sender, e);
            }
        }

        #endregion Events
    }
}