using domain.entities;
using infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class YachtClubController : ControllerBase
{
    private readonly YachtDbContext _dbContext;
    public YachtClubController()
    {
        var dbOpts = new DbContextOptionsBuilder<YachtDbContext>();
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddJsonFile("appsettings.json");
        var configRoot = configBuilder.Build();


        dbOpts.UseSqlServer(configRoot.GetConnectionString("DatabaseConnection"));
        _dbContext = new YachtDbContext(dbOpts.Options);
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
    {
        var retval = await _dbContext.YachtClubs.ToListAsync(cancellationToken);
        return Ok(retval);
    }

    [HttpPost]
    public async Task<IActionResult> Post(YachtClub yachtClub, CancellationToken cancellationToken = default)
    {
        _dbContext.YachtClubs.Add(yachtClub);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Ok(yachtClub);
    }
}
