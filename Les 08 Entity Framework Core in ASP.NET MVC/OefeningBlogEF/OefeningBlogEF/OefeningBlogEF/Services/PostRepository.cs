using OefeningBlogEF.Entities;

namespace OefeningBlogEF.Services
{
    public class PostRepository
    {
        private BlogContext context;

        public PostRepository(BlogContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }
        public void Add(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
            context.SaveChanges();
        }
        /*
                    public Restaurant Get(int id)
                    {
                        return context.Restaurants.FirstOrDefault(x => x.Id == id);
                    }
                    public void Add(Restaurant restaurant)
                    {
                        context.Restaurants.Add(restaurant);
                        context.SaveChanges();
                    }
                    public void Delete(Restaurant restaurant)
                    {
                        var toDelete = Get(restaurant.Id);
                        context.Restaurants.Remove(toDelete);
                        context.SaveChanges();
                    }
                    public void Update(Restaurant restaurant)
                    {
                        var oldRestaurant = Get(restaurant.Id);
                        oldRestaurant.Name = restaurant.Name;
                        oldRestaurant.CuisineType = restaurant.CuisineType;
                        context.SaveChanges();
                    }
                }
        */
    }
}
