using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Input : BaseElement
    {
        public Input(IWebDriver webDriver, By locator, string name) : base(webDriver, locator, name)
        {
        }
        public void SendKeys(string keys)
        {
            FindElement().SendKeys(keys);
        }
        public void Clear()
        {
            FindElement().Clear();
        }
    }
}
