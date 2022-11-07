using HelloCore.Entities;

namespace HelloCore.ViewModels;

public class HomePageViewModel
{
    public string CurrentMessage { get; set; }
    public IEnumerable<Restaurant>Restaurants { get; set; }
}
