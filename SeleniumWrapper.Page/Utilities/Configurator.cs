

using Microsoft.Extensions.Configuration;

namespace SeleniumWrapper.Page.Utilities
{
    public class Configurator
    {
        public static IConfiguration GetConfigurator()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "appsettings.json");
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path, true, true);

            var config = builder.Build();

            return config;
        }
    }
}
