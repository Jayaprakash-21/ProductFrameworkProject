using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProductFramework.Pages;
using ProductFrameworkProject.Pages;
using RelevantCodes.ExtentReports;
using System;
using NUnit.Framework.Interfaces;

namespace ProductFramework
{
    class BaseClass
    {
        
        //Initialize driver
        public IWebDriver driver;
        //Generating extent report
        public static ExtentReports extent;
        public static ExtentTest test;

        public MenuPage mp;
        public SigninPage sp;
        public ProfilePage pp;
        public AboutUsPage abp;
        public ContactusPage cp;
        public FeedbackPage fp;
       


        [OneTimeSetUp]
        [Obsolete]
        public void setup()
        {

            //Append the html report file to current project path

            string reportPath = "C:\\Users\\Jay\\source\\repos\\ProductFramework\\ProductFramework\\Reports\\TestRunReport.html";
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(reportPath, true);
            //Add QA system info to html report
            extent.AddSystemInfo("Host Name", "YourHostName")
                .AddSystemInfo("Environment", "YourQAEnvironment")
                .AddSystemInfo("Username", "YourUserName");
            //Adding config.xml file
            extent.LoadConfig("Extent-config.xml"); //Get the config.xml file from http://extentreports.com
            //launch driver and initiate browser
            driver = new ChromeDriver();
            driver.Url = "http://localhost/product/";
            mp = new MenuPage(driver);
            sp = new SigninPage(driver);
            pp = new ProfilePage(driver);
            abp = new AboutUsPage(driver);
            cp = new ContactusPage(driver);
            fp = new FeedbackPage(driver);
        }

     //   [TearDown]
        public void AfterClass()
        {
            Console.WriteLine("-------");
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                string currentDate = DateTime.Now.ToString("HHmmss");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Jay\\source\\repos\\ProductFramework\\ProductFramework\\Screenshot\\failedSS" + currentDate + ".png", ScreenshotImageFormat.Png);
                test.Log(LogStatus.Fail, status + errorMessage+ test.AddScreenCapture("C:\\Users\\Jay\\source\\repos\\ProductFramework\\ProductFramework\\Screenshot\\failedSS"));
            }
            //End test report
            extent.EndTest(test);
            //driver.Quit();
        }


        [OneTimeTearDown] 
        public void close()
        {
            driver.Quit();
            //End Report
            extent.Flush();
            extent.Close();
        }
        
        
        


    }
}
