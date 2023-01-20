using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PubSubApp_Backend.Database.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Message { get; }

    }
}
