namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface IPaperView
        : IView
    {
        event EventHandler DataChanged;
        event EventHandler CommandGetPaper;
        event EventHandler CommandDownloadPaper;
        event EventHandler CommandDeletePaper;
        event EventHandler CommandExportToCSV;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        void EnableDownloadButton(bool enable);

        string PaperName { get; set; }

        string PaperId { get; set; }

        bool ArchiveSetting { get; set; }

        bool PermanentSetting { get; set; }

        string UserEmail { get; set; }

        string OutputFolder { get; set; }

        void RenderPaperList();

        PaperModel GetPaperIds();
    }
}