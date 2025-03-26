using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Adapters.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class GetVoyageAndVesselController(IGetVoyageAndVesselUseCase getVoyageAndVesselUseCase) : Controller
{
    [HttpPost]
    public async Task<ActionResult<UntypedNode>> Index([FromBody] GetVoyageandVesselDto request)
    {
        var voyageAndVessel = await getVoyageAndVesselUseCase.ExecuteAsync(request);

        return Ok(voyageAndVessel);
    }
}