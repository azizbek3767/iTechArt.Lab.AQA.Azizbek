using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticalExam3.Locators;
using SeleniumExtras.WaitHelpers;

namespace PracticalExam3.Pages
{
    public class LoginFormPage : BasePage
    {
        public LoginFormPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement PasswordInput => WebDriver.FindElement(LoginFormPageLocators.PasswordInputLocator);
        private IWebElement EmailInput => WebDriver.FindElement(LoginFormPageLocators.EmailInputLocator);
        private IWebElement DomainInput => WebDriver.FindElement(LoginFormPageLocators.DomainInputLocator);
        private IWebElement DropdownHeader => WebDriver.FindElement(LoginFormPageLocators.DropdownHeaderLocator);
        private IWebElement DropdownItem => WebDriver.FindElement(LoginFormPageLocators.DropdownItemLocator);
        private IWebElement CheckboxSpan => WebDriver.FindElement(LoginFormPageLocators.CheckboxSpanLocator);
        private IWebElement NextButton => WebDriver.FindElement(LoginFormPageLocators.NextButtonLocator);
        private IWebElement AcceptCookieButton => WebDriver.FindElement(LoginFormPageLocators.AcceptCookieButtonLocator);
        private IWebElement CookiesBlock => WebDriver.FindElement(LoginFormPageLocators.CookiesBlockLocator);
        private IWebElement Timer => WebDriver.FindElement(LoginFormPageLocators.TimerLocator);
        private IWebElement HelpFormSendToBottomButton => WebDriver.FindElement(LoginFormPageLocators.HelpFormSendToBottomButtonLocator);
        private IWebElement HelpFormTitle => WebDriver.FindElement(LoginFormPageLocators.HelpFormTitleLocator);
        protected override By UniqueWebLocator => By.XPath("//div[@class=\"login-form__container\"]");

        protected override string UrlPath => "/game.html";
        public void FillInLoginForm()
        {
            PasswordInput.SendKeys(Keys.Control + "a");
            PasswordInput.SendKeys("AzizbekPassword123");

            EmailInput.SendKeys(Keys.Control + "a");
            EmailInput.SendKeys("azizbekemail");

            DomainInput.SendKeys(Keys.Control + "a");
            DomainInput.SendKeys("gmail");

            DropdownHeader.Click();
            DropdownItem.Click();
            CheckboxSpan.Click();
        }
        public void ClickNextButton()
        {
            NextButton.Click();
        }
        public void ConfirmCookie()
        {
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(LoginFormPageLocators.CookiesBlockLocator));
            AcceptCookieButton.Click();
        }

        public bool IsCookiesBlockDisplayed
        {
            get
            {
                bool isCookiesBlockDisplayed;
                try
                {
                    isCookiesBlockDisplayed = CookiesBlock.Displayed;
                }
                catch (Exception e)
                {
                    isCookiesBlockDisplayed = false;
                }

                return isCookiesBlockDisplayed;
            }
        }
        public bool IsTimerInitialStateCorrect
        {
            get
            {
                bool isTimerInitialStateCorrect;
                try
                {
                    isTimerInitialStateCorrect = Timer.Text == "00:00:00";
                }
                catch (Exception e)
                {
                    isTimerInitialStateCorrect = false;
                }

                return isTimerInitialStateCorrect;
            }
        }
        public void TakeOffHelpForm()
        {
            HelpFormSendToBottomButton.Click();
        }
        public bool IsHelpFormVisible
        {
            get
            {
                bool isHelpFormVisible;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(LoginFormPageLocators.HelpFormTitleLocator));
                    isHelpFormVisible = HelpFormTitle.Displayed;
                }
                catch (Exception e)
                {
                    isHelpFormVisible = false;
                }

                return isHelpFormVisible;
            }
        }
    }
}
