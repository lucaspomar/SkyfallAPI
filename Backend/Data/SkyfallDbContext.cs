using Microsoft.EntityFrameworkCore;
using SkyfallAPI.Data.Map;
using SkyfallAPI.Models;

namespace SkyfallAPI.Data;

public class SkyfallDbContext : DbContext
{

    public SkyfallDbContext(DbContextOptions options): base(options){}

    public DbSet<Spell> Spells { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SpellMap());

        base.OnModelCreating(modelBuilder);
    }
}
