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
            loginPage.InsertEmailToInputField("kristupas.jusys+03@gmail.com");
            loginPage.InsertPasswordInputs("Tester123!");
            loginPage.LoginAction();
            loginPage.VerifyResult("Mano duomenys");
        }
    }
}