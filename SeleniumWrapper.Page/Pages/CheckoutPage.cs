using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumWrapper.Core.Elements;
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
        //private Button FirstNextStepButton => new Button(CheckoutPageLocators.FirstNextStepButtonLocator, "First Next Step Button");
        private IWebElement FirstNextStepButton => WebDriver.FindElement(CheckoutPageLocators.FirstNextStepButtonLocator);
        private IWebElement SecondNextStepButton => WebDriver.FindElement(CheckoutPageLocators.SecondNextStepButtonLocator);
        private IWebElement DeliveryTypeCheckout => WebDriver.FindElement(CheckoutPageLocators.DeliveryTypeCheckoutLocator);
        private IWebElement DeliveryComment => WebDriver.FindElement(CheckoutPageLocators.DeliveryCommentLocator);
        private IWebElement CashPaymentTypeRadioButtonLabel => WebDriver.FindElement(CheckoutPageLocators.CashPaymentTypeRadioButtonLabelLocator);
        private IWebElement AgreeCheckbox => WebDriver.FindElement(CheckoutPageLocators.AgreeCheckboxLocator);
        private IWebElement SubmitButton => WebDriver.FindElement(CheckoutPageLocators.SubmitButtonLocator);
        private IWebElement OrderConfirmationLabel => WebDriver.FindElement(CheckoutPageLocators.OrderConfirmationLabelLocator);

        protected override By UniqueWebLocator => By.XPath("//h1[text()=\"Оформить заказ\"]");

        protected override string UrlPath => string.Empty;

        public void FillInCheckoutPageForm()
        {
            NameInput.Clear();
            NameInput.SendKeys("Azizbek");
            PhoneNumberInput.Clear();
            PhoneNumberInput.SendKeys("123456789");
            FirstNextStepButton.Click();
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(CheckoutPageLocators.AddressInputLocator));
            AddressInput.SendKeys("address");
            DeliveryTypeCheckout.Click();
            DeliveryComment.SendKeys("qwerty");
            SecondNextStepButton.Click();
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(CheckoutPageLocators.CaptchaInputLocator));
            CashPaymentTypeRadioButtonLabel.Click();
            Thread.Sleep(10000);
            AgreeCheckbox.Click();
        }

        public void SubmitChecckoutForm()
        {
            SubmitButton.Click();
        }
        public bool IsOrderConfirmed
        {
            get
            {
                WebDriverWait.Until(ExpectedConditions.ElementIsVisible(CheckoutPageLocators.OrderConfirmationLabelLocator));
                bool isOrderConfirmed;
                try
                {
                    isOrderConfirmed = OrderConfirmationLabel.Displayed;
                }
                catch (Exception e)
                {
                    isOrderConfirmed = false;
                }

                return isOrderConfirmed;
            }
        }
    }
}
