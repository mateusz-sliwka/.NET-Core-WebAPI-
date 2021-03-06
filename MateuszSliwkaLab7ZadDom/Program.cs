using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MateuszSliwkaLab7ZadDom;
using MateuszSliwkaLab7ZadDom.Models;
using MateuszSliwkaLab7ZadDom.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MateuszSliwkaLab7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
