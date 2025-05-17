var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WPFToBlazor_WebApi>("wpftoblazor-webapi");

builder.AddProject<Projects.WPFToBlazor>("wpftoblazor");

builder.Build().Run();
