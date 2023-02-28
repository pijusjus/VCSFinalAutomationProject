using NUnit.Framework;

namespace VCSFinalAutomationProject.Test
{
    public class LoginTest : BaseTest
    {
        [Test]
        public static void TestLogin()
        {
            loginPage.NavigateToPage();
            loginPage.AcceptCookies();
            loginPage.ClickLoginButton();
            loginPage.InsertEmailToInputField("");
            loginPage.InsertPasswordInputs("");
            loginPage.LoginAction();
            loginPage.VerifyResult("Mano duomenys");
        }
    }
}