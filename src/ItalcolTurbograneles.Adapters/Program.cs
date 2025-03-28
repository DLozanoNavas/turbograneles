using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases;
using Italcol.Turbograneles.Application.UseCases.Interfaces;

using Microsoft.Kiota.Abstractions.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient<PortClientTokenFactoryService>();
builder.Services.AddScoped<IAuthenticationProvider, BearerTokenAuthProvider>();
builder.Services.AddScoped<IPortClientFactoryService, PortClientFactoryService>();
builder.Services.AddScoped<IGetVoyageAndVesselUseCase, GetVoyageAndVesselUseCase>();


builder.Services.AddScoped<IPortClientFactoryService, PortClientFactoryService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.MapOpenApi();
app.UseSwaggerUI(static options =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "My API V1");
});


app.MapControllers();
app.UseHttpsRedirection();
app.Run();
