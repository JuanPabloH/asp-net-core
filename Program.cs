﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace asp_net_core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();


            using(var scope= host.Services.CreateScope())
            {
                var services= scope.ServiceProvider;
                try
                {
                    var context=services.GetRequiredService<EscuelaContext>();
                    context.Database.EnsureCreated();
                }catch(Exception ex)
                {
                    var logger= services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex,"An error ocurred creating the DB");
                }
            }
            
            

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
