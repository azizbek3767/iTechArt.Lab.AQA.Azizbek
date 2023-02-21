

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Icon : BaseElement
    {
        public Icon(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }
    }
}
