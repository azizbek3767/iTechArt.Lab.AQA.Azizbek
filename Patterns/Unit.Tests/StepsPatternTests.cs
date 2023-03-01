using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Saucedemo.Core.TestData;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class StepsPatternTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Check Checkout Demo Using Steps Pattern")]
        [AllureSubSuite("Positive")]
        public void Check_Checkout_Demo_Using_Steps_Pattern()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            Logger.Instance.Debug("Logged in as a standard user");
            LoginPage.LoginAsA("standard_user");
            Logger.Instance.Debug("Inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");

            Logger.Instance.Debug("Some items are added to the cart");
            InventoryPage.AddSomeItemsToTheCart();
            InventoryPage.ClickTopCartButton();
            Logger.Instance.Debug("cart page opened");
            Assert.True(CartPage.IsPageOpened, "Cart Page should be opened");
            Logger.Instance.Debug("checkout page opened");
            CartPage.ClickCheckOutButton();

            // Steps
            Logger.Instance.Debug("checkout page user info form filled");
            CheckoutStepOnePageSteps.FillInCheckoutUserDetailsForm(CheckoutUserRequestModelFactory.TestUser);
            CheckoutStepOnePageSteps.ClickContinueButton();
            Logger.Instance.Debug("checkout finished");
            CheckoutStepOnePageSteps.ClickFinishButton();
            Assert.True(CheckoutStepOnePageSteps.IsCheckoutCompletePageOpened, "Checkout complete page should be opened");
            Assert.True(CheckoutStepOnePageSteps.IsCheckoutSuccessful, "Checkout should be successful");
        }
    }
}
