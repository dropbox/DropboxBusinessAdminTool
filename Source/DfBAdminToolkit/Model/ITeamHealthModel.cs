namespace DfBAdminToolkit.Model {

    using System;

    public interface ITeamHealthModel
        : IModel {

        string AccessToken { get; set; }

        DateTime RefreshDateTime { get; set; }

        string TeamName { get; set; }

        string LicensedUsers { get; set; }

        string ProvisionedUsers { get; set; }

        string TotalUsage { get; set; }

        string SharedUsage { get; set; }

        string UnsharedUsage { get; set; }

        string SharedFolders { get; set; }

        string ActiveSharedFolders7Day { get; set; }

        string ActiveUsers7Day { get; set; }

        string Adds { get; set; }

        string Edits { get; set; }

        string Deletes { get; set; }

        string windows { get; set; }

        string macos { get; set; }

        string linux { get; set; }

        string ios { get; set; }

        string android { get; set; }

        string other { get; set; }

        string total { get; set; }
    }
}