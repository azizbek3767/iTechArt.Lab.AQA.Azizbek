﻿using Microsoft.Extensions.Configuration;

namespace PageObjectPattern.Utilities
{
    public class Configurator
    {
        public static IConfiguration GetConfigurator()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Resources", "appsettings.json");
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path, true, true);
            var config = builder.Build();
            return config;
        }
    }
}
