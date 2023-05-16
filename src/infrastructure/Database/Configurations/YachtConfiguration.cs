using domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Database.Configurations;
public sealed class YachtConfiguration : IEntityTypeConfiguration<Yacht>
{
    public void Configure(EntityTypeBuilder<Yacht> builder)
    {
        builder.ToTable("yachts");
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Make)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.Make)
            .IsRequired()
            .HasMaxLength(100);
    }
}
