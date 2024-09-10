using Dotpie.API.Bootstrap;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sample1.API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Launching");
            var builder = WebApplication.CreateBuilder(args);
            Bootstrap.ConfigureBindings(builder.Services, builder.Configuration);

            IConfiguration? config = Bootstrap.Configuration;
            if (config == null)
                Environment.Exit(1);

            //Part of Sample1 project only
            string? connectionStringDomain1 = config.GetConnectionString("Domain1");
            Console.WriteLine($"Conntection string for Domain1 database is: \"{connectionStringDomain1}\"");
            string? connectionStringDomain2 = config.GetConnectionString("Domain2");
            Console.WriteLine($"Conntection string for Domain2 database is: \"{connectionStringDomain2}\"");
            // End: Part of Sample1 project only

            Console.WriteLine("Launched");
        }
    }
}
