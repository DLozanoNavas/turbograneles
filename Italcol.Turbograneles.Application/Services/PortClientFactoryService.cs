using Italcol.TurboGraneles.Clients;

namespace Italcol.Turbograneles.Application.Services;

public class PortClientFactoryService (IHttpClientFactory httpClientFactory): IPortClientFactoryService
{
    private const string ClientUrl = "https://middleware-dev-bcdmasc4gjehe3db.westus-01.azurewebsites.net";

    public async Task<Client> CreateClientAsync()
    {
        var client = new Client(ClientUrl, httpClientFactory.CreateClient());

        // TODO: Authenticate client


        var token = await client.AuthAsync(new()
        {
            Email = "user@example.com",
            Password = "password123"
        });


        return client;
    }
}