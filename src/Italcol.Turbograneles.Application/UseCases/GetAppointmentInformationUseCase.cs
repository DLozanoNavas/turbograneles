using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetAppointmentInformationUseCase : IGetAppointmentInformationUseCase
    {
        public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetAppointmentInformationDto request)
        {
            throw new NotImplementedException();
        }
    }
}
