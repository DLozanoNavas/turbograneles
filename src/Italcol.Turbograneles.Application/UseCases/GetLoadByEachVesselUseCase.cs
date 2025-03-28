using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetLoadByEachVesselUseCase(IPortClientFactoryService portClientFactoryService) : IGetLoadByEachVesselUseCase
    {
        public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetLoadByEachVesselDto request)
        {
            // TODO: Implement logic for port and metalteco communication
            throw new NotImplementedException();
        }
    }
}
