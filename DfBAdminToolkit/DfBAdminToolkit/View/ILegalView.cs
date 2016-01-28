namespace DfBAdminToolkit.View
{
    using System;

    public interface ILegalView
        : IView
    {
        event EventHandler CommandDecline;
        event EventHandler CommandAccept;
    }
}