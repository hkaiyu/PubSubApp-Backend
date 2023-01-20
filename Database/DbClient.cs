using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PubSubApp_Backend.Database.Models;

namespace PubSubApp_Backend.Database
{
    public class DbClient : IDbClient

    {
        private readonly IMongoDatabase _database;
        public DbClient(IOptions<DbConfig> dbConfig) 
        {
            var client = new MongoClient(dbConfig.Value.ConnectionString);
            _database = client.GetDatabase(dbConfig.Value.DatabaseName);
        }
        public IMongoCollection<Post> GetPostsCollections()
        {
            return _database.GetCollection<Post>("Posts");
        }
    }
}
