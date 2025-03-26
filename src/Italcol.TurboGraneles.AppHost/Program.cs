var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("messaging");
var postgres = builder.AddPostgres("postgres").WithPgAdmin();
var db = postgres.AddDatabase("turbograneles");

builder.AddProject<Projects.Italcol_Turbograneles_Adapters>("WebApi")
    .WithReference(rabbitmq)
    .WithReference(db);

builder.Build().Run();
