using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetAppointmentInformationUseCase(IPortClientFactoryService portClientFactoryService) : IGetAppointmentInformationUseCase
    {
        public async Task<UntypedNode?> ExecuteAsync(GetAppointmentInformationDto request)
        {
            var client = await portClientFactoryService.CreateClientAsync();
            return await client.Api.V1.Miit.GetAppointmentInformation.PostAsync(request);
        }
    }
}
