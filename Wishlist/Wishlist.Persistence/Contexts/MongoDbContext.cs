using MongoDB.Driver;
using Wishlist.Persistence.ConnectionConfig;

namespace Wishlist.Persistence.Contexts
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IConnectionConfig ConnectionConfig;

        public MongoDbContext(IConnectionConfig connectionConfig)
        {
            ConnectionConfig = connectionConfig;
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            return ConnectionConfig.MongoDatabase.GetCollection<T>(typeof(T).Name);
        }
    }
}
