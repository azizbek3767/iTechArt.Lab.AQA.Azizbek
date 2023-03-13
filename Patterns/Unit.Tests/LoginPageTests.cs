using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class LoginPageTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Check Login Demo With Different Types Of User")]
        [AllureSubSuite("Positive")]
        public void Check_Login_Demo_With_Different_Types_Of_User()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            var userTypes = new string[] { "standard_user", "locked_out_user", "problem_user", "performance_glitch_user" };
            LoginPage.OpenPage();

            Logger.Instance.Debug("Logged in as a standard user");
            LoginPage.LoginAsA("standard_user");
            Logger.Instance.Debug("Inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();

            Logger.Instance.Debug("Logged in as a problem user");
            LoginPage.LoginAsA("problem_user");
            Logger.Instance.Debug("Inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();

            Logger.Instance.Debug("Logged in as a performance glitch user");
            LoginPage.LoginAsA("performance_glitch_user");
            Logger.Instance.Debug("Inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            WebDriver.Navigate().Back();

            Logger.Instance.Debug("Logged in as a locked out user");
            Logger.Instance.Debug("Error message appeared");
            LoginPage.LoginAsA("locked_out_user");
            Assert.True(LoginPage.IsErrorMessageForLockedOutUserAppeared, "Error message for locked out user should be showed");
        }
    }
}
