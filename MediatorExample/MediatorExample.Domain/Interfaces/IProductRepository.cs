using MediatorExample.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<int> AddPrdouct(Product product);

        Task<int> UpdateProduct(Product product);

        Task<int> DeleteProduct(Guid Id);

        Task<List<Product>> GetAllProduct();

        Task<Product> GetProductById();
    }
}
