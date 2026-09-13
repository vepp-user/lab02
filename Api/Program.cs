var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => builder.Configuration["MESSAGE"]);

app.Run();
