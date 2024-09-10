using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Sample1.Administration.Infra.Db;


namespace Dotpie.API.Bootstrap
{
    public class Bootstrap
    {

        //Temporary for Sample1 project
        public static IConfiguration? Configuration { get; private set; }


        public static void ConfigureBindings(IServiceCollection services, IConfiguration configuration)
        {
            /* the following "if" seems superfluous as values can be defined in appsettings.Development.json, appsettings.Staging.json and appsettings.json,
             * Code to be modified and cleaned after checking it works. Not sure if there is a reason why former developer used this of the with conditions.
             * And does the code in the "else" statement actually work ? What happens in Staging and Production ?
             */

            string? domain1ConnectionString, domain2ConnectionString;
            
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                domain1ConnectionString = configuration.GetConnectionString("Domain1");
                domain2ConnectionString = configuration.GetConnectionString("Domain1");

                //Local
                services.AddDbContext<Domain1DbContext>(options => options.UseSqlServer(domain1ConnectionString));
                services.AddDbContext<Domain2DbContext>(options => options.UseSqlServer(domain2ConnectionString));
            }
            else
            {
                //Removed from Sample1 example
            }

            //Dependency injections removed from Sample1 example


            //Temporary for Sample1 project
            Bootstrap.Configuration = configuration;

        }
    }
}