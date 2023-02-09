using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class DownloadPageLocators
    {
        public static readonly By DownloadFileLinkLocator =
            By.XPath("//a[contains(text(), \"logo.jpeg\")]");
    }
}
