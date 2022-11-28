using Microsoft.AspNetCore.Mvc;
using OefeningBlogEF.Services;

namespace OefeningBlogEF.Controllers
{
    [Route("[controller]/[action]")]
    public class PostController : Controller
    {
        private readonly PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(postRepository.GetCategories());
        }
    }
}
