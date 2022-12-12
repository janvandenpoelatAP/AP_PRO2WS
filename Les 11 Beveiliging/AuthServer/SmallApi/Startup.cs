using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace SmallApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => 
            {
                options.Authority = "https://localhost:7060";
                options.TokenValidationParameters.ValidateAudience = false;
                options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };

            });
        services.AddAuthorization(options =>
        {
            options.AddPolicy("read",
                policy => policy.RequireClaim("scope", new string[] { "smallApî.read", "smallApi.write" }));
            options.AddPolicy("write",
                policy => policy.RequireClaim("scope", "smallApi.write" ));
        });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}