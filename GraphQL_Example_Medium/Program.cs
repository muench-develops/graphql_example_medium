using GraphQL.AspNet.Configuration.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddGraphQL();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseGraphQL();

app.Run();