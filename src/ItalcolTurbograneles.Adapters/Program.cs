using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases;
using Italcol.Turbograneles.Application.UseCases.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IPortClientFactoryService, PortClientFactoryService>();
builder.Services.AddScoped<IGetVoyageAndVesselUseCase, GetVoyageAndVesselUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.Run();
