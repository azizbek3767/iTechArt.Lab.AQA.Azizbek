using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class TextArea : BaseElement
    {
        public TextArea(By locator, string name) : base(locator, name)
        {
        }
        public void SendKeys(string keys)
        {
            FindElement().SendKeys(keys);
        }
    }
}
