   //tinfo200:[2021-03-13-jmc64-dykstra1] - added extensions to Contoso and .configuration since the services are related to the databse access

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
           
                //tinfo200:[2021-03-13-jmc64-dykstra1] -Host builder involves the host access in the current build when running.
           
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }
        

    //tinfo200:[2021-03-13-jmc64-dykstra1] - Errors in case the db info does not exist and displays the error message to the user.

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured while seeding the database.");
                }
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
