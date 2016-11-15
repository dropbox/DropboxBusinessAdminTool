using System;
using System.Text;
using System.Security.Cryptography;

namespace DfBAdminToolkit.Common.Extensions
{
    public static class StringExtension
    {
        public static string Encrypt(
        this string clearText,
        string optionalEntropy = null,
        DataProtectionScope scope = DataProtectionScope.LocalMachine)
        {
            if (clearText == null)
                throw new ArgumentNullException("Clear text is null");
            byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);
            byte[] entropyBytes = string.IsNullOrEmpty(optionalEntropy)
                ? null
                : Encoding.UTF8.GetBytes(optionalEntropy);
            byte[] encryptedBytes = ProtectedData.Protect(clearBytes, entropyBytes, scope);
            string encryptedString = "encrypted-" + Convert.ToBase64String(encryptedBytes);
            return encryptedString;
        }

        public static string Decrypt(
            this string encryptedText,
            string optionalEntropy = null,
            DataProtectionScope scope = DataProtectionScope.LocalMachine)
        {
            if (encryptedText == null)
                throw new ArgumentNullException("Encrypted text is null");
            //remove encrypted- tag from beginning
            encryptedText = encryptedText.Remove(0, 10);
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] entropyBytes = string.IsNullOrEmpty(optionalEntropy)
                ? null
                : Encoding.UTF8.GetBytes(optionalEntropy);
            byte[] clearBytes = ProtectedData.Unprotect(encryptedBytes, entropyBytes, scope);
            return Encoding.UTF8.GetString(clearBytes);
        }
    }
}
