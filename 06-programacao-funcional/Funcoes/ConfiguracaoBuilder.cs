
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Funcoes
{
    class ConfiguracaoBuilder
    {
        public static ServiceProvider RegisterServices(string[] args)
        {
            IConfiguration configuration = SetupConfiguration(args);
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton(configuration);

            return serviceCollection.BuildServiceProvider();
        }

        
        private static IConfiguration SetupConfiguration(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
                if (args != null && args.Length > 0)
                    builder.AddCommandLine(args);
            return builder.Build();
        }
    }
    
}
