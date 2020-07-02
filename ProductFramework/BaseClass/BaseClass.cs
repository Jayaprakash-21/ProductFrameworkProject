using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProductFramework.Pages;
using ProductFrameworkProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductFramework
{
    class BaseClass
    {
        public IWebDriver driver;
       
        public MenuPage mp;
        public SigninPage sp;
        public ProfilePage pp;
        public AboutUsPage abp;
        public ContactusPage cp;
        public FeedbackPage fp;
        

        [SetUp]
        [Obsolete]
        public void setup()
        {
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
       
           
        [TearDown] 
        public void close()
        {
            driver.Quit();
        }
        
        
        


    }
}
