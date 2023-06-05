using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wishlist.Application.Contracts;
using Wishlist.Application.DTOs.Product;
using Wishlist.Domain.Entities;
using Wishlist.Persistence.Contracts;

namespace Wishlist.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IStaticPersistence<Product> ProductStaticPersistence;
        private readonly IMapper Mapper;

        public ProductService(IStaticPersistence<Product> productStaticPersistence, IMapper mapper)
        {
            ProductStaticPersistence = productStaticPersistence;
            Mapper = mapper;
        }

        public async Task<IEnumerable<ProductOutput>> GetAllAsync()
        {
            IEnumerable<Product> products = await ProductStaticPersistence.GetAllAsync();
            IEnumerable<ProductOutput> productsOutput = Mapper.Map<IEnumerable<ProductOutput>>(products);
            return productsOutput;
        }
    }
}
