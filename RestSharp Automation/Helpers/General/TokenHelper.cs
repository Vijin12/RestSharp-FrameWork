using RestSharp;
using Newtonsoft.Json.Linq;

namespace RestSharp_Automation.Helpers.General
{
    public static class TokenHelper
    {
        public static string? ExtractToken(RestResponse response)
        {
            var json = JObject.Parse(response.Content!.ToString());
            var token = json.First?.FirstOrDefault();
            if (token != null)
            {
                return token.ToString().Replace("{", "");
            }
            return null;
        }
    }
}
