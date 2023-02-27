using OpenQA.Selenium;
using Saucedemo.Core.Builders;
using Saucedemo.Core.Elements;
using Saucedemo.Core.Extensions;
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
        private Input UsernameInput => new (LoginPageLocators.UsernameInputLocator, "Username input");
        private Input PasswordInput => new (LoginPageLocators.PasswordInputLocator, "Password input");
        private Button LoginButton => new (LoginPageLocators.LoginButtonLocator, "Login Button");
        private Label LockedOutUserErrorMessage => new (LoginPageLocators.LockedOutUserErrorMessageLocator, "Locked Out User Error Message");
        public void LoginAsA(string userType)
        {
            var director = new UserBuilderDirector();
            var userBuilder = UserBuilderTypeSelector.SelectUserBuilderByString(userType);
            director.UserBuilder = userBuilder;
            director.BuildUser();
            var user = userBuilder.GetUser();
            UsernameInput.SendKeys(user.Username);
            PasswordInput.SendKeys(user.Password);
            LoginButton.Click();
        }
        public bool IsErrorMessageForLockedOutUserAppeared
        {
            get
            {
                bool isErrorMessageForLockedOutUserAppeared;
                try
                {
                    isErrorMessageForLockedOutUserAppeared = LockedOutUserErrorMessage.IsDisplayed();
                }
                catch (Exception e)
                {
                    isErrorMessageForLockedOutUserAppeared = false;
                }

                return isErrorMessageForLockedOutUserAppeared;
            }
        }
    }
}
