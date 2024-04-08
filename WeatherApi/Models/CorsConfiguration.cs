namespace WeatherApi.Models
{
    public class CorsConfiguration
    {
        public static void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowVueFrontend",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:8080") // Update with your Vue.js frontend URL
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
        }

    }
}
