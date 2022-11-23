using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.PageObjects
{
    public class MainPage
    {
        private IWebDriver webDriver;
        private readonly By goToHomeSecurityMainButton = By.XPath(Resources.HomeSecurityGreenBtnXpath);
        private readonly By goToRenewalPageButton = By.XPath(Resources.RenewalWhiteBtnXPath);
        private readonly By changeToggleButton = By.XPath(Resources.changeToggleForBusinessBtnXPath);
        private readonly By mainPageTitle = By.XPath(Resources.mainPageTitleXPath); 
        private readonly By changeLanBtn = By.XPath(Resources.changeLanguageBtnXpath);
        private readonly By unitedStates = By.XPath(Resources.unitedStatesBtnXpath);


        public MainPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public HomeSecurityPage GoToHomeSecurityPage()
        {
            Waiting.WaitUntilFinded(webDriver);
            webDriver.FindElement(goToHomeSecurityMainButton).Click();
            return new HomeSecurityPage(webDriver);
        }

        public RenewalPage GoToRenewalPage()
        {
            Waiting.WaitUntilFinded(webDriver);
            webDriver.FindElement(goToRenewalPageButton).Click();
            return new RenewalPage(webDriver);
        }

        public void ChangeLanguage()
        {
            Waiting.WaitUntilFinded(webDriver);
            webDriver.FindElement(changeLanBtn).Click();
            Waiting.WaitUntilFinded(webDriver);
            webDriver.FindElement(unitedStates).Click();
        }

        public MainPage ChangeToggleForBuisness()
        {
            Waiting.WaitUntilFinded(webDriver);
            webDriver.FindElement(changeToggleButton).Click();
            return this;
        } 

        public string MainPageGetTitle()
        {
            Waiting.WaitUntilFinded(webDriver);
            var titleElement = webDriver.FindElement(mainPageTitle);
            Waiting.WaitUntilFinded(webDriver);
            string mainPageTitleText = titleElement.Text;
            return mainPageTitleText;
        }
    }
}
