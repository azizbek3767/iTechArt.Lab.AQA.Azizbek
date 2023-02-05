using SeleniumAdvancedPartTwo.DriverConfiguration;
using SeleniumAdvancedPartTwo.Pages;
using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Tests
{
    internal class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }
        protected HomePage HomePage { get; private set; }
        protected UploadPage UploadPage { get; private set; }
        protected HorizontalSliderPage HorizontalSliderPage { get; private set; }
        protected WindowsPage WindowsPage { get; private set; }
        protected HoversPage HoversPage { get; private set; }
        protected DownloadPage DownloadPage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            WebDriver = new WebDriverFactory().GetDriver();
            WebDriver.Manage().Window.Maximize();

            HomePage = new HomePage(WebDriver);
            UploadPage = new UploadPage(WebDriver);
            HorizontalSliderPage = new HorizontalSliderPage(WebDriver);
            WindowsPage = new WindowsPage(WebDriver);
            HoversPage = new HoversPage(WebDriver);
            DownloadPage = new DownloadPage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
