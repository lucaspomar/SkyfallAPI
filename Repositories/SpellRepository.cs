using SkyfallAPI.Data;
using SkyfallAPI.Models;
using SkyfallAPI.Repositories.Interfaces;

namespace SkyfallAPI.Repositories;

public class SpellRepository : GenericRepository<Spell>, ISpellRepository
{
    public SpellRepository(SkyfallDbContext context) : base(context)
    {
    }
}
