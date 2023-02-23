using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class Input : BaseForm
    {
        public Input(By locator, string name) : base(locator, name)
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
