using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Elements
{
    public class CheckBox : BaseForm
    {
        public CheckBox(By locator, string name) : base(locator, name)
        {
        }
        public bool IsChecked()
        {
            return FindElement().Selected;
        }
    }
}
