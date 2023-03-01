using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class LeftSidebarTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Test Left Sidebar Demo")]
        [AllureSubSuite("Positive")]
        public void Test_Left_Sidebar_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();

            Logger.Instance.Debug("Inventory page opened");
            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            
            InventoryPage.ClickMenuBurgerButton();
            Logger.Instance.Debug("All items button clicked form the left sidebar");
            InventoryPage.LeftSidebarComponent.ClickAllItemsButton();
            Logger.Instance.Debug("Inventory page is still open");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");

            Logger.Instance.Debug("About button clicked form the left sidebar");
            InventoryPage.LeftSidebarComponent.ClickAboutButton();
            Logger.Instance.Debug("saucelabs.com opened");
            Assert.That(WebDriver.Url, Is.EqualTo("https://saucelabs.com/"));
            Logger.Instance.Debug("Going back to the inventory page");
            WebDriver.Navigate().Back();
            Logger.Instance.Debug("Logout button clicked form the left sidebar");
            //InventoryPage.ClickMenuBurgerButton();
            InventoryPage.LeftSidebarComponent.ClickLogoutButton();
            Logger.Instance.Debug("Log out page opened");
            Assert.True(LoginPage.IsPageOpened, "Log out page should be opened");

            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            Logger.Instance.Debug("Items added to the cart");
            InventoryPage.AddSomeItemsToTheCart();
            Assert.True(InventoryPage.IsItemsAddedToTheCart, "Items should be added to the cart");
            InventoryPage.ClickMenuBurgerButton();
            Logger.Instance.Debug("Reset app state button clicked form the left sidebar");
            InventoryPage.LeftSidebarComponent.ClickResetAppStateButton();
            Logger.Instance.Debug("Items removed from the cart");
            Assert.False(InventoryPage.IsItemsAddedToTheCart, "Items should be removed from the cart");
        }
    }
}
