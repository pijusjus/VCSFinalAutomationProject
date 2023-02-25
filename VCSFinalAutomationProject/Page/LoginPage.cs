using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace VCSFinalAutomationProject.Page
{
    public class LoginPage : BasePage
    {
        private const string AdressUrl = "https://elektromarkt.lt";
        private IWebElement loginButton => Driver.FindElement(By.XPath("//*[@id=\"top\"]/div[2]/div[2]/div[1]/div/div/div[5]/a[1]"));
        private IWebElement inputEmailField => Driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/div[2]/input"));
        private IWebElement inputPasswordField => Driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/div[3]/input"));
        private IWebElement loginAction => Driver.FindElement(By.Id("button-login"));
        private IWebElement positiveResult => Driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[1]"));


        public LoginPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public void NavigateToPage()
        {
            Driver.Url = AdressUrl;
        }
        public void ClickLoginButton()
        {
            loginButton.Click();
        }
        public void InsertEmailToInputField(string myEmail)
        {
            inputEmailField.SendKeys(myEmail);
        }
        public void InsertPasswordInputs(string myPassword)
        {
            inputPasswordField.SendKeys(myPassword);
        }

        public void LoginAction()
        {
            loginAction.Click();
        }

        public void VerifyResult(string resultText)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]/div[5]/div[2]/div[2]/div/h1")));
            Assert.AreEqual(resultText, positiveResult.Text, "Invalid Credentials");
        }

    }
}


