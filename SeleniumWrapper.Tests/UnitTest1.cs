using OpenQA.Selenium;
using SeleniumWrapper.Core.BrowserUtils;
using SeleniumWrapper.Core.Elements;

namespace SeleniumWrapper.Tests
{
    public class Tests2
    {
        private Browser Browser => BrowserService.Browser;

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Quit();
        }

        /*[Test]
        [Ignore("not needed")]
        public void Test1()
        {
            // go to google.com
            var googleUrl = "https://www.google.com/";
            Browser.GoToUrl(googleUrl);

            // search smth
            Text googleSearchInput = new Text(By.CssSelector("[name=\"q\"]"), "Google Search Input");
            var searchText = "Hello world";
            googleSearchInput.Input(searchText);

            // assertion
            var getSearchedText = googleSearchInput.GetValue();

            Assert.AreEqual(searchText, getSearchedText);
        }

        [Test]
        [Ignore("not needed")]
        public void Test2()
        {
            // go to google.com
            var googleUrl = "https://www.google.com/";
            Browser.GoToUrl(googleUrl);

            // search smth
            Text googleSearchInput = new Text(By.CssSelector("[name=\"q\"]"), "Google Search Input");
            var searchText = "Hello world";
            googleSearchInput.Input(searchText);

            // assertion
            var getSearchedText = googleSearchInput.GetValue();

            Assert.AreEqual(searchText, getSearchedText);
        }*/
    }
}