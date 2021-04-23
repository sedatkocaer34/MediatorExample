using MediatorExample.Data.Context;
using MediatorExample.Domain.Domain;
using MediatorExample.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddPrdouct(Product product)
        {
             await _dbProduct.AddAsync(product);
        }

        public void DeleteProduct(Product product)
        {
            _dbProduct.Remove(product);
        }

        public async Task<List<Product>> GetAllProduct()
        {
            return await _dbProduct.ToListAsync();
        }

        public async Task<Product> GetProductById(Guid Id)
        {
            return await _dbProduct.FindAsync(Id);
        }

        public void UpdateProduct(Product product)
        {
            _dbProduct.Update(product);
        }
    }
}
