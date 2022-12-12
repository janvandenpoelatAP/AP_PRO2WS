using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SmallApi.Controlers;

public class Secret
{
    public string Message { get; set; }
}
public class HomeController : Controller
{
    public static Secret Secret { get; set; } = new Secret { Message = "This is a secret message" }; 
    [HttpGet]
    [Route("Secret")]
    [Authorize("read")]
    public IActionResult Index()
    {
        return Ok(Secret);
    }
    [HttpPost]
    [Route("Secret")]
    [Authorize("write")]
    public IActionResult PostSecret([FromBody] Secret secret)
    {
        Secret = secret;
        return CreatedAtAction(nameof(PostSecret), secret);
    }
}
