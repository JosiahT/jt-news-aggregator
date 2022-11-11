using NewsAggregator.Web.infrastructure.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSwagger(builder.Configuration);
var app = builder.Build();

app.RunSwagger();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();
