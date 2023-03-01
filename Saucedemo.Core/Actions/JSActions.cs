using OpenQA.Selenium;

namespace Saucedemo.Core.Actions
{
    internal class JSActions
    {
        public IWebDriver WebDriver { get; }
        public JSActions(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
