using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using Microsoft.Extensions.Configuration;
using Paas;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //IConfigurationRoot configuration = builder.Build();
            //var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(AppDomain.CurrentDomain.BaseDirectory+ "HsopPaas");
            //var types = assembly.DefinedTypes;
            //var type = Type.GetType(configuration["PaasLogger"]);
            var logger = new Logger();
            logger.LogMessage();
            Console.ReadLine();
        }
    }
}
