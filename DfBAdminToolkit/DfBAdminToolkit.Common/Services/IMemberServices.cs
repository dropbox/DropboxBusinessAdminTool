namespace DfBAdminToolkit.Common.Services
{
    public interface IMemberServices
    {
        #region Endpoint urls

        string AddMemberUrl { get; set; }

        string ListMembersUrl { get; set; }

        string SearchFilesUrl { get; set; }

        string ListFolderUrl { get; set; }

        string FileDumpUrl { get; set; }

        #endregion Endpoint urls

        IServiceResponse AddMember(IMemberData data, string authToken);

        IDataResponse ListMembers(IMemberData data, string authToken);

        IDataResponse SearchFiles(IMemberData data, string authToken);

        IDataResponse ListFolders(IMemberData data, string authToken);

        IDataResponse DumpFile(IMemberData data, string outputFolder, string authToken);
    }
}