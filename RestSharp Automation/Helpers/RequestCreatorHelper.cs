using RestSharp;
using RestSharp_Automation.DTO;
using RestSharp_Automation.Helpers.General;
using static RestSharp_Automation.Constants.TestConstants;

namespace RestSharp_Automation.Helpers
{
    public static class RequestCreatorHelper
    {
        public static string CreateUser(string? Name = null, string? Job = null)
        {
            var resRequest = new RestRequest();
            var jsonObj = JsonHelper.ParseJson<CreateUserDTO>(CreateUserJsonPath);
            Name = jsonObj.Name;
            Job = jsonObj.Job;
            var payload = JsonHelper.Serialize(jsonObj);
            return payload;
        }
    }
}
