using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace DfBAdminToolkit.Common.Utils
{
    public static class FileUtil
    {
        public static Dictionary<string, string> stateToAbbrev = new Dictionary<string, string>() { { "alabama", "AL" }, { "alaska", "AK" }, { "arizona", "AZ" }, { "arkansas", "AR" }, { "california", "CA" }, { "colorado", "CO" }, { "connecticut", "CT" }, { "delaware", "DE" }, { "district of columbia", "DC" }, { "florida", "FL" }, { "georgia", "GA" }, { "hawaii", "HI" }, { "idaho", "ID" }, { "illinois", "IL" }, { "indiana", "IN" }, { "iowa", "IA" }, { "kansas", "KS" }, { "kentucky", "KY" }, { "louisiana", "LA" }, { "maine", "ME" }, { "maryland", "MD" }, { "massachusetts", "MA" }, { "michigan", "MI" }, { "minnesota", "MN" }, { "mississippi", "MS" }, { "missouri", "MO" }, { "montana", "MT" }, { "nebraska", "NE" }, { "nevada", "NV" }, { "new hampshire", "NH" }, { "new jersey", "NJ" }, { "new mexico", "NM" }, { "new york", "NY" }, { "north carolina", "NC" }, { "north dakota", "ND" }, { "ohio", "OH" }, { "oklahoma", "OK" }, { "oregon", "OR" }, { "pennsylvania", "PA" }, { "rhode island", "RI" }, { "south carolina", "SC" }, { "south dakota", "SD" }, { "tennessee", "TN" }, { "texas", "TX" }, { "utah", "UT" }, { "vermont", "VT" }, { "virginia", "VA" }, { "washington", "WA" }, { "west virginia", "WV" }, { "wisconsin", "WI" }, { "wyoming", "WY" } };
        public static Dictionary<string, string> abbrevToState = new Dictionary<string, string>() { { "AK", "alaska" }, { "AL", "alabama" }, { "AR", "arkansas" }, { "AZ", "arizona" }, { "CA", "california" }, { "CO", "colorado" }, { "CT", "connecticut" }, { "DC", "district of columbia" }, { "DE", "delaware" }, { "FL", "florida" }, { "GA", "georgia" }, { "HI", "hawaii" }, { "IA", "iowa" }, { "ID", "idaho" }, { "IL", "illinois" }, { "IN", "indiana" }, { "KS", "kansas" }, { "KY", "kentucky" }, { "LA", "louisiana" }, { "MA", "massachusetts" }, { "MD", "maryland" }, { "ME", "maine" }, { "MI", "michigan" }, { "MN", "minnesota" }, { "MO", "missouri" }, { "MS", "mississippi" }, { "MT", "montana" }, { "NC", "north carolina" }, { "ND", "north dakota" }, { "NE", "nebraska" }, { "NH", "new hampshire" }, { "NJ", "new jersey" }, { "NM", "new mexico" }, { "NV", "nevada" }, { "NY", "new york" }, { "OH", "ohio" }, { "OK", "oklahoma" }, { "OR", "oregon" }, { "PA", "pennsylvania" }, { "RI", "rhode island" }, { "SC", "south carolina" }, { "SD", "south dakota" }, { "TN", "tennessee" }, { "TX", "texas" }, { "UT", "utah" }, { "VA", "virginia" }, { "VT", "vermont" }, { "WA", "washington" }, { "WI", "wisconsin" }, { "WV", "west virginia" }, { "WY", "wyoming" } };

        public static string FormatFileSize(long size) {
            int[] limits = new int[] { 1024 * 1024 * 1024, 1024 * 1024, 1024 };
            string[] units = new string[] { "GB", "MB", "KB" };

            for (int i = 0; i < limits.Length; i++) {
                if (size >= limits[i]) {
                    return string.Format("{0:#,##0.##} " + units[i], ((double)size / limits[i]));
                }
            }

            return string.Format("{0} bytes", size);
        }

        public static decimal FormatFileSizeMB(decimal size)
        {
            //returns in MB to 2 decimal places
            decimal limits = 1048576;
            decimal newsize = 0;

            newsize =  (size / limits);
            newsize = System.Math.Round(newsize, 2);

            return newsize;
        }

        public static double FormatFileSizeTB(UInt64 size)
        {
            //returns in TB to 2 decimal places as a double
            ulong limits = 1099511627776;
            double newsize = 0;

            newsize = (double)size / limits;
            newsize = Math.Round(newsize, 2);

            return newsize;
        }

        public static string ConvertStateToAbbreviation(string stateName)
        {
            stateName = stateName.ToLower();
            if (string.IsNullOrEmpty(stateName))
            {
                return null;
            }
            else if (stateName.Length == 2)
            {
                if (abbrevToState.ContainsKey(stateName.ToUpper()))
                    return abbrevToState[stateName.ToUpper()];
                else
                    return null;
            }
            else if (stateToAbbrev.ContainsKey(stateName.ToLower()))
            {
                return stateToAbbrev[stateName.ToLower()];
            }
            return null;
        }

        public static void EncryptAppSettings(string section)
        {
            Configuration objConfig = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "DfBAdminToolkit.exe");
            AppSettingsSection objAppsettings = (AppSettingsSection)objConfig.GetSection(section);
            if (!objAppsettings.SectionInformation.IsProtected) {
                objAppsettings.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                objAppsettings.SectionInformation.ForceSave = true;
                objConfig.Save(ConfigurationSaveMode.Modified);
            }
        }

        public static string GetAppPath()
        {
            Module[] modules = Assembly.GetExecutingAssembly().GetModules();
            string location = System.IO.Path.GetDirectoryName(modules[0].FullyQualifiedName);
            if ((location != "") && (location[location.Length - 1] != '\\'))
                location += '\\';
            return location;
        }

        public static void UpdateKey(string keyName, string newValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "DfBAdminToolkit.exe");
            config.AppSettings.Settings[keyName].Value = newValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        public static bool TokenCheck()
        {
            bool result = true;
            string newValue = string.Empty;
            Configuration config = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "DfBAdminToolkit.exe");
            newValue = config.AppSettings.Settings["DefaultAccessToken"].Value;
            if (newValue.StartsWith("ENTER")) {
                result = false;
            }
            return result;
        }

        public static bool ConfigCheck()
        {
            bool result = false;
            string newValue = string.Empty;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Configuration config = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "DfBAdminToolkit.exe");
            if (ConfigurationManager.AppSettings["ConfigVersion"] != null)
            {
                newValue = config.AppSettings.Settings["ConfigVersion"].Value;
            }   
            if (newValue == version)
            {
                result = true;
            }
            return result;
        }

        public static void ResetConfigMechanism()
        {
            typeof(ConfigurationManager)
                .GetField("s_initState", BindingFlags.NonPublic |
                                         BindingFlags.Static)
                .SetValue(null, 0);

            typeof(ConfigurationManager)
                .GetField("s_configSystem", BindingFlags.NonPublic |
                                            BindingFlags.Static)
                .SetValue(null, null);

            typeof(ConfigurationManager)
                .Assembly.GetTypes()
                .Where(x => x.FullName ==
                            "System.Configuration.ClientConfigPaths")
                .First()
                .GetField("s_current", BindingFlags.NonPublic |
                                       BindingFlags.Static)
                .SetValue(null, null);
        }
    }
}