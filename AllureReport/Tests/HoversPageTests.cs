namespace SeleniumAdvancedPartTwo.Tests
{
    internal class HoversPageTests : BaseTest
    {
        [Test]
        public void Check_Hovers_And_Links()
        {
            //1.Перейти на главную страницу.
            HoversPage.Open();
            //Ожидаемый результат: Главная страница открыта.
            Assert.True(HoversPage.IsPageOpened, "Hovers Page should be opened");
            //Для каждого из пользователей:
            //2.Навести курсор на пользователя.
            //Ожидаемый результат: Отображается корректный user_name.
            HoversPage.HoverFirstUserItem();
            Assert.That(HoversPage.FirstUserName, Is.EqualTo("user1"));
            Assert.That(HoversPage.FirstUserLink.GetAttribute("href"), Is.EqualTo("http://the-internet.herokuapp.com/users/1"));
            HoversPage.HoverSecondUserItem();
            Assert.That(HoversPage.SecondUserName, Is.EqualTo("user2"));
            Assert.That(HoversPage.SecondUserLink.GetAttribute("href"), Is.EqualTo("http://the-internet.herokuapp.com/users/2"));
            HoversPage.HoverThirdUserItem();
            Assert.That(HoversPage.ThirdUserName, Is.EqualTo("user3"));
            Assert.That(HoversPage.ThirdUserLink.GetAttribute("href"), Is.EqualTo("http://the-internet.herokuapp.com/users/3"));
            //Отображается ссылка на профиль.

            //3.Перейти по ссылке из шага 2.
            //Ожидаемый результат: Убедиться, что ссылка открылась для нужного пользователя.
            HoversPage.HoverFirstUserItem();
            HoversPage.ClickFirstUserButton();
            Assert.That(WebDriver.Url, Is.EqualTo("http://the-internet.herokuapp.com/users/1"));
            HoversPage.GoBack();

            HoversPage.HoverSecondUserItem();
            HoversPage.ClickSecondUserButton();
            Assert.That(WebDriver.Url, Is.EqualTo("http://the-internet.herokuapp.com/users/2"));
            HoversPage.GoBack();
            
            HoversPage.HoverThirdUserItem();
            HoversPage.ClickThirdUserButton();
            Assert.That(WebDriver.Url, Is.EqualTo("http://the-internet.herokuapp.com/users/3"));

            //4.Вернуться на предыдущую страницу.
            HoversPage.GoBack();
            //Ожидаемый результат: Отображается корректная страница с пользователями.
            Assert.True(HoversPage.IsPageOpened, "Hovers Page should be opened");
        }
    }
}
