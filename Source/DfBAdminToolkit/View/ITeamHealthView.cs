namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamHealthView
        : IView
    {
        event EventHandler CommandRefresh;

        string AccessToken { get; set; }

        void RefreshAccessToken();

    }
}