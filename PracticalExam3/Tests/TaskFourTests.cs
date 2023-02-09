namespace PracticalExam3.Tests
{
    public class TaskFourTests : BaseTest
    {
        [Test]
        public void Check_Helpform_Is_Closable_Test()
        {
            //1.Перейти на страницу
            HomePage.OpenPage();
            //Ожидаемый результат: Страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");
            HomePage.ClickClickHereButton();
            Assert.True(LoginFormPage.IsPageOpened, "Login form page should be opened");
            //2.Убрать форму «help»
            LoginFormPage.TakeOffHelpForm();
            //Ожидаемый результат: Форма скрыта
            Assert.False(LoginFormPage.IsHelpFormVisible, "Help Form should be disappeared");
        }
    }
}
