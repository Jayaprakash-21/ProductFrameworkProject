using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using ProductFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFrameworkProject.Pages
{
    class ContactusPage:BaseClass
    {
        IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Contact us")]
        IWebElement Contacts;

        [Obsolete]
        public ContactusPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void contactpage()
        {
            Contacts.Click();
            String title1=driver.Title;
            Console.WriteLine(title1);
            
        }
    }
}
