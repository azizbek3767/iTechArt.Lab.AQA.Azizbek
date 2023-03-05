using Xunit.Abstractions;

namespace XUnit.CalculatorDemo.Utilities
{
    public interface IXunitLogger
    {
        ITestOutputHelper OutputHelper { get; }
    }
}
