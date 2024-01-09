using Microsoft.Extensions.Configuration;
using Serilog;

namespace DotnetStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // import Appsettings file
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            IConfiguration config = configurationBuilder.AddJsonFile("appsettings.json").Build();
            var appSettings = config.GetRequiredSection("AppSettings").Get<AppSettings>();

            if (appSettings == null)
            {
                throw new BaseException("AppSettings cannot be null");
            }
            // set serilog for logging
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("App", "Starter App")
                .Enrich.WithProperty("Version", "1.0.0.0")
                .ReadFrom.Configuration(config)
                .CreateLogger();

            // serilog test ediliyor.
            var informationLog = new AppLogs() { Message = "Log service -- OK." };
            Log.Information("{@AppTestLog}", informationLog);

            Console.WriteLine(appSettings.ConnectionString);
            Console.ReadLine();

        }
    }
}
