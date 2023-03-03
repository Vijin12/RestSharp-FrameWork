using RestSharp_Automation;
using AventStack.ExtentReports;

namespace TigerView.ImageShare.API.Tests.General
{
    [TestClass]
    public class TestSetup : AssemblySetup
    {
        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Setuptest()
        {
            Report.CreateTest(TestContext?.TestName!);
        }
        [TestCleanup]
        public void Cleanuptest()
        {
            var testStatus = TestContext?.CurrentTestOutcome;
            Status logstatus;
            switch (testStatus)
            {
                case UnitTestOutcome.Failed:
                    logstatus = Status.Fail;
                    Report.Statusreport(logstatus.ToString());
                    break;
                case UnitTestOutcome.Inconclusive:
                    break;
                case UnitTestOutcome.Passed:
                    logstatus = Status.Pass;
                    Report.Statusreport(logstatus.ToString());
                    break;
                case UnitTestOutcome.InProgress:
                    break;
                case UnitTestOutcome.Error:
                    break;
                case UnitTestOutcome.Timeout:
                    break;
                case UnitTestOutcome.Aborted:
                    break;
                case UnitTestOutcome.Unknown:
                    break;
                case UnitTestOutcome.NotRunnable:
                    break;
                default:
                    break;
            }
        }
    }
}
