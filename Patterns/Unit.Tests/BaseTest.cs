using OpenQA.Selenium;
using Saucedemo.Core.BrowserUtils;
using Saucedemo.Core.Utilities;
using Saucedemo.Page.Pages;
using Saucedemo.Page.Steps;

namespace Saucedemo.Tests.Unit.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        protected LoginPage LoginPage { get; private set; }

        protected InventoryPage InventoryPage { get; private set; }
        protected CartPage CartPage { get; private set; }
        protected CheckoutStepOnePage CheckoutStepOnePage { get; private set; }
        protected CheckoutStepOnePageSteps CheckoutStepOnePageSteps { get; private set; }
        protected CheckoutPageSteps CheckoutPageSteps { get; private set; }

        [SetUp]
        public void SetUp()
        {
            Logger.Instance.Info("Test started");
            Logger.Instance.Info("WebDriver started");

            WebDriver = BrowserService.Browser.WebDriver;
            WebDriver.Manage().Window.Maximize();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            LoginPage = new LoginPage(WebDriver);
            InventoryPage = new InventoryPage(WebDriver);
            CartPage = new CartPage(WebDriver);
            CheckoutStepOnePage = new CheckoutStepOnePage(WebDriver);
            CheckoutStepOnePageSteps = new CheckoutStepOnePageSteps(WebDriver);
            CheckoutPageSteps = new CheckoutPageSteps(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            Logger.Instance.Info("Test ended");

            WebDriver.Quit();
        }
    }
}
