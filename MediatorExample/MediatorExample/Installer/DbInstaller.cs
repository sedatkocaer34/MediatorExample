using MediatorExample.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Installer
{
    public static class DbInstaller
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MediatorExampleDataContext>(dboptions => dboptions.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
