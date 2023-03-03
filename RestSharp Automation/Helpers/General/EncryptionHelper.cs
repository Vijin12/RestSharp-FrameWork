using RestSharp_Automation.Models;
using static RestSharp_Automation.Constants.TestConstants;

namespace RestSharp_Automation.Helpers.General
{
    public static class EncryptionHelper
    {
        public static string Encrypt(string text)
        {
            var aes = JsonHelper.ParseJson<AESModel>(AESJsonPath);
            return CryptoHelper.Encrypt(text, aes?.EncryptionKey, aes?.InitilizationVector);
        }
        public static string Decrypt(string cipherText)
        {
            var aes = JsonHelper.ParseJson<AESModel>(AESJsonPath);
            return CryptoHelper.Decrypt(cipherText, aes?.EncryptionKey, aes?.InitilizationVector);
        }
    }
}
