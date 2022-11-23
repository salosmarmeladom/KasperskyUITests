using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasperskyUITestingProject.PageObjects;

namespace KasperskyUITestingProject.Preparation
{
    public class PrepHomeSecurityPage
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void DoBeforeAllTests()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(Resources.KasperskyURL);
            var homeSecurityPage = new MainPage(webDriver).GoToHomeSecurityPage();
        }

        [SetUp]
        public void DoBeforeEachTest()
        {
            
        }

        [TearDown]
        public void DoAfterEachTest()
        {
           webDriver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void DoAfterAllTests()
        {
            webDriver.Quit();
        }
    }
}
