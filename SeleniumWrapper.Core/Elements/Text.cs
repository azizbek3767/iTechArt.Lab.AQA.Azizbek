

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Text : BaseElement
    {
        public Text(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }

        public void Input(string text)
        {
            FindElement().SendKeys(text);
        }

        public string GetValue()
        {
            return FindElement().GetAttribute("value");
        }
    }
}
