namespace DfBAdminToolkit.Common.Services {

    public class MemberData
        : IMemberData {

        #region Provision

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersistentId { get; set; }

        public bool SendWelcomeEmail { get; set; }

        public string MemberId { get; set; }

        public string RoleName { get; set; }

        public string Usage { get; set; }

        public bool KeepAccount { get; set; }

        public bool RemoveSharing { get; set; }

        public string NewEmail { get; set; }

        public string NewExternalId { get; set; }

        public string ProvisionStatus { get; set; }

        #endregion Provision

        #region Search Text

        public string SearchText { get; set; }

        public int? SearchLimit { get; set; }

        public string SearchMode { get; set; }

        public string Cursor { get; set; }

        public bool HasMore { get; set; }

        #endregion Search Text

        #region Groups

        public string GroupName { get; set; }

        public string GroupId { get; set; }

        public string MemberCount { get; set; }

        public string GroupType { get; set; }

        public string GroupEmail { get; set; }

        public string GroupAddStatus { get; set; }

        #endregion Groups

        #region Dump related

        public string Path { get; set; }

        public string FileName { get; set; }

        public bool ZipFiles { get; set; }

        public bool SuspendUser { get; set; }

        public bool DeleteUser { get; set; }

        #endregion Dump related

        #region Device related

        public string SessionId { get; set; }

        public string ClientType { get; set; }

        #endregion Device related

        public MemberData() {
            SendWelcomeEmail = false;
            RoleName = "member_only";
        }
    }
}