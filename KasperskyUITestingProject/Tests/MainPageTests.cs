using KasperskyUITestingProject.PageObjects;
using KasperskyUITestingProject.Preparation;
using KasperskyUITestingProject.Preparations;
using OpenQA.Selenium;

namespace KasperskyUITestingProject.Tests

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

}