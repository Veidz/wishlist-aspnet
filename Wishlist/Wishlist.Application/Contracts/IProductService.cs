using System.Collections.Generic;
using System.Threading.Tasks;
using Wishlist.Application.DTOs.Product;
using Wishlist.Domain.Entities;

namespace Wishlist.Application.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductOutput>> GetAllAsync();
    }
}
