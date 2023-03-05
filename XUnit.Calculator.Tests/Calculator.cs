using Microsoft.Extensions.Logging;
using Xunit.Abstractions;
using XUnit.Calculator.Tests.Utilities;

namespace XUnit.Calculator.Tests
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
            _logger.LogInformation(firstNumber + " " + secondNumber);
            return firstNumber + secondNumber;
        }
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
