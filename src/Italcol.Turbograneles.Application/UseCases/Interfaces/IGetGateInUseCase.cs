using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces
{
    public interface IGetGateInUseCase
    {
        Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetGateInDto request);
    }
}
