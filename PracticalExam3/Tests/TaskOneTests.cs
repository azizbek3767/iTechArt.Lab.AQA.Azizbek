using PracticalExam3.Pages;

namespace PracticalExam3.Tests
{
    internal class TaskOneTests : BaseTest
    {
        [Test]
        public void Auth_Test()
        {
            //1.Перейти на страницу
            HomePage.OpenPage();
            //Ожидаемый результат: Страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");
            //2.Нажать на ссылку в тексте('Please click HERE to GO to the next page') для перехода на следующую страницу
            HomePage.ClickClickHereButton();
            //Ожидаемый результат: Карточка 1 открыта
            Assert.True(LoginFormPage.IsPageOpened, "Login form page should be opened");
            //3.Ввести рандомный пароль, email, подтвердить условия пользователя, нажать «next»
            LoginFormPage.FillInLoginForm();
            LoginFormPage.ClickNextButton();
            //Ожидаемый результат: Карточка 2 открыта
            Assert.True(AvatarAndInterestsPage.IsPageOpened, "AvatarAndInterestsPage should be opened");
        }
    }
}
