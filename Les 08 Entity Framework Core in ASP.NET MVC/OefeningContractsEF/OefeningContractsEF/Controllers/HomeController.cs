using Microsoft.AspNetCore.Mvc;
using OefeningContractEF.Models;
using OefeningContractEF.Services;
using OefeningContractEF.ViewModels;

namespace OefeningContractEF.Controllers;
[Route("[controller]/[action]")]
public class HomeController : Controller
{
    private readonly IContractRepository contractRepository;

    public HomeController(IContractRepository contractRepository)
    {
        this.contractRepository = contractRepository;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(contractRepository.GetAll());
    }
    [HttpGet("id")]
    public IActionResult Get(int id)
    {
        var contract = contractRepository.Get(id);
        if (contract is null)
        {
            return NotFound();
        }
        return Ok(contract);
    }
    [HttpPost]
    public IActionResult Create([FromBody] ContractCreateViewModel contractCreateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var newContract = new Contract()
        {
            Code = contractCreateViewModel.Code,
            Description = contractCreateViewModel.Description,
            Type = contractCreateViewModel.Type,
            State = contractCreateViewModel.State
        };
        contractRepository.Add(newContract);
        return CreatedAtAction(nameof(Create), new { newContract.Id }, newContract);
    }
}
