using OpenQA.Selenium;

namespace PageObjectPattern.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        public IWebElement SpanWithOverview => WebDriver.FindElement(By.XPath("//*[@id=\"product-table\"]/tbody[4]/tr[4]/td[1]/span"));
        public IWebElement SpanForComparison => WebDriver.FindElement(By.XPath("//*[@id=\"compare-button-container\"]/div/div[1]/div/div/div[1]/a[2]/span"));

        protected override By UniqueWebLocator => By.XPath("//*[@id=\"widget-1-1\"]/div/a");

        protected override string UrlPath => string.Empty;

        public void Open(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }
    }
}
