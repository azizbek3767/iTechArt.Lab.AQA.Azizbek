

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class CheckBox : BaseElement
    {
        public CheckBox(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }

        public bool IsChecked()
        {
            return FindElement().Selected;
        }
    }
}
