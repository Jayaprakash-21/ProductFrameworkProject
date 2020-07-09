using NUnit.Framework;
using OpenQA.Selenium;
using ProductFramework.Pages;
using ProductFrameworkProject.Pages;
using RelevantCodes.ExtentReports;
using System;

namespace ProductFramework.Test
{
    class Testrun : BaseClass
    {       
      
        [Test]
        [Obsolete]
        public void Test1()
        {
            //Start Report
            test = extent.StartTest("Test1"); //”SampleReporting” TestMethod name
            mp.menupage();
            mp.validation();

            sp.signinpage("Jayaprakash778@gmail.com","Jay2151984");
            pp.profilePage();
            abp.aboutUsPage();
            cp.contactpage();
            fp.feedback();
            test.Log(LogStatus.Pass, "Test Passed");
            //Pass scenario
            Assert.AreEqual(10, 10);
            test.Log(LogStatus.Pass, "Test Passed");
            //Fail scenario
            Assert.IsTrue(false);
            test.Log(LogStatus.Fail, "Test Failed");

        }
        [Test]
        public void Test2()
        {
            //Start Report
            test = extent.StartTest("Test1"); //”SampleReporting” TestMethod name
            sp.signinpage("prakash778@gmail.com", "123456");
            test.Log(LogStatus.Pass, "Test Passed for invalid credentials");
            //Pass scenario
            Assert.AreEqual(10, 10);
            test.Log(LogStatus.Pass, "Test Passed");
            //Fail scenario
            Assert.IsTrue(false);
            test.Log(LogStatus.Fail, "Test Failed");

        }
 
        static void Main(String[] args)
        {

        }
    }
}
