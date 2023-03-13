using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Saucedemo.Core.Utilities;
using Saucedemo.Page.Helpers;
using Saucedemo.Page.Steps;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class StrategyPatternTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Login As A Standard User Demo")]
        [AllureSubSuite("Positive")]
        public void Login_As_A_Standard_User_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            IUserStrategy webStrategy = new StandardUserStrategy();
            LoginPageSteps.Login(webStrategy);
            Logger.Instance.Debug("Logged in as a standard user");
            Logger.Instance.Debug("inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory Page should be opened");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Login As A Problem User Demo")]
        [AllureSubSuite("Positive")]
        public void Login_As_A_Problem_User_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            IUserStrategy restStrategy = new ProblemUserStrategy();
            LoginPageSteps.Login(restStrategy);
            Logger.Instance.Debug("Logged in as a problem user");
            Logger.Instance.Debug("inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory Page should be opened");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Login As A Performance Glitch User Demo")]
        [AllureSubSuite("Positive")]
        public void Login_As_A_Performance_Glitch_User_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            IUserStrategy restStrategy = new PerformanceGlitchUserStrategy();
            LoginPageSteps.Login(restStrategy);
            Logger.Instance.Debug("Logged in as a performance glitch user");
            Logger.Instance.Debug("inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory Page should be opened");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Login As A Locked Out User Demo")]
        [AllureSubSuite("Positive")]
        public void Login_As_A_Locked_Out_User_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            IUserStrategy restStrategy = new LockedOutUserStrategy();
            LoginPageSteps.Login(restStrategy);
            Logger.Instance.Debug("Logged in as a locked out user");
            Logger.Instance.Debug("error message appeared");
            Assert.True(LoginPage.IsErrorMessageForLockedOutUserAppeared, "Error message for locked out user should be showed");
        }
    }
}
