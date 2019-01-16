using Dna;
using Dna.AspNet;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ANH.Web.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                // Add Dna Framework
                .UseDnaFramework(constructor =>
                {
                    // Configure framework

                    // Add file logger
                    constructor.AddFileLogger();
                })
                .UseStartup<Startup>();
        }
    }
}
