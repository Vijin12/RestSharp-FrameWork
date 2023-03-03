using AventStack.ExtentReports;
using RestSharp_Automation.Helpers;
using TigerView.ImageShare.API.Tests.General;

namespace RestSharp_Automation.TestCases
{
    [TestClass]
    public class GetAllUsers:TestSetup
    {
        [TestMethod]
        public void TestGetAllUser()
        {
            var response = RequestHelper.GetAllUser();
            var statusCode = (int)response.StatusCode;
            Assert.AreEqual(statusCode, 200);
            Report.Logreport(Status.Pass, "Get All user success with status code 200");
        }
        [TestMethod]
        public void TestCreateUser()
        {
            var response = ResponseHelper.CreateUserResponse();
            Assert.AreEqual("Tester",response.Name);
            Report.Logreport(Status.Pass, "User created successfully with status code 201");
        }
    }
}
