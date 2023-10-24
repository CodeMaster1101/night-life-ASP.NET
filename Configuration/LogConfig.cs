using NLog.Extensions.Logging;

namespace night_life_sk.Configuration
{
    internal static class LogConfig
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging(builder =>
            {
                builder.AddNLog(configuration.GetSection("Logging:NLog"));
            });
        }
    }
}
