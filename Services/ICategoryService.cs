using PubSubApp_Backend.Database.Models;

namespace PubSubApp_Backend.Services
{
    public interface ICategoryService
    {
        void Add(List<Post> posts);
    }
}
