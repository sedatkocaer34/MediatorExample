using AutoMapper;
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
        private IMapper _mapper;

        public ProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetByIdProductQueryResponse>(await _productRepository.GetProductById(request.Id));
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetAllProductQueryResponse>>(await _productRepository.GetAllProduct());
        }
    }
}
