using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BluemixDeploySample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:" + (Environment.GetEnvironmentVariable("PORT") ?? "5000"))
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
