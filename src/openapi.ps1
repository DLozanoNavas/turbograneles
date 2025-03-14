
# Set the environment variable to ignore SSL errors
$env:NODE_TLS_REJECT_UNAUTHORIZED = '0'

# Install NSwag CLI
Write-Host "Installing NSwag CLI..."
dotnet tool install -g NSwag.ConsoleCore
dotnet tool install --global Microsoft.OpenApi.Kiota

# Add NSwag to PATH
$env:PATH += ";$env:USERPROFILE\.dotnet\tools"


nswag openapi2csclient /input:openapi.yml /output:Italcol.TurboGraneles.Clients/Clients/Client.cs /namespace:Italcol.TurboGraneles.Clients
kiota generate -l CSharp -d openapi.yml -c TurboGranelesClient -n Italcol.TurboGraneles.Clients -o Italcol.TurboGraneles.Clients/Clients

# Reset the environment variable
$env:NODE_TLS_REJECT_UNAUTHORIZED = '1'