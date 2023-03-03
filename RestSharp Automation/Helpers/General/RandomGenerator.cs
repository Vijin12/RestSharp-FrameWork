using static RestSharp_Automation.Constants.TestConstants;

namespace RestSharp_Automation.Helpers.General
{
    public static class RandomGenerator
    {
        public static dynamic RandomNumberGenerator() => new Random().Next();
        public static string GetUserName() => UserName + RandomNumberGenerator();
    }
}
