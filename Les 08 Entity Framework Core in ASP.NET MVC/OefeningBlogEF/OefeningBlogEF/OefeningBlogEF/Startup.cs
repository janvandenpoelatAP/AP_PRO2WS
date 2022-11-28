using Microsoft.EntityFrameworkCore;
using OefeningBlogEF.Entities;
using OefeningBlogEF.Services;

namespace OefeningBlogEF;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<PostRepository, PostRepository>();
        services.AddControllers();
        services.AddSwaggerGen();
        var connection = "server = localhost; database = blog-db; user=root; password = abc123";
        services.AddDbContext<BlogContext>(x => x.UseMySql(connection, ServerVersion.AutoDetect(connection)));
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
