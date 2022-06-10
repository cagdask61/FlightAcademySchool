using FlightAcademySchool.Persistence.Configurations;
using FlightAcademySchool.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAcademySchool.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
        }

        public static void AddPersistenceDbContexts(this IServiceCollection services)
        {
            services.AddDbContext<ProjectDbContext>(options => options.UseNpgsql(ConnectionString.Get("PostgreSql")));
        }
    }
}
