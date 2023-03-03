using RestSharp;

namespace RestSharp_Automation.Helpers
{
    public static class APIHelper
    {
        public static string Baseurl => "https://reqres.in/";
        public static RestResponse GetResponse(RestClient client, RestRequest request) => client.Execute(request);

        public static RestClient SetUrl(string url)
        {
            return new RestClient(Path.Combine(Baseurl, url));
        }
        public static RestRequest GetAllUsers()
        {
            var resRequest = new RestRequest();
            resRequest.Method = Method.Get;
            resRequest.AddHeader("Accept", "application/json");
            return resRequest;
        }
        public static RestRequest CreateUser(string payload)
        {
            var restRequest = new RestRequest();
            restRequest.Method = Method.Post;
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
    }
}
