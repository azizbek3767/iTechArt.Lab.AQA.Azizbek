using SeleniumAdvancedPartTwo.Pages;

namespace SeleniumAdvancedPartTwo.Tests
{
    internal class WindowsPageTests : BaseTest
    {
        [Test]
        public void Windows_Test()
        {
            //Перейти на главную страницу
            WindowsPage.Open();
            //Ожидаемый результат: Главная страница открыта
            Assert.True(WindowsPage.IsPageOpened, "Windows page should be opened");
            //2.	Нажать на ссылку "Click Here"
            WindowsPage.ClickClickHereButton();
            //Ожидаемый результат: Открывается новая вкладка в браузере.На странице отображается текст: "New Window". Имя новой вкладки: "New Window".
            WindowsPage.GoToFirstNewTab();
            Assert.True(WindowsPage.IsInFirstNewTab, "New Tab should be opened");

            //3.	Вернуться на вкладку шага(1)
            WindowsPage.GoToOriginalTab();
            //Ожидаемый результат: Открыта вкладка из шага 1
            Assert.True(WindowsPage.IsPageOpened, "Windows page should be opened");

            //4.	Нажать на ссылку "Click Here"
            WindowsPage.ClickClickHereButton();
            //Ожидаемый результат: Открывается новая вкладка в браузере.На странице отображается текст: "New Window". Имя новой вкладки: "New Window".
            WindowsPage.GoToSecondNewTab();
            Assert.True(WindowsPage.IsInSecondNewTab, "Second new tab is open");

            //5.	Закрыть вкладку из шага(2)
            WindowsPage.GoBackFirstNewTab();
            WindowsPage.CloseCurrentTab();
            //Ожидаемый результат: Вкладка закрыта
            Assert.True(WindowsPage.IsFirstNewTabClosed, "First new tab should be closed");

            //6.	Закрыть вкладку из шага(1 - главной страницы)
            WindowsPage.GoToOriginalTab();
            WindowsPage.CloseCurrentTab();
            //Ожидаемый результат: Вкладка закрыта
            Assert.True(WindowsPage.IsOriginalTabClosed, "Original tab should be closed");

            //7.	Закрыть вкладку из шага(4)
            WindowsPage.GoBackSecondNewTab();
            WindowsPage.CloseCurrentTab();
            //Ожидаемый результат: Вкладка закрыта
        }
    }
}
