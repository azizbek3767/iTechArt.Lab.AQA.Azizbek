namespace PracticalExam3.Tests
{
    public class TaskThreeTests : BaseTest
    {
        [Test]
        public void Check_Timer_Test()
        {
            //1.Перейти на страницу
            HomePage.OpenPage();
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");
            HomePage.ClickClickHereButton();
            Assert.True(LoginFormPage.IsPageOpened, "Login form page should be opened");
            //Ожидаемый результат: Проверить, что таймер начинается с «00:00»
            Assert.True(LoginFormPage.IsTimerInitialStateCorrect, "Initial state of the timer should be correct");
        }
    }
}
