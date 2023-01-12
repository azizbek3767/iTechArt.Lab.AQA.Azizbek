using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TDDForSeleniumSaucedemo.Tests
{
    internal class SeleniumSaucedemoCheckoutTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }

        [Test]
        public void Test()
        {
            var HomePage = new HomePage(_driver);

            HomePage.Open("https://www.saucedemo.com/");
            HomePage.FillInUsernameField("standard_user");
            HomePage.FillInPasswordField("secret_sauce");
            HomePage.ClickLoginButton();
            Assert.AreEqual(HomePage.GetCurrentUrl(), "https://www.saucedemo.com/inventory.html");
            Assert.IsTrue(HomePage.HomePageLogoExists());
            HomePage.AddToCartButton.Click();
            HomePage.CartButton.Click();
            Assert.IsTrue(HomePage.IsCartInventoryExists());
            Assert.IsTrue(HomePage.IsRightItemIsAddedToCart());
            HomePage.Checkout();
            HomePage.FillInCheckoutForm();
            HomePage.CheckoutContinueButton.Click();
            Assert.AreEqual(HomePage.GetCurrentUrl(), "https://www.saucedemo.com/checkout-step-two.html");
            HomePage.CheckoutFinishButton.Click();
            Assert.AreEqual(HomePage.GetCurrentUrl(), "https://www.saucedemo.com/checkout-complete.html");
        }
    }
}
