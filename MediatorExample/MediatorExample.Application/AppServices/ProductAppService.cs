using MediatorExample.Application.Interfaces;
using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Queries.Request;
using MediatorExample.Domain.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.Application.AppServices
{
    public class ProductAppService : IProductService
    {
        private IMediator _mediator;

        public ProductAppService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ProductAddResponse> AddProduct(ProductAddCommand productAddCommand)
        {
           return await _mediator.Send(productAddCommand);
        }

        public async Task<List<GetAllProductQueryResponse>> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return await _mediator.Send(getAllProductQueryRequest);
        }

        public async Task<GetByIdProductQueryResponse> GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            return await _mediator.Send(getByIdProductQueryRequest);
        }

        public async Task<ProductRemoveResponse> RemoveProduct(ProductRemoveCommand productRemoveCommand)
        {
            return await _mediator.Send(productRemoveCommand);
        }

        public async Task<ProductUpdateResponse> UpdateProduct(ProductUpdateCommand productUpdateCommand)
        {
            return await _mediator.Send(productUpdateCommand);
        }
    }
}
