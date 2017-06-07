namespace DfBAdminToolkit
{
    public static class Tooltips
    {
        public static readonly string PROVISION_MEMBER_ONLY = "User is not an admin of the team.";
        public static readonly string PROVISION_USER_MGMT_ADMIN = "User can do most user provisioning, de-provisioning and management.";
        public static readonly string PROVISION_SUPPORT_ADMIN = "User can do a limited set of common support tasks for existing users.";
        public static readonly string PROVISION_TEAM_ADMIN = "User is administrator of the team - has all permissions.";

        public static readonly string TOTAL_USAGE = " Sum of the shared, unshared, and datastore usages (TB). Stats shown reflect last logged day in Dropbox";
        public static readonly string SHARED_USAGE = "Combined size (TB) of team members shared folders.";
        public static readonly string UNSHARED_USAGE = "Combined size (TB) of team members' root namespaces.";
        public static readonly string SHARED_FOLDERS = "Number of shared folders owned by team members.";
        public static readonly string ACTIVE_SHARED_FOLDERS = "Number of shared folders with some activity in the last week.";
        public static readonly string ACTIVE_USERS = "Number of users who have been active in the last week.";
        public static readonly string FILE_ADDS = "Total number of adds (files and folders) by team members. .";
        public static readonly string FILE_DELETES = " Total number of deletes (files and folders) by team members.";
        public static readonly string FILE_EDITS = "Number of edits (files and folders) by team members. If the same user edits the same file multiple times this is counted as a single edit.";
        public static readonly string ACTIVE_DEVICES = "Report of the number of devices active in the last 7 days. Stats shown reflect last logged day in Dropbox.";
        public static readonly string USERS = "Total users provioned against total number of licenses.";
    }
}