using domain.entities;
using infrastructure.Database;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.tests.Database;
public class UnitTestDbContext : YachtDbContext
{
    private static DbContextOptions<YachtDbContext> GetOptions()
    {
        var dbOpts = new DbContextOptionsBuilder<YachtDbContext>();
        var connection = new SqliteConnection("Filename=:memory:");
        connection.Open();
        dbOpts.UseSqlite(connection);

        return dbOpts.Options;
    }



    protected UnitTestDbContext() : base(GetOptions())
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<YachtClub>()
            .HasData(GenerateYachtClubs());
    }

    protected virtual IEnumerable<YachtClub> GenerateYachtClubs()
    {
        return Enumerable.Empty<YachtClub>();
    }
}
