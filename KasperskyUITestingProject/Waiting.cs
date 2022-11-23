using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject
{
    public static class Waiting
    {
        public static void WaitUntilFinded(IWebDriver webDriver)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void StupidWaiting()
        {
            Thread.Sleep(2000);
        }
    }
}
