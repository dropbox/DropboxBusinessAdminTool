namespace DfBAdminToolkit.Model {

    using System;
    using System.Collections.Generic;

    public class TextSearchModel
        : ITextSearchModel {
        private TextSearchMode _searchMode;

        public List<MemberListViewItemModel> MemberList { get; set; }

        //public List<MemberListViewItemModel> ResultList { get; set; }

        public List<string> SearchModeList { get; set; }

        public string AccessToken { get; set; }

        public string QueryString { get; set; }

        public int SearchResultsLimit { get; set; }

        public string SelectedSearchMode {
            get { return _searchMode.ToString().Replace("_", " "); }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    string replaced = value.Replace(" ", "_");
                    if (!Enum.TryParse(replaced, out _searchMode)) {
                        _searchMode = TextSearchMode.Filename_only;
                    }
                }
            }
        }

        public enum TextSearchMode : int {
            Filename_only = 0,
            Filename_and_Content = 1
        }

        public TextSearchModel() {
            Initialize();
        }

        public void Initialize() {
            MemberList = new List<MemberListViewItemModel>();
            //ResultList = new List<MemberListViewItemModel>();
            AccessToken = ApplicationResource.DefaultAccessToken;
            _searchMode = TextSearchMode.Filename_only;
            SearchModeList = new List<string>();
            foreach (TextSearchMode mode in Enum.GetValues(typeof(TextSearchMode))) {
                SearchModeList.Add(mode.ToString().Replace("_", " "));
            }
            SearchResultsLimit = ApplicationResource.SearchDefaultLimit;
        }

        public void CleanUp() {
        }

        public string GetSearchModeForService() {
            string converted = string.Empty;
            switch (_searchMode) {
                case TextSearchMode.Filename_only:
                    converted = "filename";
                    break;

                case TextSearchMode.Filename_and_Content:
                    converted = "filename_and_content";
                    break;

                default:
                    throw new IndexOutOfRangeException();
            }
            return converted;
        }
    }
}