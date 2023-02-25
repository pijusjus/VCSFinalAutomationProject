using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace VCSFinalAutomationProject.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }
        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27PgT2uGOAELkBpBjEtzIVqAGqTZtegjfRpbXvl9Hb16uixcs+MLf7kQ==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:3%2Cutc:1666850753867%2Cregion:%27lt%27}",
                "elektromarkt.lt",
                "/",
                DateTime.Now.AddDays(3));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
        }
    }

}
