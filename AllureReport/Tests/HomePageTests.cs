using SeleniumAdvancedPartTwo.Pages;

namespace SeleniumAdvancedPartTwo.Tests
{
    internal class HomePageTests : BaseTest
    {
        [Test]
        public void Basic_Authorization_Test()
        {
            //1.Перейти на главную страницу
            HomePage.OpenPage();
            //Ожидаемый результат: Главная страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");

            //2.Выполнить авторизацию на сайте одним из способов:
            //•	ввести логин\пароль в предложенные поля;
            //•	модификация адресной строки;
            //•	Authorization header field.
            //Ожидаемый результат: Авторизация пройдена. 
            //На странице присутствует надпись:
            //"Congratulations! You must have the proper credentials.".
            Assert.True(HomePage.IsElementWithCongratulationsVisible, "Element with congratulations should be visible");
        }
    }
}
