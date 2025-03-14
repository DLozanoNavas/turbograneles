using Italcol.TurboGraneles.Clients.Models;

using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces;

public interface IGetVoyageAndVesselUseCase
{
    Task<UntypedNode?> ExecuteAsync(GetVoyageandVesselDto request);
}