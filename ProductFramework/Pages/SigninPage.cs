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
    class SigninPage:BaseClass
    {
        IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement clicklogin;
        [FindsBy(How = How.Id, Using = "email")]
        IWebElement username;
        [FindsBy(How = How.Id, Using = "pass")]
        IWebElement password;
        [FindsBy(How = How.Name, Using = "submit")]
        IWebElement submit;

        [Obsolete]
        public SigninPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);


        }

        public void signinpage(String un,String pwd)
        {
            clicklogin.Click();
            username.SendKeys(un);
            password.SendKeys(pwd);
            submit.Click();

        }
    }
}
