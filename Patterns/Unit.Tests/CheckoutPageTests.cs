using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Saucedemo.Core.TestData;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class CheckoutPageTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Check Step One Checkout Form Demo")]
        [AllureSubSuite("Positive")]
        public void Check_Step_One_Checkout_Form_Demo()
        {
            Logger.Instance.Debug("Login in");
            Logger.Instance.Debug("Login page opened");
            LoginPage.OpenPage();
            Logger.Instance.Debug("Inventory page opened");
            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");

            Logger.Instance.Debug("Items added to the cart");
            InventoryPage.AddSomeItemsToTheCart();
            Logger.Instance.Debug("cart page opened");
            InventoryPage.ClickTopCartButton();
            Assert.True(CartPage.IsPageOpened, "Cart Page should be opened");
            Logger.Instance.Debug("checkout page opened");
            CartPage.ClickCheckOutButton();

            Assert.True(CheckoutStepOnePage.IsPageOpened, "Checkout step one page should be opened");
            Logger.Instance.Debug("checkout user info form filled");
            CheckoutStepOnePage.FillInCheckoutUserDetailsForm_ValueObject(CheckoutUserRequestModelFactory.TestUser);
        }
    }
}
