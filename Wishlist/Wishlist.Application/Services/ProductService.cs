using System.Collections.Generic;
using System.Threading.Tasks;
using Wishlist.Application.Contracts;
using Wishlist.Domain.Entities;
using Wishlist.Persistence.Contracts;

namespace Wishlist.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IStaticPersistence<Product> ProductStaticPersistence;

        public ProductService(IStaticPersistence<Product> productStaticPersistence)
        {
            ProductStaticPersistence = productStaticPersistence;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            IEnumerable<Product> products = await ProductStaticPersistence.GetAllAsync();
            return products;
        }
    }
}
