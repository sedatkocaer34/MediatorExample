using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Interfaces;
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

        private IProductRepository _productRepository;

        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductAddResponse> Handle(ProductAddCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductUpdateResponse> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductRemoveResponse> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
