var builder = DistributedApplication.CreateBuilder(args);

var dbServer = builder.AddPostgres("dbPostgres").WithLifetime(ContainerLifetime.Persistent);
dbServer.WithPgAdmin(options -> options.withHostPort(5555).WithLifetime(ContainerLifetime.Persistent));
var db = dbServer.AddDatabase("abnbdb");
builder.AddProject<Projects.Api>("Api").WithExternalHttpEndpoints().WithReference(db).WaitFor(db);

builder.Build().Run();
