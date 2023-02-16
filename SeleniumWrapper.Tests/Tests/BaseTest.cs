using OpenQA.Selenium;
using SeleniumWrapper.Page.DriverConfiguration;
using SeleniumWrapper.Page.Pages;

namespace SeleniumWrapper.Page.Tests
{
    internal class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }
        protected ProductsPage ProductsPage { get; private set; }
        protected CheckoutPage CheckoutPage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            WebDriver = new WebDriverFactory().GetDriver();
            WebDriver.Manage().Window.Maximize();

            ProductsPage = new ProductsPage(WebDriver);
            CheckoutPage = new CheckoutPage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
