using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Utilities
{
    public static class HelperMethods
    {
        public static string SplitElement(IWebElement webElement)
        {
            return webElement.Text.Split(' ')[1];
        }
    }
}
