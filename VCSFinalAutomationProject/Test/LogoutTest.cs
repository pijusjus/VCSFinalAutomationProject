using NUnit.Framework;
using VCSFinalAutomationProject.Page;

namespace VCSFinalAutomationProject.Test
{
    public class LogoutTest : BaseTest
    {
        [Test]
        public static void TestLogout()
        {
            logoutPage.NavigateToPage();
            loginPage.AcceptCookies();
            loginPage.ClickLoginButton();
            loginPage.InsertEmailToInputField("kristupas.jusys+03@gmail.com");
            loginPage.InsertPasswordInputs("Tester123!");
            loginPage.LoginAction();
            logoutPage.ClickLogoutButton();
            logoutPage.VerifyResult("Jūs atsijungėte nuo savo paskyros. Dabar saugu palikti kompiuterį be priežiūros.");
            
        }
    }
}