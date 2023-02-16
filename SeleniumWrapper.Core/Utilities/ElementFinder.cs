

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Utilities
{
    public class ElementFinder
    {
        public IWebDriver WebDriver { get; }
        public ElementFinder(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement GetWebElement(By locator)
        {
            return WebDriver.FindElement(locator);
        }
    }
}
