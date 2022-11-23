using KasperskyUITestingProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.Preparations
{
    public class PrepRenewalPage
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void DoBeforeAllTests()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(Resources.KasperskyURL);
            var renewalPage = new MainPage(webDriver).GoToRenewalPage();
        }

        [SetUp]
        public void DoBeforeEachTest()
        {
            
        }

        [TearDown]
        public void DoAfterEachTest()
        {
            webDriver.Navigate().GoToUrl(Resources.renewalUrl);
            webDriver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void DoAfterAllTests()
        {
            webDriver.Quit();
        }
    }
}
