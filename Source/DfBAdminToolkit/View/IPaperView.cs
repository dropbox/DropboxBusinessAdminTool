namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface IPaperView
        : IView
    {
        event EventHandler CommandGetPaper;
        event EventHandler CommandCreatePaper;
        event EventHandler CommandSetPaperStatus;
        event EventHandler CommandSetPaperSyncSetting;
        event EventHandler CommandLoadPaper;
        event EventHandler CommandExportPaper;
        event EventHandler CommandExportPaperPerms;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        bool MultiPaperCreateCheck();

        string PaperName { get; set; }

        string PaperId { get; set; }

        string PaperInputFilePath { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderPaperList();

        PaperModel GetPaperIds();
    }
}