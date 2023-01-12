using NUnit.Framework;

namespace TDDForCalculatorFunctions.Fixtures
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
