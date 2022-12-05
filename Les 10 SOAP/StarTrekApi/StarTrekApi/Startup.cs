namespace StarTrekApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddScoped<SeriesPortType>(x =>
        {
            return new SeriesPortTypeClient(SeriesPortTypeClient.EndpointConfiguration.SeriesPortType);
        });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id}");
        });
    }
}
