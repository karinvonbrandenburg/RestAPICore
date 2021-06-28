using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //seed
            //using (WebApiDotNetCoreContext ctx = new WebApiDotNetCoreContext())
            //{
            //    var film = new Film() { title = "The Empire", species = "", starships = "", vehicles = "", characters = "", planets = "" };

            //    ctx.Films.Add(film);
            //    ctx.SaveChanges();
            //}

          
            // CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<WebApiDotNetCoreContext>();
                    context.Database.EnsureDeleted();
                    context.Database.Migrate();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            host.Run();

            Console.WriteLine("API completed.");
            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
