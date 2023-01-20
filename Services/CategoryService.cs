using MongoDB.Driver;
using PubSubApp_Backend.Database;
using PubSubApp_Backend.Database.Models;

namespace PubSubApp_Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Post> _postsCollection;

        public CategoryService(IDbClient dbClient) 
        {
            _postsCollection = dbClient.GetPostsCollections();
        }
        public void Add(List<Post> posts)
        {
            _postsCollection.InsertMany(posts);
        }
    }
}
