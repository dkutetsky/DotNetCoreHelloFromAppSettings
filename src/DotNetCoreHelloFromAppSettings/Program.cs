using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreHelloFromAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .AddCommandLine(args);


            var configuration = builder.Build();

            var hello = configuration.GetSection("HelloValue").Value;
            Console.WriteLine(hello);
            Console.ReadLine();
        }
    }
}
