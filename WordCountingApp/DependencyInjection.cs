using Microsoft.Extensions.DependencyInjection;
using WordCountingApp.Services;

namespace WordCountingApp
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<CountingService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<MathService>();
        }

    }
}
