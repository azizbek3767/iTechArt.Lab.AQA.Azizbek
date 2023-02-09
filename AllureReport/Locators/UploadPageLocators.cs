using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class UploadPageLocators
    {
        public static readonly By FileUploadInputLocator =
            By.XPath("//input[@id=\"file-upload\"]");
        public static readonly By FileSubmitButtonLocator =
            By.XPath("//input[@id=\"file-submit\"]");
        public static readonly By FileUploadedLabelLocator =
            By.XPath("//h3[contains(text(), \"File Uploaded\")]");
    }
}
