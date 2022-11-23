using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KasperskyUITestingProject.PageObjects
{
    public class RenewalPage
    {
        private IWebDriver webDriver;

        private readonly By inputField = By.XPath(Resources.inputKeyXPath);
        private readonly By errorMessage = By.XPath(Resources.wrongKeyErrorMessageXPath);
        private readonly By submitKeyButton = By.CssSelector(Resources.submitKeyBtnCss);
        private readonly By goToAntivirusPageBtn = By.XPath(Resources.goToAntivirusPageBtnXPath);
        private readonly By goToInternetSecurityPageBtn = By.XPath(Resources.goToInternetSecurityPageBtnXPath);
        private readonly By goToTotalSecurityPageBtn = By.XPath(Resources.goToTotalSecurityPageBtnXPath);
        private readonly By ToTheLeftBtn = By.XPath(Resources.ToTheLeftBtnXPath);
        private readonly By ToTheRightBtn = By.XPath(Resources.ToTheRightBtnXPath);

        public RenewalPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void InputKey (string key)
        {
            Waiting.WaitUntilFinded(webDriver); 
            webDriver.FindElement(inputField).SendKeys(key);
            Waiting.WaitUntilFinded(webDriver); 
            webDriver.FindElement(submitKeyButton).Click();
        }

        public string GetErrorMessage()
        {
            Waiting.WaitUntilFinded(webDriver);
            string message = webDriver.FindElement(errorMessage).Text;
            return message;
        }

        public AntivirusPage GoToAntivirusPage()
        {
            Waiting.WaitUntilFinded(webDriver);
            var element = webDriver.FindElement(goToAntivirusPageBtn);
            JSClickBtn(element);
            return new AntivirusPage(webDriver);
        }

        public InternetSecurityPage GoInternetSecurityPage()
        {
            Waiting.WaitUntilFinded(webDriver);
            var element = webDriver.FindElement(goToInternetSecurityPageBtn);
            JSClickBtn(element);
            return new InternetSecurityPage(webDriver);
        }

        public TotalSecurityPage GoToTotalSecurityPage()
        {
            Waiting.WaitUntilFinded(webDriver);
            var element = webDriver.FindElement(goToTotalSecurityPageBtn);
            JSClickBtn(element);
            return new TotalSecurityPage(webDriver);
        }

        public bool GuideWorks()
        {
            string[] guideText = new string[] {Resources.firstGuidePicTxt, Resources.secondGuidPicTxt,
                                           Resources.thirdGuidPicTxt, Resources.fourthGuidPicTxt};

            for (int x = 0; x < 4; x++)
            {
                if (!EqualGuideTexts(x, guideText[x])) return false;
                if(x < 3) Swipe(ToTheRightBtn);
                Waiting.StupidWaiting();
            }

            for (int x = 3; x >= 0; x--)
            {
                if (!EqualGuideTexts(x, guideText[x])) return false;
                if (x > 0) Swipe(ToTheLeftBtn);
                Waiting.StupidWaiting();
            }
            return true;
        }

        public void Swipe(By btn)
        {
            var element = webDriver.FindElement(btn);
            JSClickBtn(element);
        }

        public bool EqualGuideTexts(int ind, string guideText)
        {
            string XPath = ($"//div[@data-index='{ind}']");
            Waiting.WaitUntilFinded(webDriver);
            string currentText = webDriver.FindElement(By.XPath(XPath)).Text;
            return (currentText == guideText);
        }           

        public void JSClickBtn(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("arguments[0].click()", element);
        }
    }
}
