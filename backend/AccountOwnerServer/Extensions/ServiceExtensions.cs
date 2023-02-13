using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => 
            {
                options.AddPolicy("CorsPolicy", 
                    builder => builder
                    .AllowAnyOrigin()    // WithOrigins("dominio")
                    .AllowAnyMethod()    // WithMethods("POST", "GET")
                    .AllowAnyHeader());  // WithHeaders("accept", "content-type")
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
            });
        }
    }
}