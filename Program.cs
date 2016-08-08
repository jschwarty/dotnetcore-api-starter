﻿using Microsoft.AspNetCore.Hosting;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:5001")
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
