using Newtonsoft.Json;
using static RestSharp_Automation.Constants.TestConstants;

namespace RestSharp_Automation.Helpers.General
{
    public static class JsonHelper
    {
        public static T? ParseJson<T>(string file) => JsonConvert.DeserializeObject<T>(File.ReadAllText($"{JsonBaseDirectory()}\\{file}"));
        public static string Serialize(dynamic payload) => JsonConvert.SerializeObject(payload, Formatting.Indented);
        public static void WriteJson(string jsonFile, string jsonContent) => File.WriteAllText($"{JsonBaseDirectory()}\\{jsonFile}", jsonContent);
    }
}
