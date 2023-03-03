using Newtonsoft.Json;
using RestSharp;
using RestSharp_Automation.DTO;

namespace RestSharp_Automation.Helpers
{
    public static class ResponseHelper
    {
        public static RestResponse GetAllUserResponse()
        {
            var requrl = "api/users?page=2";
            var url = APIHelper.SetUrl(requrl);
            var request = APIHelper.GetAllUsers();
            var response = APIHelper.GetResponse(url,request);
            return response;
        }
        public static RestResponse createuser()
        {
            var requrl = "api/users";
            var payload = RequestCreatorHelper.CreateUser();
            var url = APIHelper.SetUrl(requrl);
            var request = APIHelper.CreateUser(payload);
            var response = APIHelper.GetResponse(url, request);
            return response;           
        }
        public static CreateUserResponseDTO CreateUserResponse()
        {
            var response = createuser();
            var Content = response.Content;
            var reqrestponse = JsonConvert.DeserializeObject<CreateUserResponseDTO>(Content);
            return reqrestponse;
        }
    }
}
