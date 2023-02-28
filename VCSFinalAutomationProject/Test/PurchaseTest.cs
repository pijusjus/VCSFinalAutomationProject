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
            loginPage.InsertEmailToInputField("");
            loginPage.InsertPasswordInputs("");
            loginPage.LoginAction();
            //registrationPage.RemoveAd();
            purchasePage.MainSite();
            purchasePage.CatalogSelection();
            purchasePage.TypeSelection();
            purchasePage.FridgeSelection();
            purchasePage.ItemSelection();
            purchasePage.AddToCart();
            purchasePage.StartCheckout();
            purchasePage.WarrantyExtension();
            purchasePage.CheckoutButton();
            purchasePage.PayerInfoVerification("", "", "", "");
            purchasePage.AgreeAndContinueToShipping();
            purchasePage.DeliveryType("", "", "");
            purchasePage.VerifyOnlineBanking("Elektroninė bankininkystė");

        }
    }
}