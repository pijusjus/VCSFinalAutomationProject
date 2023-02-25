﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSFinalAutomationProject.Page
{
    public class LogoutPage : BasePage
    {
        private const string AdressUrl = "https://elektromarkt.lt";
        private IWebElement logoutButton => Driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[4]/a"));
        private IWebElement logoutMessage => Driver.FindElement(By.XPath("//*[@id=\"content\"]/p[1]"));
        

        public LogoutPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public void NavigateToPage()
        {
            Driver.Url = AdressUrl;
        }
        public void ClickLogoutButton()
        {
            logoutButton.Click();
        }
        public void VerifyResult(string resultText)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/p[1]")));
            Assert.AreEqual(resultText, logoutMessage.Text);
        }
    }
}