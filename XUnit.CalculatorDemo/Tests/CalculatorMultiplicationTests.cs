using Xunit.Abstractions;
using XUnit.CalculatorDemo.Classes;

namespace XUnit.CalculatorDemo.Tests
{
    [Collection("Calculator multiplication tests")]
    public class CalculatorMultiplicationTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private Calculator _calculator;
        public CalculatorMultiplicationTests(ITestOutputHelper testOutputHelper, Calculator calculator)
        {
            _testOutputHelper = testOutputHelper;
            _calculator = calculator;
        }

        [Theory]
        [InlineData(3, 5, 15)]
        public void MultiplyValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Multiply(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Multiplication of {firstNumber} and {secondNumber} is {result}");
        }

        [Theory]
        [InlineData(-3, -5, 15)]
        public void MultiplyValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Multiply(-3, -5);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Multiplication of {firstNumber} and {secondNumber} is {result}");
        }

        public void Dispose()
        {
            _calculator = null;
        }
    }
}
