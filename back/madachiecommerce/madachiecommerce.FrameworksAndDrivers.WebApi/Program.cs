using madachiecommerce.InterfaceAdapters.InversionOfControls;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddAppServices(builder.Configuration, "madachiecommerce");


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(config =>
    {
        config.AllowAnyOrigin();
        config.AllowAnyMethod();
        config.AllowAnyHeader();
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opciones => opciones.TokenValidationParameters =
        new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ClockSkew = TimeSpan.Zero
        }); 

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseCors();

app.MapControllers();


app.Run();
