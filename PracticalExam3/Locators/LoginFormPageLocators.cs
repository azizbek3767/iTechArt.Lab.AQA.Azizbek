using OpenQA.Selenium;

namespace PracticalExam3.Locators
{
    public static class LoginFormPageLocators
    {
        public static readonly By PasswordInputLocator =
            By.XPath("//input[contains(@placeholder,\"Choose Password\")]");
        public static readonly By EmailInputLocator =
            By.XPath("//input[contains(@placeholder,\"Your email\")]");
        public static readonly By DomainInputLocator =
            By.XPath("//input[contains(@placeholder,\"Domain\")]");
        public static readonly By DropdownHeaderLocator =
            By.XPath("//div[@class=\"dropdown__field\" and text()=\"other\"]");
        public static readonly By DropdownItemLocator =
            By.XPath("//div[@class=\"dropdown__list-item\" and text()=\".org\"]");
        public static readonly By CheckboxSpanLocator =
            By.XPath("//span[@class=\"checkbox__box\"]");
        public static readonly By NextButtonLocator =
            By.XPath("//a[@class=\"button--secondary\" and text()=\"Next\"]");
        public static readonly By CookiesBlockLocator =
            By.XPath("//div[@class=\"cookies\"]");
        public static readonly By AcceptCookieButtonLocator =
            By.XPath("//button[contains(@class,\"button\") and text()=\"Not really, no\"]");
        public static readonly By TimerLocator =
            By.XPath("//div[contains(@class, \"timer\")]");
        public static readonly By HelpFormSendToBottomButtonLocator =
            By.XPath("//button[contains(@class, \"help-form__send-to-bottom-button\")]");
        public static readonly By HelpFormTitleLocator =
            By.XPath("//h2[@class=\"help-form__title\"]");
    }
}
