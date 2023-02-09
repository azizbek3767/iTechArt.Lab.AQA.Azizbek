using OpenQA.Selenium;

namespace PracticalExam3.Locators
{
    public static class HomePageLocators
    {
        public static readonly By ClickHereButtonLocator =
            By.XPath("//a[@href=\"/game.html\" and contains(@class, \"start__link\")]");
    }
}
