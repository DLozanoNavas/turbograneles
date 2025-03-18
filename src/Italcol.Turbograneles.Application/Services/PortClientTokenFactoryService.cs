using Newtonsoft.Json;

namespace Italcol.Turbograneles.Application.Services;

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class PortClientTokenFactoryService(HttpClient httpClient)
{
    private string? _token;
    private readonly string _email = "user@example.com";
    private readonly string _password = "password123";
    private const string AuthEndpoint = "https://middleware-dev-bcdmasc4gjehe3db.westus-01.azurewebsites.net/api/v1/auth";

    // TODO: Replace with real credentials or fetch them securely

    public async Task<string> GetAccessTokenAsync()
    {
        if (!string.IsNullOrEmpty(_token))
        {
            return _token; // Return cached token
        }

        var requestBody = new AuthRequest
        {
            Email = _email,
            Password = _password
        };

        var response = await httpClient.PostAsJsonAsync(AuthEndpoint, requestBody);

        if (response.IsSuccessStatusCode)
        {
            var authResult = await response.Content.ReadFromJsonAsync<PortsAuthResponse>();

            if (authResult?.Success == true && authResult.Data?.Count > 0)
            {
                _token = authResult.Data[0].AccessToken;
                return _token ?? throw new Exception("Access token is missing.");
            }
        }

        throw new Exception("Authentication request failed.");
    }
}

// Models for request and response
public class AuthRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class PortsAuthResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<AuthData>? Data { get; set; }
}

public class AuthData
{
    public string Message { get; set; } = string.Empty;
    // this is "access_token"
    [JsonProperty("access_token")]
    [System.Text.Json.Serialization.JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = string.Empty;
    public AuthUser User { get; set; } = new();
}

public class AuthUser
{
    public string Email { get; set; } = string.Empty;
}
