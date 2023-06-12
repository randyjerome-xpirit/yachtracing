using infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class YachtController : ControllerBase
{
    private readonly YachtDbContext _dbContext;

    public YachtController(YachtDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
    {
        var retval = await _dbContext.yachts.ToListAsync(cancellationToken);
        return Ok(retval);
    }
}
