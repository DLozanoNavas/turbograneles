using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces
{
    public interface ISendTruckFinalizationLoadingUseCase
    {
        Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(SendTruckFinalizationLoadingDto request);
    }
}
