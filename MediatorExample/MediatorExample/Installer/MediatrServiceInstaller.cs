using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Handlers.CommandHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Installer
{
    public static class MediatrServiceInstaller
    {
        public static void AddMediatrService(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<ProductAddCommand, ProductAddResponse>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<ProductRemoveCommand, ProductRemoveResponse>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<ProductUpdateCommand, ProductUpdateResponse>, ProductCommandHandler>();
        }
    }
}
