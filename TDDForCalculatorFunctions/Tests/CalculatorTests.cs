using NUnit.Framework;

namespace TDDForCalculatorFunctions.Tests
{
    internal class CalculatorTests
    {
        private Calculator _calculator;

        [Test]
        public void SumValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Sum(3, 5);
            Assert.AreEqual(result, 8);
        }

        [Test]
        public void SumValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Sum(-3, -5);
            Assert.AreEqual(result, -8);
        }


        [Test]
        public void SubtractionValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Subtract(10, 2);
            Assert.AreEqual(result, 8);
        }

        [Test]
        public void SubtractionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Subtract(-10, -2);
            Assert.AreEqual(result, -8);
        }

        [Test]
        public void MultiplyValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Multiply(3, 5);
            Assert.AreEqual(result, 15);
        }

        [Test]
        public void MultiplyValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Multiply(-3, -5);
            Assert.AreEqual(result, 15);
        }

        [Test]
        public void DivisionValues_WhenValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Divide(10, 2);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void DivisionValues_WhenNegativeValidData_ShouldReturnCorrectly()
        {
            _calculator = new Calculator();
            var result = _calculator.Divide(-10, -2);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void DivisionValues_WhenDivisionOnNull_ShouldReturnException()
        {
            Assert.Catch<DivideByZeroException>(() =>
            {
                _calculator = new Calculator();
                var result = _calculator.Divide(3, 0);
            });
        }
    }
}
