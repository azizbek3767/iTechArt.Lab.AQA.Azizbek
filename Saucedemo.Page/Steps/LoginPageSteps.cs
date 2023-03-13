using Saucedemo.Page.Helpers;

namespace Saucedemo.Page.Steps
{
    public class LoginPageSteps
    {
        public static void Login(IUserStrategy loginStrategy)
        {
            loginStrategy.Login();
        }
    }
}
