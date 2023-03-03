using RestSharp;

namespace RestSharp_Automation.Helpers
{
    public static class RequestHelper
    {
        public static RestResponse GetAllUser()
        {
            return ResponseHelper.GetAllUserResponse();
        }
        public static RestResponse CreateUserResponse()
        {
            return ResponseHelper.createuser();
        }
    }
}
