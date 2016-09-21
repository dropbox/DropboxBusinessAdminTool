namespace DfBAdminToolkit
{
    public static class ErrorMessages
    {
        public readonly static string DLG_DEFAULT_TITLE = "Dropbox Business Admin Toolkit";
        public readonly static string MISSING_QUERYSTRING = "You must enter a query string first.";
        public readonly static string INVALID_TOKEN = "You must provide a valid access token first";
        public readonly static string INVALID_TOKEN_AND_USER = "You must provide a valid access token, and select a user from the list.";
        public readonly static string INVALID_DUMP_FILE_SELECTION = "You must choose at least one file to dump locally.";
        public readonly static string INVALID_CSV_FILE = "Please provide a valid CSV file.";
        public readonly static string MISSING_CSV_FILE = "Selected CSV file no longer exists.";
        public readonly static string INVALID_CSV_DATA = "CSV file contains invalid data.";
        public readonly static string FAILED_TO_ADD_MEMBER = "Bad request to the API, possibly due to no permissions on your app to add members.";
        public readonly static string FAILED_TO_REMOVE_MEMBER = "Bad request to the API, possibly due to no permissions on your app to remove members.";
        public readonly static string FAILED_TO_SUSPEND_MEMBER = "Bad request to the API, possibly due to no permissions on your app to suspend members.";
        public readonly static string FAILED_TO_UNSUSPEND_MEMBER = "Bad request to the API, possibly due to no permissions on your app to unsuspend members.";
        public readonly static string FAILED_TO_UPDATE_PROFILE = "Bad request to the API, possibly due to no permissions on your app to update profiles.";
        public readonly static string USER_NOT_FOUND = "No matching user found. The provided email does not exist on this team.";
        public readonly static string USER_NOT_IN_TEAM = "The user is not a member of this team.";
        public readonly static string MISSING_ROLE = "Please select a user role first.";
        public readonly static string MISSING_OUTPUT_FOLDER = "Please select output directory first.";
        public readonly static string MISSING_FILES = "Please list file(s) first. You can do this by right-click and choose [ List file(s) ] option.";
        public readonly static string CONFIRM_DELETE = "Are you sure you want to remove this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_DELETE_KEEP_ACCOUNT = "Are you sure you would like these users to keep their accounts active? Their accounts will be downgraded to Dropbox Basic and you will no longer have ownership of account data.";
        public readonly static string CONFIRM_SUSPEND = "Are you sure you want to suspend this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_UNSUSPEND = "Are you sure you want to unsuspend this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_SET_PROFILE = "Are you sure you want to update profiles on this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_SEND_WELCOME_EMAIL = "Warning: Please consult your Dropbox account team prior to disabling welcome emails. Please ensure that your domains are verified and single sign-on (SSO) is enabled and set to required in the Dropbox admin console if you decide to use this feature.";
        public readonly static string MISSING_TOKEN = "You must go to File->Settings to add your app tokens before performing any actions in the toolkit.";
        public readonly static string INVALID_EXPORT_FOLDER = "Directory to export report file is not found.";
        public readonly static string FAILED_TO_GET_GROUPS = "Bad request to the API, possibly due to no permissions to get groups.";
        public readonly static string FAILED_TO_CREATE_GROUP = "Bad request to the API, possibly due to no permissions on your app to create groups.";
        public readonly static string FAILED_TO_CREATE_GROUP_GROUP_EXISTS = "Group was not created. Reason: Group name already exists.";
        public readonly static string FAILED_TO_CREATE_GROUP_GROUP_INVALID = "Group was not created. Reason: Group name was invalid.";
        public readonly static string FAILED_TO_ADD_MEMBER_TO_GROUP = "Bad request to the API, possibly due to no permissions on your app to add members to groups.";
        public readonly static string FAILED_TO_DELETE_MEMBER_FROM_GROUP = "Bad request to the API, possibly due to no permissions on your app to delete members from groups.";
        public readonly static string FAILED_TO_GET_TEAMFOLDERS = "Bad request to the API, possibly due to no permissions to get team folders.";
        public readonly static string FAILED_TO_CREATE_TEAMFOLDER = "Bad request to the API, possibly due to no permissions on your app to create team folders.";
        public readonly static string FAILED_TO_UPDATE_TEAM_FOLDER_STATUS = "Bad request to the API, possibly due to no permissions on your app to update team folder status.";
    }
}