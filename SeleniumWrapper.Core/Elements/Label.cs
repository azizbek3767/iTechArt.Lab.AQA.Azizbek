

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Label : BaseElement
    {
        public Label(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }
    }
}
