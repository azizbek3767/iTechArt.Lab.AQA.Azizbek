using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumWrapper.Page.Locators;

namespace SeleniumWrapper.Page.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement NameInput => WebDriver.FindElement(CheckoutPageLocators.NameInputLocator);
        private IWebElement PhoneNumberInput => WebDriver.FindElement(CheckoutPageLocators.PhoneNumberInputLocator);
        private IWebElement AddressInput => WebDriver.FindElement(CheckoutPageLocators.AddressInputLocator);

        protected override By UniqueWebLocator => By.XPath("//h1[text()=\"Оформить заказ\"]");

        protected override string UrlPath => string.Empty;

        public void FillInCheckoutPageForm()
        {
            NameInput.Clear();
            NameInput.SendKeys("Azizbek");
            PhoneNumberInput.Clear();
            PhoneNumberInput.SendKeys("946300925");
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(CheckoutPageLocators.AddressInputLocator));
            AddressInput.SendKeys("address");
        }
    }
}
