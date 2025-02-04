using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyfallAPI.Models;

namespace SkyfallAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpellController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Spell>> GetAllSpells()
    {
        return Ok();
    }
}
