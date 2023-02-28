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
        private Button FirstNextStepButton => new Button(CheckoutPageLocators.FirstNextStepButtonLocator, "First Next Step Button");
        private Input NameInput => new Input(CheckoutPageLocators.NameInputLocator, "Name Input");
        private Input PhoneNumberInput => new Input(CheckoutPageLocators.PhoneNumberInputLocator, "Phone Number Input");
        private Input AddressInput => new Input(CheckoutPageLocators.AddressInputLocator, "Address Input");
        private Button SecondNextStepButton => new Button(CheckoutPageLocators.SecondNextStepButtonLocator, "Second Next Step Button");
        private CheckBox DeliveryTypeCheckout => new CheckBox(CheckoutPageLocators.DeliveryTypeCheckoutLocator, "Delivery Type Checkout");
        private TextArea DeliveryComment => new TextArea(CheckoutPageLocators.DeliveryCommentLocator, "Delivery Comment");
        private RadioButton CashPaymentTypeRadioButtonLabel => new RadioButton(CheckoutPageLocators.CashPaymentTypeRadioButtonLabelLocator, "Cash Payment Type RadioButton Label");
        private CheckBox AgreeCheckbox => new CheckBox(CheckoutPageLocators.AgreeCheckboxLocator, "Agree Checkbox");
        private Button SubmitButton => new Button(CheckoutPageLocators.SubmitButtonLocator, "Submit Button");
        private Label OrderConfirmationLabel => new Label(CheckoutPageLocators.OrderConfirmationLabelLocator, "Order Confirmation Label");
        private IWebElement OrderConfirmationLabelEl => WebDriver.FindElement(CheckoutPageLocators.OrderConfirmationLabelLocator);

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
                    isOrderConfirmed = OrderConfirmationLabelEl.Displayed;
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
