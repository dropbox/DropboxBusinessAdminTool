namespace DfBAdminToolkit.View

{
    using System;
    using System.Threading;

    public interface IView
    {
        event EventHandler DataChanged;

        SynchronizationContext SyncContext { get; set; }

        bool ComponentEventsWired { get; set; }

        void WireComponentEvents();

        void UnWireComponentEvents();

        void Initialize();

        void ShowView();

        void HideView();
    }
}