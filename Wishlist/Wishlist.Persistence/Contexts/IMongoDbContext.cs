using MongoDB.Driver;

namespace Wishlist.Persistence.Contexts
{
    public interface IMongoDbContext
    {
        IMongoCollection<T> GetCollection<T>();
    }
}
