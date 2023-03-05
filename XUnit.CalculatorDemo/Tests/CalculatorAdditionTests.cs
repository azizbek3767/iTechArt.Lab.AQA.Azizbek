using Xunit.Abstractions;
using XUnit.CalculatorDemo.Classes;
using XUnit.CalculatorDemo.TestData;

namespace XUnit.CalculatorDemo.Tests
{
    [Collection("Calculator addition tests")]
    public class CalculatorAdditionTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private Calculator _calculator;
        public CalculatorAdditionTests(ITestOutputHelper testOutputHelper, Calculator calculator)
        {
            _testOutputHelper = testOutputHelper;
            _calculator = calculator;
        }

        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void SumValues_WhenValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");
        }
        [Theory]
        [MemberData(nameof(Data))]
        public void SumValues_WhenValidData_ShouldReturnCorrectly3(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");
        }
        [Theory]
        [InlineData(3, 5)]
        public void SumValues_WhenValidData_ShouldReturnCorrectly2(int firstNumber, int secondNumber)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(8, result);
            _testOutputHelper.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");
        }
        [Theory, InlineData(-2, -18, -20)]
        public void SumValues_WhenNegativeValidData_ShouldReturnCorrectly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(expectedResult, result);
            _testOutputHelper.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 1, 2, 3 },
                new object[] { -4, -6, -10 },
                new object[] { -2, 2, 0 },
                new object[] { int.MinValue, -1, int.MaxValue },
            };

        public void Dispose()
        {
            _calculator = null;
        }
    }
}
