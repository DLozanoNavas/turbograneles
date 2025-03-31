using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces
{
    public interface IGetGateOutUseCase
    {
        Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetGateOutDto request);
    }
}
