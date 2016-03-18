namespace DfBAdminToolkit.Common.Services {

    public class MemberData
        : IMemberData {

        #region Provision

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool SendWelcomeEmail { get; set; }

        public string MemberId { get; set; }

        public string RoleName { get; set; }

        public string Usage { get; set; }

        #endregion Provision

        #region Search Text

        public string SearchText { get; set; }

        public int? SearchLimit { get; set; }

        public string SearchMode { get; set; }

        public string Cursor { get; set; }

        public bool HasMore { get; set; }

        #endregion Search Text

        #region Dump related

        public string Path { get; set; }

        public string FileName { get; set; }

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