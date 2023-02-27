namespace Saucedemo.Tests.Unit.Tests
{
    internal class LeftSidebarTests : BaseTest
    {
        [Test]
        public void Test_Left_Sidebar_Demo()
        {
            LoginPage.OpenPage();

            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            
            InventoryPage.ClickMenuBurgerButton();
            InventoryPage.LeftSidebarComponent.ClickAllItemsButton();
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");

            InventoryPage.LeftSidebarComponent.ClickAboutButton();
            Assert.That(WebDriver.Url, Is.EqualTo("https://saucelabs.com/"));
            WebDriver.Navigate().Back();

            InventoryPage.ClickMenuBurgerButton();
            InventoryPage.LeftSidebarComponent.ClickLogoutButton();
            Assert.True(LoginPage.IsPageOpened, "Log out page should be opened");

            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            InventoryPage.AddSomeItemsToTheCart();
            Assert.True(InventoryPage.IsItemsAddedToTheCart, "Items should be added to the cart");
            InventoryPage.ClickMenuBurgerButton();
            InventoryPage.LeftSidebarComponent.ClickResetAppStateButton();
            Assert.False(InventoryPage.IsItemsAddedToTheCart, "Items should be removed from the cart");
        }
    }
}
