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
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                // Add Dna Framework
                .UseDnaFramework(constructor =>
                {
                    // Configure framework

                    // Add file logger
                    constructor.AddFileLogger();
                })
                .UseStartup<Startup>()
                .Build();
        }
    }
}
