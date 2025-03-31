using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces;
public interface ISendVesselStatusUseCase
{
    public Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(SendVesselStatusDto request);
}
