using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces
{
    public interface IGetGateOutUseCase
    {
        Task<UntypedNode?> ExecuteAsync(GetGateOutDto request);
    }
}
