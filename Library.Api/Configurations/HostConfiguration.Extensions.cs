using Library.Aplication.Common.Identity.Services;
using Library.Infrastructure.Common.Identity.Services;
using Library.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Configurations
{
    public static partial class HostConfiguration
    {
        private static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            return builder;
        }

        private static WebApplicationBuilder AddIdentityInfrastructure(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IAuthorService, AuthorService>();

            return builder;
        }

        private static WebApplicationBuilder addDevTools(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.AddEndpointsApiExplorer();

            return builder;
        }

        private static WebApplicationBuilder addExposers(this WebApplicationBuilder builder)
        {
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();

            return builder;
        }

        private static WebApplication UseDevtools(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            return app;
        }

        private static WebApplication UseExposers(this WebApplication app)
        {
            app.MapControllers();

            return app;
        }
    }
}
