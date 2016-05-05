namespace DfBAdminToolkit.Common.Utils {

    using Microsoft.Win32;

    public static class RegistryUtils {

        public static RegistryKey CreateKey(string registryEntry) {
            return Registry.CurrentUser.CreateSubKey(@registryEntry);
        }

        public static RegistryKey FindKey(string lookupKey) {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@lookupKey);
            return key;
        }

        public static void SetKeyValue(RegistryKey key, string keyParam, string valueParam) {
            if (key != null && !string.IsNullOrEmpty(keyParam)) {
                key.SetValue(keyParam, valueParam);
                key.Close();
            }
        }

        public static string GetKeyValue(RegistryKey key, string keyParam) {
            string value = null;
            if (key != null) {
                value = key.GetValue(keyParam).ToString();
            }
            return value;
        }
    }
}