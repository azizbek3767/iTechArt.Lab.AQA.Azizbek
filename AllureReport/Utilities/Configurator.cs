using Microsoft.Extensions.Configuration;

namespace SeleniumAdvancedPartTwo.Utilities
{
    public class Configurator
    {
        public static Microsoft.Extensions.Configuration.IConfiguration GetConfigurator()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Resources", "appsettings.json");
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path, true, true);
            var config = builder.Build();

            return config;
        }
    }
}
