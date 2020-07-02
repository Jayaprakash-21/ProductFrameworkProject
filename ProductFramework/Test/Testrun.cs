using NUnit.Framework;
using OpenQA.Selenium;
using ProductFramework.Pages;
using ProductFrameworkProject.Pages;
using System;

namespace ProductFramework.Test
{
    class Testrun : BaseClass
    {       
      
        [Test]
        [Obsolete]
        public void Test1()
        {
            mp.menupage();
            mp.validation();

            sp.signinpage("Jayaprakash778@gmail.com","Jay2151984");
            pp.profilePage();
            abp.aboutUsPage();
            cp.contactpage();
            fp.feedback();

        }
 
        static void Main(String[] args)
        {

        }
    }
}
