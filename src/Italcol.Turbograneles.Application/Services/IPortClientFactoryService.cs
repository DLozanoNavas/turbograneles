using Italcol.TurboGraneles.Clients;

namespace Italcol.Turbograneles.Application.Services;

public interface IPortClientFactoryService
{
    Task<TurboGranelesClient> CreateClientAsync();
}