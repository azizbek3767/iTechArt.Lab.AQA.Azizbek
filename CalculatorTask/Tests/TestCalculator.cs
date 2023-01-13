using NUnit.Framework;

namespace CalculatorTask.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    internal class TestCalculator
    {
        public Calculator Calculator { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.Error.WriteLine("All tests are starting");
        }

        [SetUp]
        public void Setup()
        {
            Calculator = new Calculator();
        }

        [Order(1)]
        [Category("Calculator Test")]
        [Test(Description = "This method tests the Add method of Calculator class", Author = "Azizbek")]
        [TestCase(20, 10, 10)]
        [TestCase(4.4, 2, 2.4)]
        [TestCase(400.5454, 200.1, 200.4454)]
        [TestCase(5, 5, 0)]
        public void TestAdd(double expected, double firstNumber, double secondNumber)
        {
            Assert.AreEqual(expected, Math.Round(Calculator.Add(firstNumber, secondNumber)), 14);
        }

        [Order(2)]
        [Category("Calculator Test")]
        [Test(Description = "This method tests the Subtract method of Calculator class", Author = "Azizbek")]
        [TestCase(10, 20, 10)]
        [TestCase(2, 4.4, 2.4)]
        [TestCase(200.1, 400.5454, 200.4454)]
        [TestCase(5, 5, 0)]
        public void TestSubtract(double expected, double firstNumber, double secondNumber)
        {
            Assert.AreEqual(expected, Math.Round(Calculator.Subtract(firstNumber, secondNumber)), 14);
        }

        [Order(3)]
        [Category("Calculator Test")]
        [Test(Description = "This method tests the Multiply method of Calculator class", Author = "Azizbek")]
        [TestCase(100, 10, 10)]
        [TestCase(4.8, 2, 2.4)]
        [TestCase(40109.12454, 200.1, 200.4454)]
        [TestCase(0, 5, 0)]
        public void TestMultiply(double expected, double firstNumber, double secondNumber)
        {
            Assert.AreEqual(expected, Math.Round(Calculator.Multiply(firstNumber, secondNumber)), 14);
        }

        [Order(4)]
        [Category("Calculator Test")]
        [Test(Description = "This method tests the Divide method of Calculator class", Author = "Azizbek")]
        [TestCaseSource(nameof(_fakeCredentials))]
        public void TestDivision(double expected, double firstNumber, double secondNumber)
        {
            Assert.AreEqual(expected, Math.Round(Calculator.Divide(firstNumber, secondNumber)), 14);
        }

        private static object[] _fakeCredentials =
        {
            new object[] {1, 10, 10},
            new object[] {0.83333333333333, 2, 2.4},
            new object[] {0.99827683748292, 200.1, 200.4454},
        };

        [NonParallelizable]
        [Order(5)]
        [Category("Calculator Test")]
        [Test(Description = "This method tests impossibility of division by 0 of Calculator class", Author = "Azizbek")]
        public void ImpossibilityOfDivisionByZero()
        {
            Assert.That(double.IsInfinity(Calculator.Divide(5, 0)), Is.EqualTo(true));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test is finished");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.Error.WriteLine("All tests completed");
        }

    }
}
