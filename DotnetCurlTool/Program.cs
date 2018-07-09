using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.CommandLine;

namespace DotnetCurlTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mapping = new Dictionary<string, string>()
            {
                ["--h"] = "header",
                ["-h"] = "header",
            };
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddCommandLine(args, mapping);
            IConfiguration configuration = configurationBuilder.Build();
            Console.WriteLine(configuration.GetValue<string>("header"));

            Console.WriteLine("Hello World!");
        }
    }
}
