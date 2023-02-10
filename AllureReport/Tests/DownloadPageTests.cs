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
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwwroot/newyork.png.crdownload");

            Assert.True(File.Exists(path), "File should be downloaded");
        }
    }
}
