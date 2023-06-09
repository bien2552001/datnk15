using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACKEND
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
                // Thêm danh sách các địa chỉ IP và cổng ở đây
                webBuilder.UseUrls(
                "http://192.168.1.105:5000",
                "https://192.168.1.105:5001",
                "https://localhost:5001",
                "http://localhost:5000"); 
                
                webBuilder.UseStartup<Startup>();
            });
    }
}
