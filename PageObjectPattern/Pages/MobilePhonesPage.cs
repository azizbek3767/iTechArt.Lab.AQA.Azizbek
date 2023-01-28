using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.Locators;
using SeleniumExtras.WaitHelpers;

namespace PageObjectPattern.Pages
{
    public class MobilePhonesPage : BasePage
    {
        public MobilePhonesPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//h1[contains(text(), \"Мобильные телефоны\")]");

        protected override string UrlPath => "https://catalog.onliner.by/mobile";
        public IWebElement AppleManufacturerSpan => WebDriver.FindElement(HomePageLocators.AppleManufacturerSpanLocator);
        public IWebElement HonorManufacturerSpan => WebDriver.FindElement(HomePageLocators.HonorManufacturerSpanLocator);
        public IWebElement FirstItemCheckboxLabel => WebDriver.FindElement(HomePageLocators.FirstItemCheckboxLabel);
        public IWebElement FirstItemCheckboxInput => WebDriver.FindElement(HomePageLocators.FirstItemCheckboxInput);
        public IWebElement ThirdItemCheckboxLabel => WebDriver.FindElement(HomePageLocators.ThirdItemCheckboxLabel);
        public IWebElement ThirdItemCheckboxInput => WebDriver.FindElement(HomePageLocators.ThirdItemCheckboxInput);
        public IWebElement ButtonWithTwoElementsToCompare => WebDriver.FindElement(HomePageLocators.ButtonWithTwoElementsToCompare);

        public bool IsOnlyIphones
        {
            get
            {
                bool isOnlyIphones = true;
                var phones = WebDriver.FindElements(HomePageLocators.PhonesListLocator);
                foreach (var phone in phones)
                {
                    if (phone.Text.Contains("Honor"))
                    {
                        isOnlyIphones = false;
                    }
                }
                return isOnlyIphones;
            }
        }
        public override void OpenPage()
        {
            WebDriver.Navigate().GoToUrl(UrlPath);
        }

        public void SelectAppleAndHonor()
        {
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", AppleManufacturerSpan);
            AppleManufacturerSpan.Click();
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", HonorManufacturerSpan);
            HonorManufacturerSpan.Click();
        }

        public void UnselectHonor()
        {
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", HonorManufacturerSpan);
            HonorManufacturerSpan.Click();
        }

        public void SelectFirstAndThirdItemCheckboxes()
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[3]/div[2]/div[1]/a/span[contains(text(), 'Apple')]")));

            WebDriver.ExecuteJavaScript("arguments[0].click();", FirstItemCheckboxLabel);

            WebDriver.ExecuteJavaScript("arguments[0].click();", ThirdItemCheckboxLabel);
        }

        public void GoToComparePageWithSelectedItems()
        {
            Actions actions = new Actions(WebDriver);
            actions.MoveToElement(ButtonWithTwoElementsToCompare).Click().Build().Perform();
        }
    }
}
