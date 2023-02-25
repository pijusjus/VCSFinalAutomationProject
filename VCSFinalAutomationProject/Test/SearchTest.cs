using NUnit.Framework;

namespace VCSFinalAutomationProject.Test
{
    public class SearchTest : BaseTest
    {
        [Test]
        public static void TestSearch()
        {
            searchPage.NavigateToPage();
            searchPage.AcceptCookies();
            searchPage.InsertSearchField("iPhone");
            searchPage.SearchButtonClick();
            searchPage.ProductSelection();
            searchPage.VerifyResult("IPHONE");
        }
    }
}
