using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetGateInUseCase(IPortClientFactoryService portClientFactoryService) : IGetGateInUseCase
    {
        public async Task<UntypedNode?> ExecuteAsync(GetGateInDto request)
        {
            var client = await portClientFactoryService.CreateClientAsync();
            return await client.Api.V1.Miit.GetGateIn.PostAsync(request);
        }
    }
}
