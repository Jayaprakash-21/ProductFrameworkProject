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
    class FeedbackPage:BaseClass
    {
        IWebDriver driver;
        [FindsBy(How = How.LinkText, Using = "Feedback")]
        IWebElement Feedback;

        [FindsBy(How = How.Id, Using = "name")]
        IWebElement name;

        [FindsBy(How = How.Id, Using = "mobile")]
        IWebElement mobile;

        [FindsBy(How = How.Id, Using = "feedback")]
        IWebElement comments;

        [FindsBy(How = How.Name, Using = "submit")]
        IWebElement submit;

        [Obsolete]
        public FeedbackPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void feedback()
        {
            Feedback.Click();
            name.SendKeys("Deepa");
            mobile.SendKeys("123456789");
            comments.SendKeys("Very nice product");
            submit.Click();
        }
    }
}
