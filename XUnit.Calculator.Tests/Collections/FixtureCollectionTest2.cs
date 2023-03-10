using XUnit.Calculator.Tests.Tests;

namespace XUnit.Calculator.Tests.Collections
{
    [Collection("DemoCollection")]
    public class FixtureCollectionTest2
    {
        private readonly CalculatorFixture _calculatorFixture;
        public FixtureCollectionTest2(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(3, 5)]
        public void SumValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber)
        {
            var result = _calculatorFixture.Calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(8, result);
        }

        [Theory, InlineData(-2, -18, -20)]
        public void SumValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculatorFixture.Calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SubtractionValues_WhenValidData_ShouldReturnCorrectly()
        {
            var result = _calculatorFixture.Calculator.Subtract(10, 2);
            Assert.Equal(8, result);
        }

        [Fact]
        public void SubtractionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            var result = _calculatorFixture.Calculator.Subtract(-10, -2);
            Assert.Equal(-8, result);
        }
    }
}
