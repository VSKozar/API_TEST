using API_TEST.API;
using API_TEST.TestDataAccess;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace API_TEST
{
    [TestFixture]
    public class JSONPlaceholderTest
    {
        // initializing reporting
        public static ExtentReports extent;

        // the request initializing
        RestRequest request = new RestRequest();
        List<User> listOfUsers = new List<User>();

        /// <summary>
        /// JSON_Test_Suite: Preparetion. Send request. Get JSON and parsing it. Get list of Users.
        /// </summary>
        [SetUp]
        public void TestPreparation()
        {
            // initialize the HtmlReporter
            var htmlReporter = new ExtentHtmlReporter("..\\..\\Reports\\PlaceholderReport.html");

            // initialize ExtentReports and attach the HtmlReporter
            extent = new ExtentReports();

            // attach only HtmlReporter
            extent.AttachReporter(htmlReporter);

            // Create instance of API for request.
            JSONPlaceholderAPI placeholder = new JSONPlaceholderAPI();

            // Make a request
            string resultOfRequest = placeholder.Execute(request);

            // Check request result
            if (!String.Equals(resultOfRequest, "Error retrieving response."))
            {
                // Mapping from JSON to list of Users
                listOfUsers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(resultOfRequest);
            }
        }

        /// <summary>
        /// JSON_Test_Suite: Checking that 10 users were returned.
        /// </summary>
        [Test]
        public void CountUsersCheck()
        {
            var test = extent.CreateTest("CountUsersCheck");

            Assert.AreEqual(10, listOfUsers.Count);

            test.Pass("Checking that JSON returns list of 10 users");
        }

        /// <summary>
        /// JSON_Test_Suite: Checking user's names.
        /// </summary>
        [Test]
        public void CheckUserName()
        {
            var test = extent.CreateTest("CheckUserName");

            ExcelDataAccess.ReadFromFile();
            for(int item = 0; item <= ExcelDataAccess.itemList.Count - 1; item++ )
            {
                // listOfUsers - data parsed from JSON file
                // itemList - test data readed from cvs file
                Assert.AreEqual(ExcelDataAccess.itemList[item].name, listOfUsers[item].name);
            }

            test.Pass("Checking user's names");
        }

        [TearDown]
        public void EndSuite()
        {
            var status = TestContext.CurrentContext.Result.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.ToString())
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.ToString());
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            extent.AddTestRunnerLogs("Test ended with " + logstatus + stacktrace);

            // calling flush writes everything to the log file
            extent.Flush();
        }
    }
}
