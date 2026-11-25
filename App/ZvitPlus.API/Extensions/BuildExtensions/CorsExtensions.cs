namespace ZvitPlus.API.Extensions.BuildExtensions
{
    public static class CorsExtensions
    {
        public static IServiceCollection AddCorsPolicy(
            this IServiceCollection services)
        {
            services.AddCors(options =>
                {
                    options.AddDefaultPolicy(policy =>
                        policy.WithOrigins(
                            "http://localhost:5173",
                            "http://localhost:80",
                            "http://localhost:8080"
                        )
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
                });

                return services;
        }
    }
}
