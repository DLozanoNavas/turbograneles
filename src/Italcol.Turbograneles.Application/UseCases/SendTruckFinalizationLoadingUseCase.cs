using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class SendTruckFinalizationLoadingUseCase(IPortClientFactoryService portClientFactoryService) : ISendTruckFinalizationLoadingUseCase
    {
        public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(SendTruckFinalizationLoadingDto request)
        {
            throw new NotImplementedException();
        }
    }
}
