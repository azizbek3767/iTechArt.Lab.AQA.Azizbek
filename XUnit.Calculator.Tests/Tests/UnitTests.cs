using System.ComponentModel;
using Xunit;

namespace XUnit.Calculator.Tests.Tests
{
    public class UnitTests : IDisposable, IClassFixture<CalculatorFixture>
    {
        private Calculator _calculator;
        public UnitTests()
        {
            _calculator= new Calculator();
        }

        [Theory]
        [InlineData(3, 5)]
        public void SumValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(8, result);
        }

        [Theory,InlineData(-2, -18, -20)]
        public void SumValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SubtractionValues_WhenValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Subtract(10, 2);
            Assert.Equal(8, result);
        }

        [Fact]
        public void SubtractionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Subtract(-10, -2);
            Assert.Equal(-8, result);
        }

        [Fact]
        public void MultiplyValues_WhenValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Multiply(3, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void MultiplyValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Multiply(-3, -5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void DivisionValues_WhenValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivisionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            var result = _calculator.Divide(-10, -2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivisionValues_WhenDivisionOnNull_ShouldReturnException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calculator = new Calculator();
                var result = _calculator.Divide(3, 0);
            });
        }
        public void Dispose()
        {
            _calculator = null;
        }
    }
}
