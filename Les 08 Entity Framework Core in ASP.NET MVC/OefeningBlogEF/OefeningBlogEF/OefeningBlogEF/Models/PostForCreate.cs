namespace OefeningBlogEF.Models
{
    public class PostForCreate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
