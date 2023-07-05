using domain.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Database;
public class YachtDbContext : DbContext
{
    public YachtDbContext(DbContextOptions<YachtDbContext> options) : base(options)
    {
        
    }
    public DbSet<Yacht> Yachts { get; set; }
    public DbSet<YachtClub> YachtClubs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
