using MongoDB.Driver;
using Wishlist.Persistence.Contexts;

namespace Wishlist.Persistence.Persistence
{
    public class BasePersistence<D> where D : class
    {
        protected IMongoDbContext MongoDbContext;
        protected IMongoCollection<D> MongoCollection;

        public BasePersistence(IMongoDbContext mongoDbContext)
        {
            MongoDbContext = mongoDbContext;
            MongoCollection = mongoDbContext.GetCollection<D>();
        }
    }
}
