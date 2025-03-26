using Italcol.Turbograneles.Adapters.Data;
using Italcol.Turbograneles.Application.Services;
using Italcol.Turbograneles.Application.UseCases;
using Italcol.Turbograneles.Application.UseCases.Interfaces;
using Italcol.Turbograneles.Domain;
using Microsoft.Kiota.Abstractions.Authentication;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("postgresdb") ?? throw new InvalidOperationException("Connection string 'postgresdb' not found.");;
//builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));
builder.AddNpgsqlDbContext<DataContext>(connectionName: "turbograneles");

builder.Services
    .AddIdentityApiEndpoints<ApplicationUser>()
    .AddEntityFrameworkStores<DataContext>();


builder.AddServiceDefaults();

builder.Services.AddAuthorization();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddHttpClient<PortClientTokenFactoryService>();
builder.Services.AddScoped<IAuthenticationProvider, BearerTokenAuthProvider>();
builder.Services.AddScoped<IPortClientFactoryService, PortClientFactoryService>();

//Register use cases
builder.Services.AddScoped<IGetGateInUseCase, GetGateInUseCase>();
builder.Services.AddScoped<IGetGateOutUseCase, GetGateOutUseCase>();
builder.Services.AddScoped<ISendVesselStatusUseCase, SendVesselStatusUseCase>();
builder.Services.AddScoped<IGetVoyageAndVesselUseCase, GetVoyageAndVesselUseCase>();
builder.Services.AddScoped<IGetLoadByEachVesselUseCase, GetLoadByEachVesselUseCase>();
builder.Services.AddScoped<ISendCustomsReleaseCargoUseCase, SendCustomsReleaseCargoUseCase>();
builder.Services.AddScoped<IGetAppointmentInformationUseCase, GetAppointmentInformationUseCase>();
builder.Services.AddScoped<ISendTruckFinalizationLoadingUseCase, SendTruckFinalizationLoadingUseCase>();

builder.Services.AddScoped<IPortClientFactoryService, PortClientFactoryService>();


var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseAuthentication();
app.UseAuthorization();

app.MapOpenApi();
app.UseSwaggerUI(static options =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "Turbograneles API V1");
});

app.MapGroup("/account").MapIdentityApi<ApplicationUser>();

app.MapControllers();
app.UseHttpsRedirection();
app.Run();
