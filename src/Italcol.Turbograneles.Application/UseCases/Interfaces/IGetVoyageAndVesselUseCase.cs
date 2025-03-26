using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces;

public interface IGetVoyageAndVesselUseCase
{
    Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetVoyageandVesselDto request);
}