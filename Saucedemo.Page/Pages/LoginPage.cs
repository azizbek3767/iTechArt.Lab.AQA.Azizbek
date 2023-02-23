using OpenQA.Selenium;
using Saucedemo.Core.Elements;
using Saucedemo.Page.Locators;

namespace Saucedemo.Page.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//div[@class=\"login_logo\"]");

        protected override string UrlPath => string.Empty;
        private Input UsernameInput => new Input(LoginPageLocators.UsernameInputLocator, "Username input");
        private Input PasswordInput => new Input(LoginPageLocators.PasswordInputLocator, "Password input");
        private Button LoginButton => new Button(LoginPageLocators.LoginButtonLocator, "Login Button");
    
        public void LoginAsStandardUser()
        {
            UsernameInput.SendKeys("standard_user");
            PasswordInput.SendKeys("secret_sauce");
            LoginButton.Click();
        }    
    
    }
}
