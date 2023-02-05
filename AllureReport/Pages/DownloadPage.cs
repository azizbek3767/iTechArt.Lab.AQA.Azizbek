using OpenQA.Selenium;
using SeleniumAdvancedPartTwo.Locators;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class DownloadPage : BasePage
    {
        public DownloadPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//h3[contains(text(), \"File Downloader\")]");
        private IWebElement DownloadFileLink => WebDriver.FindElement(DownloadPageLocators.DownloadFileLinkLocator);

        protected override string UrlPath => "/download/";
        public void Open()
        {
            var uri = new Uri("http://the-internet.herokuapp.com/download", UriKind.Absolute);
            WebDriver.Navigate().GoToUrl(uri);
        }
        public void DownloadFile()
        {
            DownloadFileLink.Click();
        }
    }
}
