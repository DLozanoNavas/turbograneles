var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ItalcolTurbograneles_Adapters>("italcolturbograneles-adapters");

builder.Build().Run();
