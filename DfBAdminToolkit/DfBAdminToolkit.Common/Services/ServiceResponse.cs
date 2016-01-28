namespace DfBAdminToolkit.Common.Services
{
    using System.Net;

    public class ServiceResponse
        : IServiceResponse
    {
        public ServiceResponse(
            HttpStatusCode code, string msg)
        {
            StatusCode = code;
            Message = msg;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }
    }
}