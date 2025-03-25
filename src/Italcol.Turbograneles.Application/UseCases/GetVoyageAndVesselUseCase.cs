using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases;

public class GetVoyageAndVesselUseCase(IPortClientFactoryService portClientFactoryService) : IGetVoyageAndVesselUseCase
{
    public async Task<UntypedNode?> ExecuteAsync(GetVoyageandVesselDto request)
    {
        var client = await portClientFactoryService.CreateClientAsync();
        return await client.Api.V1.Miit.GetVoyageandVessel.PostAsync(request);
    }
}