namespace DfBAdminToolkit.Common.Services
{
    public interface IMemberData
        : IData
    {
        #region Provision

        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        bool SendWelcomeEmail { get; set; }

        string MemberId { get; set; }

        string RoleName { get; set; }

        #endregion Provision

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

        #endregion Dump related
    }
}