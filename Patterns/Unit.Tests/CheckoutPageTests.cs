using Saucedemo.Core.TestData;

namespace Saucedemo.Tests.Unit.Tests
{
    internal class CheckoutPageTests : BaseTest
    {
        [Test]
        public void Check_Step_One_Checkout_Form_Demo()
        {
            LoginPage.OpenPage();
            LoginPage.LoginAsA("standard_user");
            Assert.True(InventoryPage.IsPageOpened, "Inventory page should be opened");

            InventoryPage.AddSomeItemsToTheCart();
            InventoryPage.ClickTopCartButton();
            Assert.True(CartPage.IsPageOpened, "Cart Page should be opened");
            CartPage.ClickCheckOutButton();

            Assert.True(CheckoutStepOnePage.IsPageOpened, "Checkout step one page should be opened");
            CheckoutStepOnePage.FillInCheckoutUserDetailsForm_ValueObject(CheckoutUserRequestModelFactory.TestUser);
        }
    }
}
