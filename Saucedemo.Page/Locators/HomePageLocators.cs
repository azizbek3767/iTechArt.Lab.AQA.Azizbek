using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class HomePageLocators
    {
        public static readonly By NameInputLocator =
            By.XPath("//input[@id=\"msordersform-first_name\"]");
    }
}
