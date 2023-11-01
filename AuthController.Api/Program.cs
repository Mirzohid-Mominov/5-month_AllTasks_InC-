using AuthController.Api.Models;
using AuthController.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Emit;

namespace AuthController.Api
{
// - emtpy web api project yarating
//- unga AuthController controllerini yarating va unga Login methodiini qo'shing
//- access token generate qilish uchun TokenGeneratorService yarating
//- Login methodida User modeli qabul qilib, TokenGeneratorService orqali token yaratib, yaratilgan tokenni Ok rezultati bilan qaytaring
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
}