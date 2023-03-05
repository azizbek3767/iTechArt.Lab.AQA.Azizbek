using Xunit.Abstractions;
using XUnit.CalculatorDemo.Classes;

namespace XUnit.CalculatorDemo.Tests
{
    [Collection("Calculator subtraction tests")]
    public class CalculatorSubtractionTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private Calculator _calculator;
        public CalculatorSubtractionTests(ITestOutputHelper testOutputHelper, Calculator calculator)
        {
            _testOutputHelper = testOutputHelper;
            _calculator = calculator;
        }

        [Theory]
        [InlineData(10, 2, 8)]
        public void SubtractionValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Subtract(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Subtraction of {firstNumber} and {secondNumber} is {result}");
        }

        [Theory]
        [InlineData(-10, -2, -8)]
        public void SubtractionValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Subtract(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Subtraction of {firstNumber} and {secondNumber} is {result}");
        }

        public void Dispose()
        {
            _calculator = null;
        }
    }
}
