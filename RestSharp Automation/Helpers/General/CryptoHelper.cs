using System.Text;
using System.Security.Cryptography;

namespace RestSharp_Automation.Helpers.General
{
    public static class CryptoHelper
    {
        private static string EncryptionKey => EncryptionKey;
        private static string InitilizationVector => InitilizationVector;
        private static Aes GetEncryptionAlgorithm(string? encryptionKey = null, string? initilizationVector = null)
        {
            var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(encryptionKey ?? EncryptionKey); ;
            aes.IV = Encoding.UTF8.GetBytes(initilizationVector ?? InitilizationVector); ;
            return aes;
        }
        private static string TryCatch(Func<string> func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return string.Empty;
        }
        public static string Encrypt(string data, string? encryptionKey = null, string? initilizationVector = null) => TryCatch(() =>
        {
            byte[] encrypted;
            using (var aes = GetEncryptionAlgorithm(encryptionKey, initilizationVector))
            {
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using var ms = new MemoryStream();
                using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(data);
                }
                encrypted = ms.ToArray();
            }
            return Convert.ToBase64String(encrypted);
        });
        public static string Decrypt(string cipherText, string? encryptionKey = null, string? initilizationVector = null) => TryCatch(() =>
        {
            var aes = GetEncryptionAlgorithm(encryptionKey, initilizationVector);
            byte[] buffer = Convert.FromBase64String(cipherText);
            var memoryStream = new MemoryStream(buffer);
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            using var streamReader = new StreamReader(cryptoStream);
            return streamReader.ReadToEnd();
        });
        public static string ToBase64Encode(string text) => TryCatch(() =>
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            var textBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        });
        public static string ToBase64Decode(string base64EncodedText) => TryCatch(() =>
        {
            if (string.IsNullOrEmpty(base64EncodedText))
            {
                return base64EncodedText;
            }
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedText);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        });
    }
}
