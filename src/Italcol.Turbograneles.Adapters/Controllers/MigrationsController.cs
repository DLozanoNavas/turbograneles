using Italcol.Turbograneles.Adapters.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Adapters.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class MigrationsController(DataContext dataContext) : Controller
{
    [HttpPost]
    public async Task<ActionResult<UntypedNode>> Index()
    {
        await dataContext.Database.MigrateAsync();
        return Ok("Database Migrated");
    }
}