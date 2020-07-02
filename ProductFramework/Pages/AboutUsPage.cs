using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProductFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductFrameworkProject.Pages
{
    class AboutUsPage:BaseClass
    {
        IWebDriver driver;
        [FindsBy(How = How.LinkText,Using ="About Us")]
        IWebElement AboutUs;

        [FindsBy(How = How.Id, Using = "txtArea")]
        IWebElement Location;

        [FindsBy(How = How.Id, Using = "a1")]
        IWebElement Area;

        [FindsBy(How = How.Name, Using = "submit")]
        IWebElement Submit;

        [Obsolete]
        public AboutUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void aboutUsPage()
        {
            AboutUs.Click();
            Thread.Sleep(3000);
            Location.Click();
            Area.Click();
            Submit.Click();
        }

    }
}
