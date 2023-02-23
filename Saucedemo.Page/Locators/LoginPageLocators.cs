using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class LoginPageLocators
    {
        public static readonly By UsernameInputLocator =
            By.XPath("//input[@id=\"user-name\"]");
        public static readonly By PasswordInputLocator =
            By.XPath("//input[@id=\"password\"]");
        public static readonly By LoginButtonLocator =
            By.XPath("//input[@id=\"login-button\"]");
    }
}
