using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using static RestSharp_Automation.Constants.TestConstants;

namespace RestSharp_Automation
{
    public class Report
    {
        public static ExtentReports? Extent;
        public static ExtentTest? TestCaseName;
        public static ExtentReports? ExtentReports;
        public static ExtentHtmlReporter? HtmlReports;
        public static void SetupExtentreport(string reportname, string doctitle)
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
            HtmlReports = new ExtentHtmlReporter(path);
            HtmlReports.Config.Theme = Theme.Dark;
            HtmlReports.Config.DocumentTitle = doctitle;
            HtmlReports.Config.ReportName = reportname;
            Extent = new ExtentReports();
            Extent.AttachReporter(HtmlReports);
            Extent.AddSystemInfo("Application Under Test", ProjectName);
            Extent.AddSystemInfo("Environment", "QA");
            Extent.AddSystemInfo("Machine", Environment.MachineName);
            Extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            ExtentReports = Extent;
        }
        public static void CreateTest(string testname) => TestCaseName = ExtentReports?.CreateTest(testname);
        public static void Logreport(Status status, string message) => TestCaseName?.Log(status, message);
        public static ExtentTest? Statusreport(string status) =>
            status.Equals("Pass") ? TestCaseName?.Pass("Test is Passed") : TestCaseName?.Fail("Test is Failed");
        public static void Flushreport(string? fileName = null)
        {
            ExtentReports?.Flush();
            var rootPath = $"{Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName}\\";
            if (File.Exists($"{rootPath}TestReport.html"))
            {
                File.Delete($"{rootPath}TestReport.html");
            }
            File.Move($"{rootPath}index.html", $"{rootPath}TestReport.html");
        }

    }
}
