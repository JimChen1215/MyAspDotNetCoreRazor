using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetRazorDemo.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetRazorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //https://docs.microsoft.com/aspnet/core/data/ef-rp/intro
            //MF by JC on 08/22/2020
            var host = CreateHostBuilder(args).Build();
            //CreateDbIfNotExists(host);   ----MF on 09/06/2020. Use script genreated from EF Tool to create database
            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                ////MF by JC on 08/22/2020 
                //try
                //{
                //    var context = services.GetRequiredService<SchoolContext>();
                //    //context.Database.EnsureCreated();         // 1st step to create a database
                //    DbInitializer.Initialize(context);          // 2nd step: fill values to db
                //}
                //catch (Exception ex)
                //{
                //    var logger = services.GetRequiredService<ILogger<Program>>();
                //    logger.LogError(ex, "An error occurred creating the DB.");
                //}
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
