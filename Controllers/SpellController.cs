using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyfallAPI.Models;
using SkyfallAPI.Repositories.Interfaces;

namespace SkyfallAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpellController : ControllerBase
{
    private readonly ISpellRepository _spellRepository;

    public SpellController(ISpellRepository spellRepository)
    {
        _spellRepository = spellRepository;
    }

    [HttpGet]
    public ActionResult<List<Spell>> GetAllSpells()
    {
        List<Spell> spells = _spellRepository.GetAll();
        return Ok(spells);
    }

    [HttpGet("{id}")]
    public ActionResult<Spell> GetSpellById(long id)
    {
        Spell? spell = _spellRepository.GetById(id);
        return Ok(spell);
    }

    [HttpPost]
    public ActionResult<Spell> PostSpell([FromBody] Spell spell)
    {
        _spellRepository.Add(spell);
        _spellRepository.Save();
        return Created();
    }
}
