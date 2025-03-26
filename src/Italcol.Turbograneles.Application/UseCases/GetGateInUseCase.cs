using Italcol.Turbograneles.Application.Dtos.Port;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.TurboGraneles.Clients.Models;

namespace Italcol.Turbograneles.Application.UseCases
{
    public class GetGateInUseCase : IGetGateInUseCase
    {
        public async Task<PortResponseEnvelope<List<PortResponseResult>>> ExecuteAsync(GetGateInDto request)
        {
            throw new NotImplementedException();
        }
    }
}
