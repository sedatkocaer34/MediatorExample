using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Domain;
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
            var response = new ProductAddResponse();
            if (request==null)
            {
                response.isSuccess = false;
                return response;
            }
            var product = new Product(Guid.NewGuid(), request.Name, request.Price, request.Quantity);
            await _productRepository.AddPrdouct(product);
            response.isSuccess = true;
            response.Id = product.Id;
            return response;
        }

        public async Task<ProductUpdateResponse> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            var response = new ProductUpdateResponse();
            if (request==null)
            {
                response.isSuccess = false;
                return response;
            }
            var checkProduct = await _productRepository.GetProductById(request.Id);
            if (checkProduct==null)
            {
                response.isSuccess = false;
                return response;
            }
             _productRepository.UpdateProduct(new Product(request.Id,request.Name,request.Price,request.Quantity));
            response.isSuccess = true;
            response.Id = checkProduct.Id;
            return response;
        }

        public async Task<ProductRemoveResponse> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var response = new ProductRemoveResponse();
            if (request == null)
            {
                response.isSuccess = false;
                return response;
            }
            var checkProduct = await _productRepository.GetProductById(request.Id);
            if (checkProduct == null)
            {
                response.isSuccess = false;
                return response;
            }
            _productRepository.DeleteProduct(checkProduct);
            response.isSuccess = true;
            return response;
        }
    }
}
