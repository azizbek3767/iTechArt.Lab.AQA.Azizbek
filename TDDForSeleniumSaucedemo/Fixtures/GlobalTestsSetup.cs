using NUnit.Framework;

namespace TDDForSeleniumSaucedemo.Fixtures
{
    [SetUpFixture]
    internal class GlobalTestsSetup
    {
        [OneTimeSetUp]
        public void GlobalOneTimeSetUp()
        {
            Console.Error.WriteLine("I am GlobalOneTimeSetUp");
        }
    }
}
