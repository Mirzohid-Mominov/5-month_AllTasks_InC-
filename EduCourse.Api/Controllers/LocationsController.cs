using EduCourse.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace N67.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationsController : ControllerBase
{
    [HttpGet]
    public async ValueTask<IActionResult> Get([FromServices] AppDbContext dbContext)
    {
        var results = await dbContext.Locations.ToListAsync();
        return Ok(results);
    }
}