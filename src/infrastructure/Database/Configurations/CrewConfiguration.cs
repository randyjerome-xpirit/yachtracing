using domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Database.Configurations;
public sealed class CrewConfiguration : IEntityTypeConfiguration<Crew>
{
    public void Configure(EntityTypeBuilder<Crew> builder)
    {
        builder.ToTable("Crew");
        builder.HasOne(e => e.Person)
            .WithMany(e => e.Crews)
            .HasForeignKey(e=>e.PersonId);

        builder.Property(e => e.position)
            .HasConversion<string>();
    }
}
