using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSFinalAutomationProject.Page
{
    public class SearchPage : BasePage
    {
        private const string AdressUrl = "https://elektromarkt.lt/";
        private IWebElement searchBar => Driver.FindElement(By.XPath("//*[@id=\"search-input\"]"));
        private IWebElement searchButton => Driver.FindElement(By.XPath("//*[@id=\"top\"]/div[2]/div[2]/div[1]/div/div/div[3]/div/div[1]"));
        private IWebElement productSelect => Driver.FindElement(By.XPath("//*[@id=\"product-52977\"]"));
        private IWebElement productResult => Driver.FindElement(By.XPath("//*[@id=\"pname\"]"));
        public SearchPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            Driver.Url = AdressUrl;
        }
        public void InsertSearchField(string mySearch)
        {
            searchBar.SendKeys(mySearch);
        }
        public void SearchButtonClick()
        {
            searchButton.Click();
        }
        public void ProductSelection()
        {
            productSelect.Click();
        }
        public void VerifyResult(string resultText)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("pname")));
            StringAssert.Contains(resultText, productResult.Text);
        }
    }
}
