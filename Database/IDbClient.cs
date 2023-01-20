using MongoDB.Driver;
using PubSubApp_Backend.Database.Models;

namespace PubSubApp_Backend.Database
{
    public interface IDbClient
    {
        IMongoCollection<Post> GetPostsCollections();

    }
}
