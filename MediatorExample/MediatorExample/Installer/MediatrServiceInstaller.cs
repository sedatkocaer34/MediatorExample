using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Handlers.CommandHandlers;
using MediatorExample.Domain.Handlers.QueryHandlers;
using MediatorExample.Domain.Queries.Request;
using MediatorExample.Domain.Queries.Response;
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
            // COMMAND
            services.AddScoped<IRequestHandler<ProductAddCommand, ProductAddResponse>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<ProductRemoveCommand, ProductRemoveResponse>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<ProductUpdateCommand, ProductUpdateResponse>, ProductCommandHandler>();

            // QUERY
            services.AddScoped<IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>, ProductQueryHandler>();
            services.AddScoped<IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>, ProductQueryHandler>();

        }
    }
}
