using OpenQA.Selenium;
using SeleniumAdvancedPartTwo.Locators;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class UploadPage : BasePage
    {
        public UploadPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//h3[contains(text(),\"File Uploader\")]");
        private IWebElement FileUploadInput => WebDriver.FindElement(UploadPageLocators.FileUploadInputLocator);
        private IWebElement FileSubmitButton => WebDriver.FindElement(UploadPageLocators.FileSubmitButtonLocator);
        private IWebElement FileUploadedLabel => WebDriver.FindElement(UploadPageLocators.FileUploadedLabelLocator);

        protected override string UrlPath => "/upload";
        public void UploadFile()
        {
            FileUploadInput.SendKeys("C:\\Users\\Azizbek\\Desktop\\Photos\\photo.jpg");
        }
        public void SubmitFile()
        {
            FileSubmitButton.Click();
        }
        public bool IsFileUploaded
        {
            get
            {
                bool isFileUploaded;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.ElementIsVisible(UploadPageLocators.FileUploadedLabelLocator));
                    isFileUploaded = FileUploadedLabel.Displayed;
                }
                catch (Exception e)
                {
                    isFileUploaded = false;
                }

                return isFileUploaded;
            }
        }
    }
}
