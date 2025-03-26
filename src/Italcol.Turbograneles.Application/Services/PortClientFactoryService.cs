using Italcol.TurboGraneles.Clients;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Abstractions.Authentication;


namespace Italcol.Turbograneles.Application.Services;

public class PortClientFactoryService(IAuthenticationProvider authProvider) : IPortClientFactoryService
{
    private const string ClientUrl = "https://middleware-dev-bcdmasc4gjehe3db.westus-01.azurewebsites.net";

    public Task<TurboGranelesClient> CreateClientAsync()
    {
        // Create Kiota HTTP request adapter with authentication provider
        var adapter = new HttpClientRequestAdapter(authProvider)
        {
            BaseUrl = ClientUrl
        };

        // Return the authenticated TurboGranelesClient
        return Task.FromResult(new TurboGranelesClient(adapter));
    }


}

public class AuthResponse
{
    public string AccessToken { get; set; } = string.Empty;
}