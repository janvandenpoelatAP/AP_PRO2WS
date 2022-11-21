using HelloCore.Entities;
using HelloCore.Services;
using Microsoft.EntityFrameworkCore;

namespace HelloCore;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IGreeter, Greeter>();
        services.AddScoped<IRestaurantData, RestaurantDataInMemory>();
        services.AddControllers();
        services.AddSwaggerGen();
        var connection = "server = localhost; database = restaurant-db; user=root; password = abc123";
        services.AddDbContext<HelloCoreDbContext>(x => x.UseMySql(connection, ServerVersion.AutoDetect(connection)));
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IGreeter greeter)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = String.Empty;
            });
        }
        else
        {
            app.UseExceptionHandler(new ExceptionHandlerOptions
            {
                ExceptionHandler = context => context.Response.WriteAsync("OOPS")
            }); 
        }

        // app.UseWelcomePage();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            // endpoints.MapGet("/", async context =>
            //{
            // await context.Response.WriteAsync(greeter.GetGreeting());
            //});
            // throw new Exception();
            // endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllers();
        });
    }
}
