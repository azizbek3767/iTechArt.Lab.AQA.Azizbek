namespace Saucedemo.Tests.Unit.Tests
{
    internal class LoginPageTests : BaseTest
    {
        [Test]
        public void Check_Login_Demo_With_Different_Types_Of_User()
        {
            var userTypes = new string[] { "standard_user", "locked_out_user", "problem_user", "performance_glitch_user" };
            LoginPage.OpenPage();

            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();
            
            LoginPage.LoginAsA("problem_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();
            
            LoginPage.LoginAsA("performance_glitch_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();
            
            LoginPage.LoginAsA("locked_out_user");
            Assert.True(LoginPage.IsErrorMessageForLockedOutUserAppeared, "Error message for locked out user should be showed");
        }
    }
}
