using KasperskyUITestingProject.PageObjects;
using KasperskyUITestingProject.Preparation;
using KasperskyUITestingProject.Preparations;
using OpenQA.Selenium;

namespace KasperskyUITestingProject
{
    [TestFixture]
    public class MainPageTests : PrepMainPage
    {
        [Test]
        public void MainPageHomeSecurityTitleTest()
        {
            var mainPage = new MainPage(webDriver);
            Assert.That(mainPage.MainPageGetTitle(), Is.EqualTo(Resources.titleMainPageHomeSecurity), "Title is wrong.");
        }

        [Test]
        public void MainPageBusinessTitleTest()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ChangeToggleForBuisness();
            Assert.That(mainPage.MainPageGetTitle(), Is.EqualTo(Resources.titleMainPageBusiness), "Title is wrong.");
        }

        [Test]
        public void EnglishTitleTest()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.ChangeLanguage();
            Assert.That(mainPage.MainPageGetTitle(), Is.EqualTo(Resources.titleEnglish), "Title is wrong.");
        }

        [Test]
        public void GoToHomeSecurityPageTest()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.GoToHomeSecurityPage();
            Waiting.StupidWaiting();
            Assert.That(webDriver.Url, Is.EqualTo(Resources.homeSecurityUrl));
        }

        [Test]
        public void GoToRenewalPageTest()
        {
            var mainPage = new MainPage(webDriver);
            mainPage.GoToRenewalPage();
            Waiting.StupidWaiting();
            Assert.That(webDriver.Url, Is.EqualTo(Resources.renewalUrl));
        }

    }

    [TestFixture]
    public class HomeSecurityTests : PrepHomeSecurityPage
    {
        [Test]
        public void CheckAllProdBtnOnHomeSecurityPage()
        {
            CheckIsThereElementById(Resources.allProductsBtn);
        }

        [Test]
        public void CheckWinProdBtnOnHomeSecurityPage()
        {
            CheckIsThereElementById(Resources.productsForWin);
        }

        [Test]
        public void CheckMacProdBtnOnHomeSecurityPage()
        {
            CheckIsThereElementById(Resources.productsForMac);
        }

        [Test]
        public void CheckAndroidProdBtnOnHomeSecurityPage()
        {
            CheckIsThereElementById(Resources.productsForAndroid);
        }

        [Test]
        public void CheckAppleProdBtnOnHomeSecurityPage()
        {
            CheckIsThereElementById(Resources.productsForApple);
        }

        public void CheckIsThereElementById(string id)
        {
            var button = By.Id(id);
            bool result;
            try
            {
                webDriver.FindElement(button);
                result = true;
            }
            catch (NoSuchElementException)
            {
                result = false;
            }
            Assert.IsTrue(result);
        }
    }

    [TestFixture]
    public class RenewalTests : PrepRenewalPage
    {
        [Test]
        public void InputWrongKeyTest()
        {
            var renewalPage = new RenewalPage(webDriver);
            renewalPage.InputKey(Resources.wrongKey);
            string currentMessage = renewalPage.GetErrorMessage();
            Assert.That(currentMessage, Is.EqualTo(Resources.wrongKeyErrorMessage));
        }

        [Test]
        public void SwipeGuideTest()
        {
            var renewalPage = new RenewalPage(webDriver);
            Assert.IsTrue(renewalPage.GuideWorks());
        }

        [Test]
        public void GoToAntivirusPageTest()
        {
            var renewalPage = new RenewalPage(webDriver);
            renewalPage.GoToAntivirusPage();
            Waiting.StupidWaiting();
            Assert.That(webDriver.Url, Is.EqualTo(Resources.antivirusPageUrl));
        }

        [Test]
        public void GoToInternetSecurityPageTest()
        {
            var renewalPage = new RenewalPage(webDriver);
            renewalPage.GoInternetSecurityPage();
            Waiting.StupidWaiting();
            Assert.That(webDriver.Url, Is.EqualTo(Resources.internetSecurityPageUrl));
        }

        [Test]
        public void GoToTotalSecurityPageTest()
        {
            var renewalPage = new RenewalPage(webDriver);
            renewalPage.GoToTotalSecurityPage();
            Waiting.StupidWaiting();
            Assert.That(webDriver.Url, Is.EqualTo(Resources.totalSecurityPageUrl));
        }
    }
}