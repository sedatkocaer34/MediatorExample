using MediatorExample.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task AddPrdouct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);

        Task<List<Product>> GetAllProduct();

        Task<Product> GetProductById(Guid Id);
    }
}
