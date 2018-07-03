using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;

namespace DataLayer
{
    public class GetConString
    {
        public static string ApplicationExeDirectory()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var appRoot = Path.GetDirectoryName(location);

            return appRoot;
        }

        public static IConfigurationRoot GetAppSettings()
        {
            string applicationExeDirectory = ApplicationExeDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(applicationExeDirectory)
                .AddJsonFile("connection.json");
            return builder.Build();
        }
    }
}
