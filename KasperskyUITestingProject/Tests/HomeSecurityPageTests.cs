using KasperskyUITestingProject.Preparation;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyUITestingProject.Tests
{
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
}
