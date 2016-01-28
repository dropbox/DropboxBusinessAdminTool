namespace DfBAdminToolkit.Common.Services
{
    using System.Net;

    public interface IServiceResponse
    {
        HttpStatusCode StatusCode { get; set; }

        string Message { get; set; }
    }
}