using XUnit.Calculator.Tests.Tests;

namespace XUnit.Calculator.Tests.Collections
{
    [CollectionDefinition("DemoCollection", DisableParallelization = true)]
    public class FixtureCollection : ICollectionFixture<CalculatorFixture>
    {

    }
}
