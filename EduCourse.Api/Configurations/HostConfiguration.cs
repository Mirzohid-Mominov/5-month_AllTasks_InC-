﻿namespace EduCourse.Api.Configurations
{
    public static partial class HostConfiguration
    {
        public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
        {
            builder
                .AddPersistence()
                .AddIdentityInfrastructure()
                .AddCourseInfrastructure()
                .AddDevTools()
                .AddExposers();

            return new(builder);
        }

        public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
        {
            app
                .UseDevTools()
                .UseExposers();

            return new(app);
        }
    }
}
