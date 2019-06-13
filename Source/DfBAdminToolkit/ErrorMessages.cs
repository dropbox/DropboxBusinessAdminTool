﻿namespace DfBAdminToolkit
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
        public readonly static string FAILED_TO_RECOVER_MEMBER = "Bad request to the API, possibly due to no permissions on your app to recover members.";
        public readonly static string FAILED_TO_UPDATE_PROFILE = "Bad request to the API, possibly due to no permissions on your app to update profiles.";  
        public readonly static string USER_NOT_FOUND = "No matching user found. The provided email does not exist on this team.";
        public readonly static string USER_NOT_IN_TEAM = "The user is not a member of this team.";
        public readonly static string EMAIL_RESERVED = "Email is already reserved for another user..";
        public readonly static string EXTERNAL_ID_USED = "The external ID is already in use by another team member.";
        public readonly static string SET_PROFILE_DISALLOWED = "Pending team member's email cannot be modified.";
        public readonly static string NO_NEW_DATA_SPECIFIED = "None of new_email, new_given_name, new_surname, or new_external_id are specified.";
        public readonly static string MISSING_ROLE = "Please select a user role first.";
        public readonly static string MISSING_OUTPUT_FOLDER = "Please select output directory first.";
        public readonly static string MISSING_FILES = "Please list file(s) first. You can do this by right-click and choose [ List file(s) ] option.";
        public readonly static string CONFIRM_DELETE = "Are you sure you want to remove this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_ARCHIVE_TEAM_FOLDERS = "**WARNING** Are you sure you want to archive the selected Team Folders? Archiving selected team folders removes all members from the team folder and places the team folder in the archive tab. Archiving team Folders will remove all folder and file member permissions and permissions cannot be reinstated by the Activate feature. For more information see: https://www.dropbox.com/help/business/team-folder-manager";
        public readonly static string CONFIRM_DELETE_KEEP_ACCOUNT = "Are you sure you would like these users to keep their accounts active? Their accounts will be downgraded to Dropbox Basic and you will no longer have ownership of account data.";
        public readonly static string CONFIRM_SUSPEND = "Are you sure you want to suspend this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_UNSUSPEND = "Are you sure you want to unsuspend this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_SET_PROFILE = "Are you sure you want to update profiles on this list of members from your Dropbox Business account?";
        public readonly static string CONFIRM_RECOVER = "Are you sure you want to attempt to recover this list of members from your Dropbox Business account?";
        public readonly static string NO_TEAM_JOIN_EMAIL = "Warning: Please consult your Dropbox account team prior to disabling team join emails. Please ensure that your domains are verified and single sign-on (SSO) is enabled and set to required in the Dropbox admin console if you decide to use this feature.";
        public readonly static string MISSING_TOKEN = "You must go to File->Settings to add your app tokens before performing any actions in the toolkit.";
        public readonly static string INVALID_EXPORT_FOLDER = "Directory to export report file is not found.";
        public readonly static string FAILED_TO_GET_GROUPS = "Bad request to the API, possibly due to no permissions to get groups.";
        public readonly static string FAILED_TO_CREATE_GROUP = "Bad request to the API, possibly due to no permissions on your app to create groups.";
        public readonly static string FAILED_TO_CREATE_GROUP_GROUP_EXISTS = "Group was not created. Reason: Group name already exists.";
        public readonly static string FAILED_TO_CREATE_GROUP_GROUP_INVALID = "Group was not created. Reason: Group name was invalid.";
        public readonly static string FAILED_TO_ADD_MEMBER_TO_GROUP = "Bad request to the API, possibly due to no permissions on your app to add members to groups.";
        public readonly static string FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_FOUND = "Member was not added to group. Reason: Group not found.";
        public readonly static string FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_DUPLICATE = "Member was not added to group. Reason: Duplicate user.";
        public readonly static string FAILED_TO_DELETE_MEMBER_FROM_GROUP = "Bad request to the API, possibly due to no permissions on your app to delete members from groups.";
        public readonly static string FAILED_TO_GET_TEAMFOLDERS = "Bad request to the API, possibly due to no permissions to get team folders.";
        public readonly static string FAILED_TO_CREATE_TEAMFOLDER = "Bad request to the API, possibly due to no permissions on your app to create team folders.";
        public readonly static string FAILED_TO_UPDATE_TEAM_FOLDER_STATUS = "Bad request to the API, possibly due to no permissions on your app to update team folder status.";
        public readonly static string EXCEL_MISSING = "Excel is not properly installed on your machine.";
        public readonly static string BAD_CONFIG = "Detected an old or incorrect config file. Click OK to correct this and relaunch the Admin Toolkit (You will to have to replace your security tokens on relaunch).";
        public readonly static string FAILED_TO_GET_PAPER = "Bad request to the API, possibly due to no permissions on your app to get Paper docs.";
        public readonly static string FAILED_TO_GET_PAPER_METADATA = "Bad request to the API, possibly due to no permissions on your app to get Paper doc metadata.";
        public readonly static string FAILED_TO_DELETE_PAPER = "Bad request to the API, possibly due to no permissions on your app to delete Paper docs.";
        public readonly static string FAILED_TO_GET_EVENTS = "Bad request to the API, possibly due to no permissions on your app to get team events.";
    }

    public static class WarningMessages
    {
        public readonly static string WARN_USER_WHEN_OPENING_TOOLKIT = "The Dropbox Administrator's Toolkit is provided on an as is basis and is not supported by Dropbox. Use of the Toolkit can result in loss of data or unintended access to data. Dropbox may not be able to undo problems caused by use of the Dropbox Administrators Toolkit. Use of this tool is at your own risk.";
    }
}