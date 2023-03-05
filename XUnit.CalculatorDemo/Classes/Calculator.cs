using Microsoft.Extensions.Logging;
using Xunit.Abstractions;
using XUnit.CalculatorDemo.Utilities;

namespace XUnit.CalculatorDemo.Classes
{
    public class Calculator
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ILogger _logger;
        public Calculator(XUnitLogger xUnitLogger)
        {
            _logger = xUnitLogger.OutputHelper.ToLogger<Calculator>();
        }

        public int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            _logger.LogInformation($"Sum of '{firstNumber}' and {secondNumber} is equal to {result}");
            return result;
        }
        public int Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            _logger.LogInformation($"Subtraction of '{firstNumber}' and {secondNumber} is equal to {result}");
            return result;
        }
        public int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            _logger.LogInformation($"Multiplication of '{firstNumber}' and {secondNumber} is equal to {result}");
            return result;
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            _logger.LogInformation($"Division of '{firstNumber}' and {secondNumber} is equal to {result}");
            return result;
        }
    }
}
