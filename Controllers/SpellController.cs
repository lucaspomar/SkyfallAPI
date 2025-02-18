using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
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
    private readonly IValidator<Spell> _spellValidator;

    public SpellController(ISpellRepository spellRepository, IValidator<Spell> spellValidator)
    {
        _spellRepository = spellRepository;
        _spellValidator = spellValidator;
    }

    [HttpGet]
    public ActionResult<List<Spell>> GetAllSpells([FromQuery] int page = 1, [FromQuery] int size = 10)
    {
        int totalItems = _spellRepository.CountAll();
        int totalPages = (int)Math.Ceiling((double) totalItems / size);
        List<Spell> spells = _spellRepository.GetPage(page - 1, size);
        return Ok(new
        {
            totalItems,
            totalPages,
            page,
            size,
            spells,
        });
    }

    [HttpGet("{id}")]
    public ActionResult<Spell> GetSpellById(long id)
    {
        Spell? spell = _spellRepository.GetById(id);

        if (spell == null)
        {
            return NotFound();
        }

        return Ok(spell);
    }

    [HttpPost]
    public ActionResult<Spell> PostSpell([FromBody] Spell spell)
    {
        ValidationResult result = _spellValidator.Validate(spell);
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem(ModelState);
        }

        _spellRepository.Add(spell);
        _spellRepository.Save();
        return Created();
    }

    [HttpDelete("{id}")]
    public ActionResult<Spell> DeleteSpell(long id)
    {
        Spell? spell = _spellRepository.GetById(id);

        if (spell == null)
        {
            return NotFound();
        }

        _spellRepository.Delete(spell);
        _spellRepository.Save();
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult<Spell> UpdateSpell([FromBody] Spell spell, long id)
    {
        if (spell.Id != id)
        {
            return BadRequest();
        }

        if (!_spellRepository.CheckIfExists(id))
        {
            return NotFound();
        }

        ValidationResult result = _spellValidator.Validate(spell);
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            return ValidationProblem(ModelState);
        }

        _spellRepository.Update(spell);
        _spellRepository.Save();
        return Ok(spell);
    }
}
