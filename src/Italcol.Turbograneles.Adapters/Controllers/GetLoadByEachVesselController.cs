using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Kiota.Abstractions.Serialization;

namespace ItalcolTurbograneles.Adapters.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class GetLoadByEachVesselController(IGetLoadByEachVesselUseCase getLoadByEachVesselUseCase) : Controller
    {
        [HttpPost]
        public async Task<ActionResult<UntypedNode>> Index([FromBody] GetLoadByEachVesselDto request)
        {
            var loadByEachVessel = await getLoadByEachVesselUseCase.ExecuteAsync(request);

            return Ok(loadByEachVessel);
        }
    }
}
