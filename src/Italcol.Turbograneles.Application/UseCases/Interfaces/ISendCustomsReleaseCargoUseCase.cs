using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces
{
    public interface ISendCustomsReleaseCargoUseCase
    {
        Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(SendCustomsReleasedCargoDto request);
    }
}
