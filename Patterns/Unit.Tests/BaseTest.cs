using OpenQA.Selenium;
using Saucedemo.Core.BrowserUtils;
using Saucedemo.Page.Pages;

namespace Saucedemo.Tests.Unit.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        protected LoginPage LoginPage { get; private set; }

        protected HomePage HomePage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            WebDriver = BrowserService.Browser.WebDriver;
            WebDriver.Manage().Window.Maximize();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            LoginPage = new LoginPage(WebDriver);
            HomePage = new HomePage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
