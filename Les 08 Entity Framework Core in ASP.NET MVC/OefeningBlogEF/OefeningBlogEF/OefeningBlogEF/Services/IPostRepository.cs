using OefeningBlogEF.Entities;
using OefeningBlogEF.ViewModels;

namespace OefeningBlogEF.Services
{
    public interface IPostRepository
    {
        int AddPost(Post post);
        IEnumerable<Entities.Category> GetCategories();
        PostCategory GetPost(int postId);
        List<PostCategory> GetPosts(int categoryId);
        void UpdatePost(Post post);
    }
}