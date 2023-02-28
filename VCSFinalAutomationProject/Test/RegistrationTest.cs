using NUnit.Framework;

namespace VCSFinalAutomationProject.Test
{
    public class RegistrationTest : BaseTest
    {
        [Test]
        public static void TestRegistration()
        {
            registrationPage.NavigateToPage();
            registrationPage.AcceptCookies();
            registrationPage.InputFirstName("");
            registrationPage.InputLastName("");
            registrationPage.InputEmailField("");
            registrationPage.InputPhoneField("");
            registrationPage.InputPasswordField("");
            registrationPage.InputRepeatPassword("");
            //registrationPage.RemoveAd();
            registrationPage.RadioSubscibe();
            registrationPage.AcceptTerms();
            registrationPage.ContinueButton();
            registrationPage.VerifyResult("JŪSŲ PASKYRA SUKURTA!");
        }
    }
}
