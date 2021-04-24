using MediatorExample.Application.AppServices;
using MediatorExample.Application.Interfaces;
using MediatorExample.Data.Context;
using MediatorExample.Data.Repository;
using MediatorExample.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Installer
{
    public static class ServiceInstaller
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IProductService, ProductAppService>();
            services.AddScoped<MediatorExampleDataContext>();
        }
    }
}
