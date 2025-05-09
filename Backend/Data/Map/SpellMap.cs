using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyfallAPI.Models;

namespace SkyfallAPI.Data.Map;

public class SpellMap : IEntityTypeConfiguration<Spell>
{
    public void Configure(EntityTypeBuilder<Spell> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Action).IsRequired();
        builder.Property(x => x.Cost).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1000);
        builder.Property(x => x.Execution).HasMaxLength(50);
        builder.Property(x => x.Range).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Target).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Components).HasMaxLength(50);
        builder.Property(x => x.Duration).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Attack).HasMaxLength(50);
        builder.Property(x => x.Effect).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.Layer).IsRequired();
    }
}
