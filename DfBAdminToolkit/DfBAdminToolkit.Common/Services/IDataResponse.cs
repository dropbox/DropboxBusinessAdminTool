namespace DfBAdminToolkit.Common.Services
{
    public interface IDataResponse
        : IServiceResponse
    {
        object Data { get; set; }
    }
}