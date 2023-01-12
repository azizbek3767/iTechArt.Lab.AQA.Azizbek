using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDForSelenimSaucedemo.Tests
{
    [Binding]
    public class AddToCartSteps
    {
        private HomePage _homePage;

        [Given(@"Open website")]
        public void GivenOpenWebsite()
        {
            var _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();

            _homePage = new HomePage(_driver);
            _homePage.Open("https://www.saucedemo.com/");
        }

        [Given(@"Log in to website")]
        public void GivenLogInToWebsite()
        {
            _homePage.FillInUsernameField("standard_user");
            _homePage.FillInPasswordField("secret_sauce");
            _homePage.ClickLoginButton();
            Assert.AreEqual(_homePage.GetCurrentUrl(), "https://www.saucedemo.com/inventory.html");
            Assert.IsTrue(_homePage.HomePageLogoExists());
        }

        [When(@"Added an item to cart")]
        public void WhenAddedAnItemToCart()
        {
            _homePage.AddToCartButton.Click();
        }

        [Then(@"Item should be added to cart")]
        public void ThenItemShouldBeAddedToCart()
        {
            _homePage.CartButton.Click();
            Assert.IsTrue(_homePage.IsCartInventoryExists());
            Assert.IsTrue(_homePage.IsRightItemIsAddedToCart());
            _homePage.CloseBrowser();
        }
    }
}
