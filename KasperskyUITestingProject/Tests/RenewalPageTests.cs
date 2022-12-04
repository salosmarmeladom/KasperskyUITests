using KasperskyUITestingProject.PageObjects;
using KasperskyUITestingProject.Preparations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.Tests
{
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
