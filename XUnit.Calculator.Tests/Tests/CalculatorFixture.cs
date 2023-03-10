namespace XUnit.Calculator.Tests.Tests
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator;
        public CalculatorFixture(Calculator calculator)
        {
            Calculator = calculator;
        }

        public void Dispose()
        {
            Calculator = null;
        }
    }
}
