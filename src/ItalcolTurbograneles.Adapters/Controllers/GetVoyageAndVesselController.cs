using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients;
using Microsoft.AspNetCore.Mvc;

namespace ItalcolTurbograneles.Adapters.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class GetVoyageAndVesselController(IGetVoyageAndVesselUseCase getVoyageAndVesselUseCase) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index([FromBody] GetVoyageandVesselDto request)
    {
        var voyageAndVessel = await getVoyageAndVesselUseCase.ExecuteAsync(request);

        return Ok(voyageAndVessel);
    }
}