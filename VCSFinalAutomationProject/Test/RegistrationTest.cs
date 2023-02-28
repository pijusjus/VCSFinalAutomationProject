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
            registrationPage.InputFirstName("VilniusCoding");
            registrationPage.InputLastName("School");
            registrationPage.InputEmailField("kristupas.jusys+04@gmail.com");
            registrationPage.InputPhoneField("+37061698976");
            registrationPage.InputPasswordField("Tester123!");
            registrationPage.InputRepeatPassword("Tester123!");
            //registrationPage.RemoveAd();
            registrationPage.RadioSubscibe();
            registrationPage.AcceptTerms();
            registrationPage.ContinueButton();
            registrationPage.VerifyResult("JŪSŲ PASKYRA SUKURTA!");
        }
    }
}
