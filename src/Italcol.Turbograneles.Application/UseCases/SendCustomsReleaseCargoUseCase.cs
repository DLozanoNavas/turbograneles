using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class SendCustomsReleaseCargoUseCase (IPortClientFactoryService portClientFactoryService) : ISendCustomsReleaseCargoUseCase
    {
        public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(SendCustomsReleasedCargoDto request)
        {
            var client = await portClientFactoryService.CreateClientAsync();
            return await client.Api.V1.Miit.SendCustomsReleasedCargo.PostAsync(request);
        }
    }
}
