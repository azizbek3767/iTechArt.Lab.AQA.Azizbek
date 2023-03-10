using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.DependencyInjection;
using Xunit.DependencyInjection.Logging;
using XUnit.Calculator.Tests.Utilities;

namespace XUnit.Calculator.Tests.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(Calculator));
            serviceCollection.AddTransient(typeof(XUnitLogger));
        }

        public void Configure(ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor)
        {
            loggerFactory.AddProvider(new XunitTestOutputLoggerProvider(accessor, (s, level) => level >=
                LogLevel.Debug && level < LogLevel.None));
        }
    }
}
