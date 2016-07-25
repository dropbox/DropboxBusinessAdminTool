namespace DfBAdminToolkit.Common.Services {
    public interface IMemberData
        : IData {

        #region Provision

        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        bool SendWelcomeEmail { get; set; }

        string MemberId { get; set; }

        string RoleName { get; set; }

        string Usage { get; set; }

        bool KeepAccount { get; set; }

        string NewEmail { get; set; }

        string NewExternalId { get; set; }

        #endregion Provision

        #region Groups

        string GroupName { get; set; }

        string GroupId { get; set; }

        string MemberCount { get; set; }

        #endregion Groups

        #region Search Text

        string SearchText { get; set; }

        int? SearchLimit { get; set; }

        string SearchMode { get; set; }

        string Cursor { get; set; }

        bool HasMore { get; set; }

        #endregion Search Text

        #region Dump related

        string Path { get; set; }

        string FileName { get; set; }

        bool ZipFiles { get; set; }

        bool SuspendUser { get; set; }

        bool DeleteUser { get; set; }

        #endregion Dump related

        #region Device related

        string SessionId { get; set; }

        string ClientType { get; set; }

        #endregion Device related
    }
}