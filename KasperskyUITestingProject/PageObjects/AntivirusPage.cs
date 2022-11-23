using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.PageObjects
{
    public class AntivirusPage
    {
        private IWebDriver webDriver;

        public AntivirusPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }   
    }
}
