using Saucedemo.Core.BrowserUtils;
using Saucedemo.Core.Models;
using Saucedemo.Page.Pages;

namespace Saucedemo.Page.Helpers
{
    public class StandardUserStrategy : IUserStrategy
    {
        public void Login()
        {
            var user = new User()
            {
                Username = "standard_user",
                Password = "secret_sauce"
            };
            LoginPage loginPage = new LoginPage(BrowserService.Browser.WebDriver);
            loginPage.UsernameInput.SendKeys(user.Username);
            loginPage.PasswordInput.SendKeys(user.Password);
            loginPage.LoginButton.Click();
        }
    }
}
