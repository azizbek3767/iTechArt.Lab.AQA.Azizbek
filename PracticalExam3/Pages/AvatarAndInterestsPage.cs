using OpenQA.Selenium;

namespace PracticalExam3.Pages
{
    public class AvatarAndInterestsPage : BasePage
    {
        public AvatarAndInterestsPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//div[@class=\"avatar-and-interests\"]");

        protected override string UrlPath => "/game.html";
    }
}
