using DesignPattern.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var serviceProvider = BuildDi();
                Console.WriteLine("Applciation start ...");
                IAircraft aircraft = (serviceProvider.GetRequiredService<AircraftFactory>()).GetAircraft(AircraftType.Commericial);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        private static ServiceProvider BuildDi()
        {
            return new ServiceCollection()
                .AddLogging(builder => {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddNLog(new NLogProviderOptions
                    {
                        CaptureMessageTemplates = true,
                        CaptureMessageProperties = true
                    });
                })
                .AddTransient<AircraftFactory>()
                .BuildServiceProvider();
        }
    }
}
