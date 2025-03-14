using Italcol.Turbograneles.Application.Services;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

public class BearerTokenAuthProvider(PortClientTokenFactoryService portClientTokenFactory) : IAuthenticationProvider
{
    public async Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = new())
    {
        var token = await portClientTokenFactory.GetAccessTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers["Authorization"] = new List<string> { $"Bearer {token}" };
        }
    }
}