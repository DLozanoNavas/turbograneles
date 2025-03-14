using Italcol.TurboGraneles.Clients;

namespace Italcol.Turbograneles.Application.UseCases.Interfaces;

public interface IGetVoyageAndVesselUseCase
{
    Task<object> ExecuteAsync(GetVoyageandVesselDto request);
}