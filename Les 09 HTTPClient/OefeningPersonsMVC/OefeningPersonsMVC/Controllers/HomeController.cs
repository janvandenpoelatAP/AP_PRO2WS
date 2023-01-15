using Microsoft.AspNetCore.Mvc;
using OefeningPersonsMvc.Entities;
using OefeningPersonsMvc.Services;
using OefeningPersonsMVC.ViewModels;

namespace OefeningPersonsMvc.Controllers;

[Route("[Controller]")]
public class HomeController : Controller
{
    private IPersonData personData;

    public HomeController(IPersonData personData)
    {
        this.personData = personData;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = personData.GetAll();
        return Ok(model);
    }
    [HttpGet("{id}")]
    public IActionResult Details(int id)
    {
        var model = personData.Get(id);
        if (model == null)
        {
            return NotFound();
        }
        return Ok(model);
    }

    [HttpPost]
    public IActionResult Create([FromBody]PersonCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var newPerson = new Person
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Address = model.Address,
            Gender = model.Gender
        };
        newPerson = personData.Add(newPerson);
        return CreatedAtAction(nameof(Create), new { id = newPerson.Id }, newPerson);
    }
}
