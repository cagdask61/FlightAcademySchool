using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAcademySchool.Persistence.Configurations
{
    public static class ConnectionString
    {
        public static string Get(string connectionStringName = "MsSql")
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/FlightAcademySchool.WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString(connectionStringName);
        }
    }
}
