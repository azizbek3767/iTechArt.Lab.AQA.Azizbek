using Saucedemo.Core.Models;

namespace Saucedemo.Core.TestData
{
    public static class CheckoutUserRequestModelFactory
    {
        public static readonly CheckoutUserRequestModel TestUser = new CheckoutUserRequestModel()
        {
            FirstName = "Azizbek",
            LastName = "asdasdasd",
            ZipCode = "100000"
        };
    }
}
