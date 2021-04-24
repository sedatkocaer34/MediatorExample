using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Command.Response;
using MediatorExample.Domain.Queries.Request;
using MediatorExample.Domain.Queries.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductAddResponse> AddProduct(ProductAddCommand productAddCommand);

        Task<ProductRemoveResponse> RemoveProduct(ProductRemoveCommand productRemoveCommand);

        Task<ProductUpdateResponse> UpdateProduct(ProductUpdateCommand productUpdateCommand);

        Task<List<GetAllProductQueryResponse>> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest);

        Task<GetByIdProductQueryResponse> GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest);
    }
}
