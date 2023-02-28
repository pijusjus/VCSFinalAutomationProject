using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace VCSFinalAutomationProject.Page
{
    public class RegistrationPage : BasePage
    {

        private const string AdressUrl = "https://elektromarkt.lt/registracija";
        private IWebElement inputFirstName => Driver.FindElement(By.Id("input-firstname"));
        private IWebElement inputLastName => Driver.FindElement(By.Id("input-lastname"));
        private IWebElement inputEmailField => Driver.FindElement(By.Id("input-email"));
        private IWebElement inputPhoneField => Driver.FindElement(By.Id("input-telephone"));
        private IWebElement inputPasswordField => Driver.FindElement(By.Id("input-password"));
        private IWebElement inputRepeatPassword => Driver.FindElement(By.Id("input-confirm"));
        private IWebElement radioSubscribe => Driver.FindElement(By.CssSelector("#content > form > fieldset:nth-child(3) > div > div > label:nth-child(1) > input[type=radio]"));
        private IWebElement termsAccept => Driver.FindElement(By.CssSelector("#content > form > input[type=checkbox]"));
        private IWebElement continueButton => Driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/div/input"));
        private IWebElement positiveResult => Driver.FindElement(By.CssSelector("#main > div.breadcrumb.full-width > div.background > div.pattern > div > h1"));
        private IWebElement removeAd => Driver.FindElement(By.XPath("//*[@id=\"bottom_banner_x\"]"));

        public RegistrationPage(IWebDriver webdriver) : base(webdriver) {}
        public void NavigateToPage()
        {
            Driver.Url = AdressUrl;
        }
        public void InputFirstName(string firstName)
        {
            inputFirstName.SendKeys(firstName);
        }
        public void InputLastName(string lastName)
        {
            inputLastName.SendKeys(lastName);
        }

        public void InputEmailField(string myEmail)
        {
            inputEmailField.SendKeys(myEmail);
        }
        public void InputPhoneField(string phoneNumber)
        {
            inputPhoneField.SendKeys(phoneNumber);
        }

        public void InputPasswordField(string myPassword)
        {
            inputPasswordField.SendKeys(myPassword);
        }

        public void InputRepeatPassword(string repeatPassword)
        {
            inputRepeatPassword.SendKeys(repeatPassword);
        }
        public void RemoveAd()
        {
            removeAd.Click();
        }
        public void RadioSubscibe()
        {
            radioSubscribe.Click();
        }
        public void AcceptTerms()
        {
            termsAccept.Click();
        }
        public void ContinueButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"content\"]/form/div/div/input")));
            continueButton.Click();
        }
        public void VerifyResult(string resultText)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]")));
            Assert.AreEqual(resultText, positiveResult.Text, "Account already exists");
        }
    }
}