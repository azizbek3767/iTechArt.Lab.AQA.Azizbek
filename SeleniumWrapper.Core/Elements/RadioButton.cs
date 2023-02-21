

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class RadioButton : BaseElement
    {
        public RadioButton(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }
    }
}
