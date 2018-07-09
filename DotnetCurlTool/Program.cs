using System;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.CommandLine;

namespace DotnetCurlTool
{
    class Program
    {
        static void Main(string[] args)
        {

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddCommandLine(args);

            Console.WriteLine("Hello World!");
        }
    }
}
