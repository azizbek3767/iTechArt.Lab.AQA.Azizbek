using Xunit.Abstractions;
using Xunit.DependencyInjection;

namespace XUnit.CalculatorDemo.Utilities
{
    public class XUnitLogger
    {
        private readonly ITestOutputHelperAccessor _testOutputHelperAccessor;

        public XUnitLogger(ITestOutputHelperAccessor testOutputHelperAccessor)
        {
            _testOutputHelperAccessor = testOutputHelperAccessor;
        }
        public ITestOutputHelper OutputHelper => _testOutputHelperAccessor.Output;
    }
}
