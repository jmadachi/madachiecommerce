using madachiecommerce.InterfaceAdapters.InversionOfControls;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddAppServices(builder.Configuration, "madachiecommerce");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapControllers();

app.Run();
