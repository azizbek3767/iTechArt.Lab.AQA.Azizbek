using OpenQA.Selenium;
using PageObjectPattern.Pages;
using PageObjectPattern.DriverConfigurations;

namespace PageObjectPattern.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }
        protected IJavaScriptExecutor JSExecutor { get; private set; }
        protected HomePage HomePage { get; private set; }
        protected MobilePhonesPage MobilePhonesPage { get; private set; }
        protected ComparePage ComparePage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            WebDriver = new WebDriverFactory().GetDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            HomePage = new HomePage(WebDriver);
            MobilePhonesPage= new MobilePhonesPage(WebDriver);
            ComparePage = new ComparePage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
