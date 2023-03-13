using OpenQA.Selenium;

namespace Saucedemo.Core.Elements
{
    public class Input : BaseElement
    {
        public Input(By locator, string name) : base(locator, name)
        {
        }
        public void SendKeys(string inputString)
        {
            FindElement().SendKeys(inputString);
        }
    }
}
