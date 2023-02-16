using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.Locators;
using PageObjectPattern.Utilities;
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
                Logger.Instance.Info("Checking if there only iphones");
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

        [AllureStep("Open Mobile phones page")]
        public override void OpenPage()
        {
            Logger.Instance.Info("Opening the page");
            WebDriver.Navigate().GoToUrl(UrlPath);
        }

        [AllureStep("Select apple and honor manufacturers")]
        public void SelectAppleAndHonor()
        {
            Logger.Instance.Info("Seleccting only two models (apple, honor)");
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", AppleManufacturerSpan);
            AppleManufacturerSpan.Click();
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", HonorManufacturerSpan);
            HonorManufacturerSpan.Click();
        }

        [AllureStep("Unselect honor manufacturer")]
        public void UnselectHonor()
        {
            Logger.Instance.Info("unselecting the honor");
            WebDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", HonorManufacturerSpan);
            HonorManufacturerSpan.Click();
        }

        [AllureStep("Select first two items")]
        public void SelectFirstAndThirdItemCheckboxes()
        {
            Logger.Instance.Info("Adding two items to the card");
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[3]/div[2]/div[1]/a/span[contains(text(), 'Apple')]")));

            WebDriver.ExecuteJavaScript("arguments[0].click();", FirstItemCheckboxLabel);

            WebDriver.ExecuteJavaScript("arguments[0].click();", ThirdItemCheckboxLabel);
        }

        [AllureStep("Go to compare page with seleted items")]
        public void GoToComparePageWithSelectedItems()
        {
            Logger.Instance.Info("Going to the Compare page with selected items");
            Actions actions = new Actions(WebDriver);
            actions.MoveToElement(ButtonWithTwoElementsToCompare).Click().Build().Perform();
        }
    }
}
