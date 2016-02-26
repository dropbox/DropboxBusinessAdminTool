namespace DfBAdminToolkit.View {

    using System;

    public interface IDataMigrationView
        : IView {
        event EventHandler CommandDisplayContent;
        event EventHandler CommandExportContent;

        string OutputFileName { get; set; }

        void RenderContentSearchResult();

        void EnableExportControl(bool enable);

        void EnableExportButton(bool enable);
    }
}