namespace SeleniumAdvancedPartTwo.Tests
{
    internal class UploadPageTests : BaseTest
    {
        [Test]
        public void Upload_Image_Test()
        {
            //1.Перейти на главную страницу.
            UploadPage.OpenPage();
            //Ожидаемый результат: Главная страница открыта.
            Assert.True(UploadPage.IsPageOpened, "Homepage should be opened");

            //2.Загрузить файл на страницу.
            UploadPage.UploadFile();
            UploadPage.SubmitFile();
            //Ожидаемый результат: Страница обновилась.
            //На странице присутствует надпись:
            //"File Uploaded!"
            //На странице появилось имя файла.
            Assert.True(UploadPage.IsFileUploaded, "File should be properly uploaded");
        }
    }
}
