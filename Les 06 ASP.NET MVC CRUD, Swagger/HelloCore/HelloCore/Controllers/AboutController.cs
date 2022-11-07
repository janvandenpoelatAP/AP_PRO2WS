using Microsoft.AspNetCore.Mvc;

namespace HelloCore.Controllers;
[Route("[controller]")]
public class AboutController : Controller
{
    [Route("")]
    [HttpGet]
    public string Phone()
    {
        return "+32 489 50 49 12";
    }
    [Route("[action]")]
    [HttpGet]
    public string Address()
    {
        return "België";
    }
}
