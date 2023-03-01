using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Saucedemo.Core.Elements;
using Saucedemo.Core.Models;
using Saucedemo.Page.Locators;

namespace Saucedemo.Page.Pages
{
    public class CheckoutStepOnePage : BasePage
    {
        public CheckoutStepOnePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//span[@class=\"title\" and contains(text(), \"Checkout: Your Information\")]");

        protected override string UrlPath => "/checkout-step-one.html";
        private Input FirstNameInput => new Input(CheckoutStepOnePageLocators.FirstNameInputLocator, "Firstname input");
        private Input LastNameInput => new Input(CheckoutStepOnePageLocators.LastNameInputLocator, "LastName Input");
        private Input ZipCodeInput => new Input(CheckoutStepOnePageLocators.ZipCodeInputLocator, "Zip Code Input");
        public Button ContinueButton => new Button(CheckoutStepOnePageLocators.ContinueButtonLocator, "Continue Button");
        public Button FinishButton => new Button(CheckoutStepOnePageLocators.FinishButtonLocator, "Finish Button");

        [AllureStep("Input first name")]
        public void InputFirstName(string firstName)
        {
            FirstNameInput.SendKeys(firstName);
        }

        [AllureStep("Input last name")]
        public void InputLastName(string lastName)
        {
            LastNameInput.SendKeys(lastName);
        }

        [AllureStep("input zip code")]
        public void InputZipCode(string zipCode)
        {
            ZipCodeInput.SendKeys(zipCode);
        }

        [AllureStep("Fill In Checkout User Details Form")]
        public void FillInCheckoutUserDetailsForm_ValueObject(CheckoutUserRequestModel checkoutUserRequestModel)
        {
            InputFirstName(checkoutUserRequestModel.FirstName);
            InputLastName(checkoutUserRequestModel.LastName);
            InputZipCode(checkoutUserRequestModel.ZipCode);
        }
    }
}
