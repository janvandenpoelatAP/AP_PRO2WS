using Microsoft.AspNetCore.Mvc;

namespace StarTrekApi.Controllers;

public class HomeController : Controller
{
    private readonly SeriesPortType seriesPortType;

    public HomeController(SeriesPortType seriesPortType)
    {
        this.seriesPortType = seriesPortType;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("Series/{title}")]
    public IActionResult Series(string title)
    {
        getSeriesBaseRequest getSeriesBaseRequest = new getSeriesBaseRequest(new SeriesBaseRequest
        {
            title = title
        });
        var result = seriesPortType.getSeriesBaseAsync(getSeriesBaseRequest).GetAwaiter().GetResult().SeriesBaseResponse;

        return Ok(result.series);
    }
}
