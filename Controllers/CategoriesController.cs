using Microsoft.AspNetCore.Mvc;
using PubSubApp_Backend.Database.Models;
using PubSubApp_Backend.Services;

namespace PubSubApp_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost]
        public IActionResult CreateGroup(List<Post> posts) 
        {
            _categoryService.Add(posts);
            return StatusCode(201);
        }
    }
}
