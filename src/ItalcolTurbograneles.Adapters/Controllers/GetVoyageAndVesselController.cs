using Italcol.Turbograneles.Application.UseCases;
using Italcol.TurboGraneles.Clients;
using Microsoft.AspNetCore.Mvc;

namespace ItalcolTurbograneles.Adapters.Controllers;

public class GetVoyageAndVesselController(GetVoyageAndVesselUseCase getVoyageAndVesselUseCase) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(GetVoyageandVesselDto request)
    {
        var voyageAndVessel = await getVoyageAndVesselUseCase.ExecuteAsync(request);

        return Ok(voyageAndVessel);
    }
}