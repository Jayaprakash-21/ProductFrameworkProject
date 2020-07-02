using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFramework.Pages
{
    class MenuPage:BaseClass
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id='logo']")]
        public IWebElement logop;

        [Obsolete]
        public MenuPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

  
        public void menupage()
        {
            String hpTitle = driver.Title;
            Console.WriteLine(hpTitle);
            Boolean logo = logop.Enabled;
            Console.WriteLine(logo);

        }

        public void validation()
        {
           String Actual = driver.Url;
         //  Assert.AreEqual(Actual,http://localhost/product/index.php); 
             
            if (Actual.Equals("http://localhost/product/index.php"))
            {
                Console.WriteLine("Test Case Passed");
            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }
        }

    }
}
