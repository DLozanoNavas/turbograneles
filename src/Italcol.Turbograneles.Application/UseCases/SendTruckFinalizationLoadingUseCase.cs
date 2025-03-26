using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class SendTruckFinalizationLoadingUseCase(IPortClientFactoryService portClientFactoryService) : ISendTruckFinalizationLoadingUseCase
    {
        public async Task<UntypedNode?> ExecuteAsync(SendTruckFinalizationLoadingDto request)
        {
            var client = await portClientFactoryService.CreateClientAsync();
            return await client.Api.V1.Miit.SendTruckFinalizationLoading.PostAsync(request);
        }
    }
}
