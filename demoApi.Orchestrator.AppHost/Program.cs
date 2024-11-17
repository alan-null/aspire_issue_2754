var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.demoApi>("demoapi");

builder.Build().Run();
