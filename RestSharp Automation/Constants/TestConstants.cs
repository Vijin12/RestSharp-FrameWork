namespace RestSharp_Automation.Constants
{
    public static class TestConstants
    {
        public  const string ProjectName = "Test Project";
        public const string UserName = "Test";
        public const string AESJsonPath = "";
        public const string EncryptionKey = "";
        public const string InitilizationVector = "";
        public const string TestDataPath = "Testdata\\";
        public const string CreateUserJson = "CreateUser.json";
        public const string CreateUserJsonPath = $"{TestDataPath}{CreateUserJson}";
        public static string? JsonBaseDirectory() => Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
    }
}
