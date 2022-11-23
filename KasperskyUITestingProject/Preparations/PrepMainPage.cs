using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.Preparation
{
    public class PrepMainPage
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void DoBeforeAllTests()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [SetUp]
        public void DoBeforeEachTest()
        {
            webDriver.Navigate().GoToUrl(Resources.KasperskyURL);
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
