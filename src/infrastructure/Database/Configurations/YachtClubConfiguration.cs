using domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Database.Configurations;
public sealed class YachtClubConfiguration : IEntityTypeConfiguration<YachtClub>
{
    public void Configure(EntityTypeBuilder<YachtClub> builder)
    {
        builder.ToTable("YachtClubs");
        builder.Property(e=>e.Address1).HasMaxLength(128);
        builder.Property(e=>e.Address2).HasMaxLength(128);
        builder.Property(e=>e.State).HasMaxLength(2);
        builder.Property(e => e.PostalCode).HasMaxLength(10);
    }
}
