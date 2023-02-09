namespace PracticalExam3.Tests
{
    public class TaskTwoTests : BaseTest
    {
        [Test]
        public void ConfirmCookie_Test()
        {
            //1.Перейти на страницу
            HomePage.OpenPage();
            //Ожидаемый результат: Страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");
            HomePage.ClickClickHereButton();
            Assert.True(LoginFormPage.IsPageOpened, "Login form page should be opened");
            //2.Подтвердить куки
            LoginFormPage.ConfirmCookie();
            //Ожидаемый результат: Форма закрыта
            Assert.False(LoginFormPage.IsCookiesBlockDisplayed, "Cookies block should be disappeared");
        }

    }
}
