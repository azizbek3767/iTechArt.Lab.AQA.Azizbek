using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectPattern.Pages;

namespace PageObjectPattern.Tests
{
    public abstract class BaseTest
    {
        private IWebDriver _driver;
        private IJavaScriptExecutor _executor;
        protected HomePage HomePage { get; private set; }
        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _driver.Manage().Window.Maximize();
            _executor = (IJavaScriptExecutor)_driver;
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }
    }
}
