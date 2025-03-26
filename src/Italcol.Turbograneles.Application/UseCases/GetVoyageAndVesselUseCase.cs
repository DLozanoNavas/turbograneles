using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases;

public class GetVoyageAndVesselUseCase(IPortClientFactoryService portClientFactoryService) : IGetVoyageAndVesselUseCase
{
    public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetVoyageandVesselDto request)
    {
        /* TODO: Implement logic for response result
        Map dto to data and persist in DbContext
        Send data to Metalteco using its own client
        Respond to port */
        throw new NotImplementedException();
    }
}