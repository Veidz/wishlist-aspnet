using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Wishlist.Domain.Entities
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; }

        [BsonRequired]
        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; } = string.Empty;

        [BsonRequired]
        [BsonRepresentation(BsonType.String)]
        public string ImageUrl { get; set; } = string.Empty;

        [BsonRequired]
        [BsonRepresentation(BsonType.String)]
        public string ProductUrl { get; set; } = string.Empty;
    }
}
