using OpenQA.Selenium;

namespace SeleniumWebDriverBasics
{
    public class HomePage
    {
        private IWebDriver _webDriver;
        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement MobilePhonesButton => _webDriver.FindElement(By.XPath("//span[@class = 'project-navigation__sign' and text() = 'Мобильные телефоны']"));
        public IWebElement AppleManufacturerCheckbox => _webDriver.FindElement(By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[1]/label/span[2]"));
        public IWebElement HonorManufacturerCheckbox => _webDriver.FindElement(By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[5]/label/span[2]"));
        public IWebElement FirstItemToCheck => _webDriver.FindElement(By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[1]/div[1]/div/label/span"));
        public IWebElement SecondItemToCheck => _webDriver.FindElement(By.XPath("//*[@id=\"schema-products\"]/div[5]/div/div[1]/div[1]/div/label/span"));
        public IWebElement SpanWithTwoElementsToCompare => _webDriver.FindElement(By.XPath("//*[@id=\"compare-button-container\"]/div/div[1]/div/div/div[1]/a[2]/span[contains(text(), '2')]"));
        public IWebElement ButtonWithTwoElementsToCompare => _webDriver.FindElement(By.XPath("//*[@id=\"compare-button-container\"]/div/div[1]/div/div/div[1]/a[2]"));
        public IWebElement SpanWithOverview => _webDriver.FindElement(By.XPath("//*[@id=\"product-table\"]/tbody[4]/tr[4]/td[1]/span"));
        public IWebElement AppleCheckboxInput => _webDriver.FindElement(By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[1]/label/span[1]/input"));
        public IWebElement HonorCheckboxInput => _webDriver.FindElement(By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[5]/label/span[1]/input"));
        public IWebElement SpanForComparison => _webDriver.FindElement(By.XPath("//*[@id=\"compare-button-container\"]/div/div[1]/div/div/div[1]/a[2]/span"));
        public IWebElement FirstItemWithClass => _webDriver.FindElement(By.XPath("//div[@class = 'schema-product__group'][1]/div/div/div/div"));
        public IWebElement ThirdItemWithClass => _webDriver.FindElement(By.XPath("//div[@class = 'schema-product__group'][3]/div/div/div/div"));

        public void Open(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }
    }
}
