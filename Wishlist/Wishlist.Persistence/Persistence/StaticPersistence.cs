using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wishlist.Persistence.Contexts;
using Wishlist.Persistence.Contracts;

namespace Wishlist.Persistence.Persistence
{
    public class StaticPersistence<D> : BasePersistence<D>, IStaticPersistence<D> where D : class
    {
        public StaticPersistence(IMongoDbContext mongoDbContext) : base(mongoDbContext) { }

        public async Task<IEnumerable<D>> GetAllAsync()
        {
            return await MongoCollection.Find(Builders<D>.Filter.Empty).ToListAsync();
        }
    }
}
