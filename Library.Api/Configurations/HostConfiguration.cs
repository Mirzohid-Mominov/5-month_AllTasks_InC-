namespace Library.Api.Configurations
{
    public static partial class HostConfiguration
    {
        public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
        {
            builder
                .AddPersistence()
                .AddIdentityInfrastructure()
                .addDevTools()
                .addExposers();

            return new(builder);
        }

        public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
        {
            app
                .UseDevtools()
                .UseExposers();

                return new(app);
        }
    }
}
