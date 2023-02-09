using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class WindowsPageLocators
    {
        public static readonly By ClickHereButtonLocator =
            By.XPath("//a[contains(@href, \"windows/new\")]");
    }
}
