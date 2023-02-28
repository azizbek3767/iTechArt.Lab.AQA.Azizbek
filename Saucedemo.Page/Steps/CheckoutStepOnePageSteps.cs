using OpenQA.Selenium;
using Saucedemo.Core.Models;
using Saucedemo.Page.Pages;

namespace Saucedemo.Page.Steps
{
    public class CheckoutStepOnePageSteps
    {
        private IWebDriver WebDriver { get; set; }
        public CheckoutStepOnePageSteps(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private CheckoutStepOnePage CheckoutStepOnePage => new CheckoutStepOnePage(WebDriver);
        public void FillInCheckoutUserDetailsForm(CheckoutUserRequestModel checkoutUserRequestModel)
        {
            CheckoutStepOnePage.InputFirstName(checkoutUserRequestModel.FirstName);
            CheckoutStepOnePage.InputLastName(checkoutUserRequestModel.LastName);
            CheckoutStepOnePage.InputZipCode(checkoutUserRequestModel.ZipCode);
        }
    }
}
