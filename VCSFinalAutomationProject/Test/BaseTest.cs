using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using VCSFinalAutomationProject.Drivers;
using VCSFinalAutomationProject.Page;
using VCSFinalAutomationProject.Tools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace VCSFinalAutomationProject.Test
{
    public class BaseTest
    {
        protected static IWebDriver webdriver;

        protected static RegistrationPage registrationPage;
        protected static LoginPage loginPage;
        protected static SearchPage searchPage;
        protected static PurchasePage purchasePage;
        protected static LogoutPage logoutPage;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            webdriver = CustomDriver.GetChromeIncognitoDriver();
            registrationPage = new RegistrationPage(webdriver);
            loginPage = new LoginPage(webdriver);
            searchPage = new SearchPage(webdriver);
            purchasePage = new PurchasePage(webdriver);
            logoutPage= new LogoutPage(webdriver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(webdriver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            webdriver.Quit();
        }
    }
}
