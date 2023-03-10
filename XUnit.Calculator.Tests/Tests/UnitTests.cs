/*using System.Collections;
using Xunit.Abstractions;

namespace XUnit.Calculator.Tests.Tests
{
    public class UnitTests : IDisposable, IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private Calculator _calculator;
        public UnitTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper= testOutputHelper;
            _calculator= new Calculator();
        }

        [Fact(Skip = "ignored test")]
        public void Ignored_Test()
        {
            Console.WriteLine("Ignored test");
        }

        public void LoggingTest()
        {
            _testOutputHelper.WriteLine("Calculator tests started");
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
        }

        [Theory]
        [InlineData(3, 5)]
        public void SumValues_WhenValidData_ShouldReturnCorrectly2(int firstNumber, int secondNumber)
        {
            var result = _calculator.Sum(firstNumber, secondNumber);
            Assert.Equal(8, result);
            _testOutputHelper.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");
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
            _testOutputHelper.WriteLine($"Subrtaction of 10 and 2 is {result}");
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
                var result = _calculator.Divide(3, 0);
            });
        }
        public void Dispose()
        {
            _calculator = null;
        }
        public class CalculatorTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 1, 2, 3 };
                yield return new object[] { -4, -6, -10 };
                yield return new object[] { -2, 2, 0 };
                yield return new object[] { int.MinValue, -1, int.MaxValue };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 1, 2, 3 },
                new object[] { -4, -6, -10 },
                new object[] { -2, 2, 0 },
                new object[] { int.MinValue, -1, int.MaxValue },
            };
    }
}
*/