using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDForSelenimSaucedemo.Tests
{
    [Binding]
    public class CheckoutSteps
    {
        private HomePage _homePage;

        [Given(@"Open the website")]
        public void GivenOpenTheWebsite()
        {
            var _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();

            _homePage = new HomePage(_driver);
            _homePage.Open("https://www.saucedemo.com/");
        }

        [Given(@"Log in to the website")]
        public void GivenLogInToTheWebsite()
        {
            _homePage.FillInUsernameField("standard_user");
            _homePage.FillInPasswordField("secret_sauce");
            _homePage.ClickLoginButton();
            Assert.AreEqual(_homePage.GetCurrentUrl(), "https://www.saucedemo.com/inventory.html");
            Assert.IsTrue(_homePage.HomePageLogoExists());
        }

        [Given(@"Add item to the cart")]
        public void GivenAddItemToTheCart()
        {
            _homePage.AddToCartButton.Click();
        }

        [Given(@"Check that item is added to the cart")]
        public void GivenCheckThatItemIsAddedToTheCart()
        {
            _homePage.CartButton.Click();
            Assert.IsTrue(_homePage.IsCartInventoryExists());
            Assert.IsTrue(_homePage.IsRightItemIsAddedToCart());
        }

        [Given(@"Checkout that item")]
        public void GivenCheckoutThatItem()
        {
            _homePage.Checkout();
        }

        [Given(@"Fill in the checkout form")]
        public void GivenFillInTheCheckoutForm()
        {
            _homePage.FillInCheckoutForm();
        }

        [Given(@"Check the payment information")]
        public void GivenCheckThePaymentInformation()
        {
            _homePage.CheckoutContinueButton.Click();
            Assert.AreEqual(_homePage.GetCurrentUrl(), "https://www.saucedemo.com/checkout-step-two.html");
        }

        [When(@"Finish the checkout")]
        public void WhenFinishTheCheckout()
        {
            _homePage.CheckoutFinishButton.Click();
        }

        [Then(@"Redirect to the checkout confirmation page")]
        public void ThenRedirectToTheCheckoutConfirmationPage()
        {
            Assert.AreEqual(_homePage.GetCurrentUrl(), "https://www.saucedemo.com/checkout-complete.html");
            _homePage.CloseBrowser();
        }
    }
}
