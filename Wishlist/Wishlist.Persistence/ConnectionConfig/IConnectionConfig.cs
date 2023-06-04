using MongoDB.Driver;

namespace Wishlist.Persistence.ConnectionConfig
{
    public interface IConnectionConfig
    {
        IMongoClient MongoClient { get; }
        IMongoDatabase MongoDatabase { get; }
    }
}
