using System.Collections.Generic;
using System.Threading.Tasks;
using Wishlist.Domain.Entities;

namespace Wishlist.Application.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
