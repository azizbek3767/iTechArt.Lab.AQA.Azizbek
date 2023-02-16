
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace PageObjectPattern.Tests
{
    [TestFixture]
    [AllureNUnit]
    internal class FailingTest : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Fail")]
        [AllureSubSuite("Positive")]
        public void FailTest()
        {
            Assert.Fail();
        }
    }
}
