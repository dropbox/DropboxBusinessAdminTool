namespace DfBAdminToolkit.Common.Services {
    public interface IMemberServices {

        #region Endpoint urls

        string AddMemberUrl { get; set; }

        string RemoveMemberUrl { get; set; }

        string ListMembersUrl { get; set; }

        string ListMembersContinuationUrl { get; set; }

        string SearchFilesUrl { get; set; }

        string ListFolderUrl { get; set; }

        string FileDumpUrl { get; set; }

        string GetDevicesUrl { get; set; }

        string DumpDevicesUrl { get; set; }

        #endregion Endpoint urls

        IServiceResponse AddMember(IMemberData data, string authToken);

        IServiceResponse RemoveMember(IMemberData data, string authToken);

        IDataResponse ListMembers(IMemberData data, string authToken);

        IDataResponse SearchFiles(IMemberData data, string authToken);

        IDataResponse ListFolders(IMemberData data, string authToken);

        IDataResponse DumpFile(IMemberData data, string outputFolder, string authToken);

        IDataResponse FindDevices(IMemberData data, string authToken);

        IDataResponse DumpDevices(IMemberData data, string authToken);
    }
}