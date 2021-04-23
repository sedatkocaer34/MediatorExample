using MediatorExample.Data.Context;
using MediatorExample.Domain.Domain;
using MediatorExample.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MediatorExampleDataContext _ediatorExampleDataContext;
        private readonly DbSet<Product> _dbProduct;
        public ProductRepository(MediatorExampleDataContext ediatorExampleDataContext)
        {
            _ediatorExampleDataContext = ediatorExampleDataContext ?? throw new ArgumentNullException(nameof(ediatorExampleDataContext));
            _dbProduct = _ediatorExampleDataContext.Product;
        }

        public async Task<int> AddPrdouct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteProduct(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
