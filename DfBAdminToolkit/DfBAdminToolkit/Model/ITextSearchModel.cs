namespace DfBAdminToolkit.Model
{
    using System.Collections.Generic;

    public interface ITextSearchModel
        : IModel
    {
        List<MemberListViewItemModel> MemberList { get; set; }

        //List<MemberListViewItemModel> ResultList { get; set; }

        List<string> SearchModeList { get; set; }

        string AccessToken { get; set; }

        string QueryString { get; set; }

        string SelectedSearchMode { get; set; }

        int SearchResultsLimit { get; set; }

        string GetSearchModeForService();
    }
}