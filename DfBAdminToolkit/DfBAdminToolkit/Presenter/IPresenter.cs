namespace DfBAdminToolkit.Presenter
{
    using System.Threading;

    public interface IPresenter
    {
        bool IsViewEventsWired { get; set; }

        SynchronizationContext SyncContext { get; set; }
    }
}