using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BudgetMiner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();

            var envVars = Environment.GetEnvironmentVariables();


            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options => options.ValidateScopes = false)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    // delete all default configuration providers
                    config.Sources.Clear();

                    var env = hostingContext.HostingEnvironment;
                    var configPath = Path.Combine(env.ContentRootPath);

                    config.SetBasePath(configPath);
                    config.AddJsonFile("appconfig.json");

                    config.AddEnvironmentVariables();
                })
                .UseConfiguration(configuration)
                .Build();
        }
    }
}
