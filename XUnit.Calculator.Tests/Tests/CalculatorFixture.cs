namespace XUnit.Calculator.Tests.Tests
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator;
        public CalculatorFixture()
        {
            Calculator = new Calculator();
        }

        public void Dispose()
        {
            Calculator = null;
        }
    }
}
