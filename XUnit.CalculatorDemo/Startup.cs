using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XUnit.CalculatorDemo.Classes;
using Xunit.DependencyInjection.Logging;
using XUnit.CalculatorDemo.Utilities;
using Xunit.DependencyInjection;

namespace XUnit.CalculatorDemo
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
