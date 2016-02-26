namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface ITextSearchView
        : IView
    {
        List<MemberListViewItemModel> MemberList { get; set; }

        //List<MemberListViewItemModel> ResultList { get; set; }

        List<string> SearchModeList { get; set; }

        string AccessToken { get; set; }

        string QueryString { get; set; }

        string SelectedSearchMode { get; set; }

        int SearchResultsLimit { get; set; }

        event EventHandler CommandMemberSearch;
        event EventHandler CommandClear;

        void ClearMemberList();

        void RefreshAccessToken();

        void RenderMembersSearchResult();

        void RenderSearchModeSelections();

        void SetSearchResultLimit(int limit);

        void RenderComponents();
    }
}