using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
