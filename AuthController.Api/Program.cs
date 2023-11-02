using AuthController.Api.Models;
using AuthController.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Emit;

namespace AuthController.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<TokenGeneratorService>();

        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapControllers();
        app.UseAuthentication();

        app.Run();
    }
}