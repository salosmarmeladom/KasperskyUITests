using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.PageObjects
{
    public class HomeSecurityPage
    {
        private IWebDriver webDriver;

        public HomeSecurityPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
