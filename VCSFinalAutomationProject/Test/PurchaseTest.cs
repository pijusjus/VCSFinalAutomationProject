using NUnit.Framework;

namespace VCSFinalAutomationProject.Test
{
    public class PurchaseTest : BaseTest
    {
        [Test]
        public static void TestPurchase()
        {
            loginPage.NavigateToPage();
            loginPage.AcceptCookies();
            loginPage.ClickLoginButton();
            loginPage.InsertEmailToInputField("kristupas.jusys@gmail.com");
            loginPage.InsertPasswordInputs("Tester123!");
            loginPage.LoginAction();
            registrationPage.RemoveAd();
            purchasePage.MainSite();
            purchasePage.CatalogSelection();
            purchasePage.TypeSelection();
            purchasePage.FridgeSelection();
            purchasePage.ItemSelection();
            purchasePage.AddToCart();
            purchasePage.StartCheckout();
            purchasePage.WarrantyExtension();
            purchasePage.CheckoutButton();
            purchasePage.PayerInfoVerification("VilniusCoding", "School", "kristupas.jusys@gmail.com", "+37061698977");
            purchasePage.AgreeAndContinueToShipping();
            purchasePage.DeliveryType("Ulonų g. 5", "Vilnius", "08240");
            purchasePage.VerifyOnlineBanking("Elektroninė bankininkystė");

        }
    }
}