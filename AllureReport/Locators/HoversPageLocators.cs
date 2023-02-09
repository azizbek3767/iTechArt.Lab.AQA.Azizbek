using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class HoversPageLocators
    {
        public static readonly By FirstUserLocator =
           By.XPath("//div[@class=\"figure\"][1]");
        public static readonly By SecondUserLocator =
           By.XPath("//div[@class=\"figure\"][2]");
        public static readonly By ThirdUserLocator =
           By.XPath("//div[@class=\"figure\"][3]");
        public static readonly By FirstUserNameLocator =
           By.XPath("//div[@class=\"figure\"][1]/div/h5[contains(text(), \"name\")]");
        public static readonly By SecondUserNameLocator =
           By.XPath("//div[@class=\"figure\"][2]/div/h5[contains(text(), \"name\")]");
        public static readonly By ThirdUserNameLocator =
           By.XPath("//div[@class=\"figure\"][3]/div/h5[contains(text(), \"name\")]");
        public static readonly By FirstUserLinkLocator =
           By.XPath("//div[@class=\"figure\"][1]/div/a");
        public static readonly By SecondUserLinkLocator =
           By.XPath("//div[@class=\"figure\"][2]/div/a");
        public static readonly By ThirdUserLinkLocator =
           By.XPath("//div[@class=\"figure\"][3]/div/a");
    }
}
