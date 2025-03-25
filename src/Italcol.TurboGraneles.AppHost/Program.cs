var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("messaging");
var postgres = builder.AddPostgres("data").WithPgAdmin();
var postgresdb = postgres.AddDatabase("postgresdb");

builder.AddProject<Projects.Italcol_Turbograneles_Adapters>("WebApi")
    .WithReference(postgresdb)
    .WithReference(rabbitmq);

builder.Build().Run();
