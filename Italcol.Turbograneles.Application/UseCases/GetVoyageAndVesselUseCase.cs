using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients;

namespace Italcol.Turbograneles.Application.UseCases;

public class GetVoyageAndVesselUseCase(IPortClientFactoryService portClientFactoryService) : IGetVoyageAndVesselUseCase
{
    public async Task<object> ExecuteAsync(GetVoyageandVesselDto request)
    {
        var client = await portClientFactoryService.CreateClientAsync();


        return await client.GetVoyageandVesselAsync(request);
    }
}