using RestSharp_Automation;

namespace TigerView.ImageShare.API.Tests.General
{
    [TestClass]
    public class AssemblySetup
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context) =>
            Report.SetupExtentreport("API tesing", "Test Report");
        [AssemblyCleanup]
        public static void AssemblyCleanup() => Report.Flushreport();
    }
}
