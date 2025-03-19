using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetLoadByEachVesselUseCase(IPortClientFactoryService portClientFactoryService) : IGetLoadByEachVesselUseCase
    {
        public async Task<UntypedNode?> ExecuteAsync(GetLoadByEachVesselDto request)
        {
            var client = await portClientFactoryService.CreateClientAsync();
            return await client.Api.V1.Miit.GetLoadByEachVessel.PostAsync(request);
        }
    }
}
