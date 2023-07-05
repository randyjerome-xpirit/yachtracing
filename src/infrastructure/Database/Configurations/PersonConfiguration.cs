using domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Database.Configurations;
public sealed class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);
        builder.HasMany(e => e.Yachts).WithOne(e => e.Owner);
        builder.HasMany(e => e.Crews).WithOne(e => e.Person);
    }
}
