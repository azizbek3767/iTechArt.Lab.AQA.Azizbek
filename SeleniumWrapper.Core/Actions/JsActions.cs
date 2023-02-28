using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Actions
{
    public class JsActions
    {
        public IWebDriver WebDriver { get; }
        public JsActions(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
