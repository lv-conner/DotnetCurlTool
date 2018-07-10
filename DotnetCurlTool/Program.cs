using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.CommandLine;
using System.Net.Http;
using System.Threading.Tasks;

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

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.chiphell.com/");
            var bytes = client.GetByteArrayAsync("data/attachment/portal/201710/05/172741mion2l2idnerm7ye.png").GetAwaiter().GetResult();
            var files =  File.Open("hello.png", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            files.Write(bytes, 0, bytes.Length);



            Console.WriteLine("Hello World!");
        }
    }
}
