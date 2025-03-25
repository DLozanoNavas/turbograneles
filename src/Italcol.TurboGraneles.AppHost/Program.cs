var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("messaging");

builder.AddProject<Projects.Italcol.Turbograneles_Adapters>("Italcol.Turbograneles-adapters")
    .WithReference(rabbitmq);

builder.Build().Run();
