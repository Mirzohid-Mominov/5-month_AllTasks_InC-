using EduCourse.Application.Common.Courses.Services;
using EduCourse.Application.Common.Identity.Services;
using EduCourse.Infrastructure.Common.Courses.Services;
using EduCourse.Infrastructure.Common.Identity.Services;
using EduCourse.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EduCourse.Api.Configurations
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
        builder.Services.AddScoped<IUserservice, UserService>();

        return builder;
    }
    
    private static WebApplicationBuilder AddCourseInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICourseService, CourseService>();
        builder.Services.AddScoped<ICourseProcessingService, CourseProcessingService>();

        return builder;
    }

    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();

        return builder;
    }

    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers()
            .AddNewtonsoftJson(options => options.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects);

        return builder;
    }

    private static WebApplication UseDevTools(this WebApplication app)
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
