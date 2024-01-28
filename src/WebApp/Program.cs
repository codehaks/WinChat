using WebApp.Hubs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapHub<ChatHub>("chathub");

app.Run();
