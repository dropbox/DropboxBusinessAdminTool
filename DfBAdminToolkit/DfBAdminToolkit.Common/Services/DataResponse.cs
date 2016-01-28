namespace DfBAdminToolkit.Common.Services
{
    using System.Net;

    public class DataResponse
        : IDataResponse
    {
        public DataResponse(
            HttpStatusCode code, string msg, object data)
        {
            StatusCode = code;
            Message = msg;
            Data = data;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}