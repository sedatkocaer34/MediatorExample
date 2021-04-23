using MediatorExample.Domain.Interfaces;
using MediatorExample.Domain.Queries.Request;
using MediatorExample.Domain.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Domain.Handlers.QueryHandlers
{
    public class ProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>,
        IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private IProductRepository _productRepository;

        public ProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
