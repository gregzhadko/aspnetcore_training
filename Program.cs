using System;
using Microsoft.AspNetCore.Hosting;
using MovingToTheWeb;

namespace aspnetcore_training
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
							.UseKestrel()
							.UseStartup<Startup>()
							.Build();
							
			host.Run();
        }
    }
}
