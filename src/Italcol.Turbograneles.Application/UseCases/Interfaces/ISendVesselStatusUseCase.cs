using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces;
public interface ISendVesselStatusUseCase
{
    public Task<UntypedNode?> ExecuteAsync(SendVesselStatusDto request);
}
