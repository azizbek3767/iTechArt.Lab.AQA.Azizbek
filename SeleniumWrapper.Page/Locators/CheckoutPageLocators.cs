using OpenQA.Selenium;

namespace SeleniumWrapper.Page.Locators
{
    internal class CheckoutPageLocators
    {
        public static readonly By NameInputLocator =
            By.XPath("//input[@id=\"msordersform-first_name\"]");
        public static readonly By PhoneNumberInputLocator =
            By.XPath("//input[@id=\"msordersform-phone_m\"]");
        public static readonly By AddressInputLocator =
            By.XPath("//input[@id=\"msordersform-address\"]");
        public static readonly By FirstNextStepButtonLocator =
            By.XPath("//button[contains(text(), \"следующий шаг\") and @data-csb=\"delivery\"]");
        public static readonly By SecondNextStepButtonLocator =
            By.XPath("//button[@data-csa=\"delivery\" and @data-csb=\"payment\"]");
        public static readonly By DeliveryTypeCheckoutLocator =
            By.XPath("//label[@for=\"sort_0\"]");
        public static readonly By DeliveryCommentLocator =
            By.XPath("//textarea[@id=\"msordersform-comment\"]");
        public static readonly By CaptchaInputLocator =
            By.XPath("//input[@id=\"msordersform-captchacode\"]");
        public static readonly By CashPaymentTypeRadioButtonLabelLocator =
            By.XPath("//label[@for=\"payment_info_0\"]");
        public static readonly By AgreeCheckboxLocator =
            By.XPath("//input[@id=\"msordersform-offer\"]");
        public static readonly By SubmitButtonLocator =
            By.XPath("//button[@type=\"submit\" and contains(text(), \"Оформить заказ\")]");
        public static readonly By OrderConfirmationLabelLocator =
            By.XPath("//p[contains(text(), \"Ваш заказ оформлен\")]");
    }
}
