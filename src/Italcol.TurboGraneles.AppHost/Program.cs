var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("messaging");

builder.AddProject<Projects.Italcol_Turbograneles_Adapters>("WebApi")
    .WithReference(rabbitmq);

builder.Build().Run();
