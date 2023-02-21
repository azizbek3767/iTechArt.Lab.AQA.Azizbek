

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Button : BaseElement
    {
        public Button(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }
    }
}
