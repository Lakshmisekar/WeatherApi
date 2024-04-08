using Microsoft.AspNetCore.Builder;

namespace WeatherApi.Models
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            CorsConfiguration.ConfigureCors(services);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCors("AllowVueFrontend");
        }
    }
}
