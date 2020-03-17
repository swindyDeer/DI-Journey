using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace HelloDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //IMessageWrite write = new ConsoleMessageWriter();
            //write.PrintMessage();
            var typeName = configuration["message"];
            var type = Type.GetType(typeName);
            var write = (IMessageWrite)Activator.CreateInstance(type);
            write.PrintMessage();
        }
    }
}
