using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Commands;

[assembly: LevelOfParallelism(3)]
namespace TDDForCalculatorFunctions.Tests
{
    [SingleThreaded]
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    [Parallelizable(ParallelScope.Fixtures)]
    internal class CalculatorTests
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("I am OneTimeSetup");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am Setup");

        }

        [Order(0)]
        [Category("Calculator Sum Test")]
        [Test(Description = "Adding valid values", Author = "Azizbek")]
        [TestCase(3, 5)]
        public void SumValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber)
        {
            _calculator = new Calculator();
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.AreEqual(result, 8);
        }

        [Order(1)]
        [Category("Calculator Sum Test")]
        [Test(Description = "Adding negative valid values", Author = "Azizbek")]
        [TestCaseSource(nameof(_fakeCredentials))]
        public void SumValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            _calculator = new Calculator();
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.AreEqual(result, expectedResult);
        }


        [Category("Calculator Subtract Test")]
        [Test(Description = "Subtracting valid values", Author = "Azizbek")]
        public void SubtractionValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Subtract(10, 2);
            Assert.AreEqual(result, 8);
        }

        [Category("Calculator Subtract Test")]
        [Test(Description = "Subtracting negative valid values", Author = "Azizbek")]
        public void SubtractionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Subtract(-10, -2);
            Assert.AreEqual(result, -8);
        }

        [Category("Calculator Multiply Test")]
        [Test(Description = "Multiplication of valid values", Author = "Azizbek")]
        public void MultiplyValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Multiply(3, 5);
            Assert.AreEqual(result, 15);
        }

        [Category("Calculator Multiply Test")]
        [Test(Description = "Multiplication of negative valid values", Author = "Azizbek")]
        public void MultiplyValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Multiply(-3, -5);
            Assert.AreEqual(result, 15);
        }

        [Category("Calculator Divide Test")]
        [Test(Description = "Division of valid values", Author = "Azizbek")]
        public void DivisionValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Divide(10, 2);
            Assert.AreEqual(result, 5);
        }

        [Category("Calculator Divide Test")]
        [Test(Description = "Division of negative valid values", Author = "Azizbek")]
        public void DivisionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Divide(-10, -2);
            Assert.AreEqual(result, 5);
        }

        [NonParallelizable]
        [Category("Calculator Divide Test")]
        [Test(Description = "Division of value by zero", Author = "Azizbek")]
        [Retry(3)]
        public void DivisionValues_WhenDivisionOnNull_ShouldReturnException()
        {
            Assert.Catch<DivideByZeroException>(() =>
            {
                _calculator = new Calculator();
                var result = _calculator.Divide(3, 0);
            });
        }

        [Test]
        [Ignore("Ignore a test")]
        public void IgnoredTest()
        {
            Console.WriteLine("I am ignored test");
        }

        private static object[] _fakeCredentials =
        {
            new object[] {-2, -18, -20},
            new object[] {-33, -56, -89},
            new object[] {-22, -10, -32},
        };

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("I am TearDown");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("I am OneTimeTearDown");
        }
    }
}
