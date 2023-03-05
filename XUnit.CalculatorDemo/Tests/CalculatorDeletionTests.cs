using Xunit.Abstractions;
using XUnit.CalculatorDemo.Classes;

namespace XUnit.CalculatorDemo.Tests
{
    [Collection("Calculator deletion tests")]
    public class CalculatorDeletionTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private Calculator _calculator;
        public CalculatorDeletionTests(ITestOutputHelper testOutputHelper, Calculator calculator)
        {
            _testOutputHelper = testOutputHelper;
            _calculator = calculator;
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivisionValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Divide(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Division of {firstNumber} and {secondNumber} is {result}");
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivisionValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Divide(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Division of {firstNumber} and {secondNumber} is {result}");
        }

        [Theory]
        [InlineData(3, 0)]
        public void DivisionValues_WhenDivisionOnNull_ShouldReturnException(int firstNumber, int secondNumber)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var result = _calculator.Divide(firstNumber, secondNumber);
            });
            _testOutputHelper.WriteLine("Number cannot be divided by 0");
        }

        public void Dispose()
        {
            _calculator = null;
        }
    }
}
