using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace DataLayer
{
    public class GetConString
    {
        public static IConfiguration Configuration { get; set; }
        public static string ApplicationExeDirectory()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var appRoot = Path.GetDirectoryName(location);

            return appRoot;
        }

        public static string GetConnectionString(string key)
        {
            string applicationExeDirectory = ApplicationExeDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(applicationExeDirectory)
                .AddJsonFile("connection.json");
            Configuration = builder.Build();
            return Configuration[key];
        }
    }
}
