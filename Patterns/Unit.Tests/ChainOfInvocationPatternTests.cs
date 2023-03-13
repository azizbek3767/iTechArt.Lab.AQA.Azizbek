using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Saucedemo.Core.TestData;
using Saucedemo.Core.Utilities;
using Saucedemo.Page.Steps;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class ChainOfInvocationPatternTests :  BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Checkout Tests Via Chain Of Invocation Pattern")]
        [AllureSubSuite("Positive")]
        public void Checkout_Tests_Via_Chain_Of_Invocation_Pattern()
        {
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();

            Logger.Instance.Debug("Login in");
            LoginPage.LoginAsA("standard_user");
            
            Logger.Instance.Debug("Inventory page opened");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");
            
            Logger.Instance.Debug("Items added to the cart");
            InventoryPage.AddSomeItemsToTheCart();

            Logger.Instance.Debug("cart page opened");
            InventoryPage.ClickTopCartButton();

            Assert.True(CartPage.IsPageOpened, "Cart Page should be opened");
            Logger.Instance.Debug("Checkout page opened");
            CartPage.ClickCheckOutButton();

            // Chain Of Invocation
            CheckoutPageSteps
                .FillInCheckoutUserDetailsForm(CheckoutUserRequestModelFactory.TestUser)
                .ClickContinueButton()
                .ClickFinishButton();

            Logger.Instance.Debug("Checkout complete page opened");
            Assert.True(CheckoutPageSteps.IsCheckoutCompletePageOpened, "Checkout complete page should be opened");
            Logger.Instance.Debug("Checkout sucessfully completed"); 
            Assert.True(CheckoutPageSteps.IsCheckoutSuccessful, "Checkout should be successful");
        }
    }
}
