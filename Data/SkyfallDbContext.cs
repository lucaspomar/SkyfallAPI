using Microsoft.EntityFrameworkCore;
using SkyfallAPI.Models;

namespace SkyfallAPI.Data;

public class SkyfallDbContext : DbContext
{

    public SkyfallDbContext(DbContextOptions options): base(options){}

    public DbSet<Spell> Spells { get; set; }

}
