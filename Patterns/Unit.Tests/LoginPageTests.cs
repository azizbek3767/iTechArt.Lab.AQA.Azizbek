namespace Saucedemo.Tests.Unit.Tests
{
    internal class LoginPageTests : BaseTest
    {
        [Test]
        public void Check_Login_With_Standart_User()
        {
            LoginPage.OpenPage();
            LoginPage.LoginAsStandardUser();
            Thread.Sleep(10000);
        }
    }
}
