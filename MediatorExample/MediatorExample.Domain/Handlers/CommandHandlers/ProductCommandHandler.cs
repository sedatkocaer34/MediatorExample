using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Domain.Handlers.CommandHandlers
{
    public class ProductCommandHandler : IRequestHandler<ProductAddCommand, ProductAddResponse>,
        IRequestHandler<ProductUpdateCommand, ProductUpdateResponse>,
        IRequestHandler<ProductRemoveCommand, ProductRemoveResponse>
    {
        public async Task<ProductAddResponse> Handle(ProductAddCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ProductUpdateResponse> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ProductRemoveResponse> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
