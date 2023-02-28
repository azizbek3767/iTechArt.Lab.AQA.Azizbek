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

        public void InputFirstName(string firstName)
        {
            FirstNameInput.SendKeys(firstName);
        }
        public void InputLastName(string lastName)
        {
            LastNameInput.SendKeys(lastName);
        }
        public void InputZipCode(string zipCode)
        {
            ZipCodeInput.SendKeys(zipCode);
        }

        public void FillInCheckoutUserDetailsForm_ValueObject(CheckoutUserRequestModel checkoutUserRequestModel)
        {
            InputFirstName(checkoutUserRequestModel.FirstName);
            InputLastName(checkoutUserRequestModel.LastName);
            InputZipCode(checkoutUserRequestModel.ZipCode);
        }
    }
}
