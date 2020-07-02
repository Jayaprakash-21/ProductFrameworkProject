using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProductFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFrameworkProject.Pages
{
    class ProfilePage:BaseClass
    {
         IWebDriver driver;
        [FindsBy(How = How.XPath, Using = ".//*[@id='area']/h2")]
        IWebElement Heading;

        [Obsolete]
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        public void profilePage()
        {
            String Wel_note = Heading.Text;
            Console.WriteLine(Wel_note);

        }
    }
}
