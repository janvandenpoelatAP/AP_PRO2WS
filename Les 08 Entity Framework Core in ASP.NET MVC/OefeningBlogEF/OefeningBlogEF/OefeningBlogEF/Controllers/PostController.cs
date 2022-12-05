using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OefeningBlogEF.Entities;
using OefeningBlogEF.ViewModels;
using OefeningBlogEF.Services;

namespace OefeningBlogEF.Controllers;

[Route("api/[controller]")]
public class PostController : Controller
{
    private readonly IPostRepository postRepository;
    private readonly IMapper mapper;

    public PostController(IPostRepository postRepository, IMapper mapper)
    {
        this.postRepository = postRepository;
        this.mapper = mapper;
    }
    [HttpGet]
    [Route("GetCategories")]
    public IActionResult GetCategories()
    {
        List<Entities.Category> categories = postRepository.GetCategories().ToList();
        if (categories == null)
        {
            return NotFound();
        }
        return Ok(mapper.Map<List<ViewModels.Category>>(categories));
    }

    [HttpGet]
    [Route("GetPosts")]
    public IActionResult GetPosts(int categoryId)
    {
        var posts = postRepository.GetPosts(categoryId);

        if (posts == null)
        {
            return NotFound();
        }

        return Ok(posts);
    }
    [HttpGet]
    [Route("GetPost")]
    public IActionResult GetPost(int postId)
    {
        var post = postRepository.GetPost(postId);

        if (post == null)
        {
            return NotFound();
        }

        return Ok(post);
    }

    [HttpPost]
    [Route("AddPost")]
    public IActionResult AddPost(PostCreateViewModel model)
    {
        var post = mapper.Map<Post>(model);
        postRepository.AddPost(post);
        return NoContent();
    }

    [HttpPut]
    [Route("UpdatePost")]
    public IActionResult UpdatePost(PostUpdateViewModel model)
    {
        var post = mapper.Map<Post>(model);
        postRepository.UpdatePost(post);
        return NoContent();
    }
}
