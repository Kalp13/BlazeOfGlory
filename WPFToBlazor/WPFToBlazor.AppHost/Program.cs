var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WPFToBlazor>("wpftoblazor");

builder.AddProject<Projects.WPFToBlazor_Api>("wpftoblazor-api");

builder.Build().Run();
