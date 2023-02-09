namespace SeleniumAdvancedPartTwo.Tests
{
    internal class DownloadPageTests : BaseTest
    {
        [Test]
        public void Check_Download_Test()
        {
            //1.Перейти на главную страницу.
            DownloadPage.OpenPage();
            //Ожидаемый результат: Главная страница открыта.
            Assert.True(DownloadPage.IsPageOpened, "Download page should be opened");
            //2.Скачать любой файл с страницы.
            DownloadPage.DownloadFile();
            //Ожидаемый результат: Файл скачался и находится в директории(которую вы указали).
            Assert.True(File.Exists("C:\\Users\\Azizbek\\Downloads\\logo.jpeg"), "File should be downloaded");
        }
    }
}
