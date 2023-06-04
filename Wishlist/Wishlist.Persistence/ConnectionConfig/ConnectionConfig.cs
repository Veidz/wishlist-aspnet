using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Wishlist.Persistence.ConnectionConfig
{
    public class ConnectionConfig : IConnectionConfig
    {
        public IMongoClient MongoClient { get; }
        public IMongoDatabase MongoDatabase { get; }

        public ConnectionConfig(IOptions<DbOptions> options)
        {
            MongoClient = new MongoClient(options.Value.Connection);
            MongoDatabase = MongoClient.GetDatabase(options.Value.Name);
        }
    }
}
