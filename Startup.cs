using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blog_Yantra.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Blog_Yantra
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<BlogContext>(opt => opt.UseInMemoryDatabase("Blog"));
      services.AddMvc();

      // Register the Swagger generator, defining one or more Swagger or more Swagger documents
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info 
        { 
          Version = "v1",
          Title = "My Blog API",
          Description ="A simple blog developed using ASP.NET Core Web API and Angular",
          TermsOfService = "None",
          Contact = new Contact { Name = "kiran Shahi", Email = "contact@example.com", Url = "http://kirans.com.np" },
          License = new License { Name = "GNU Lesser General Public License v3.0", Url = "https://www.gnu.org/licenses/lgpl-3.0.en.html" }
        });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {

      // Enale middleware to serve generated Swagger as a JSON endpoint.
      app.UseSwagger();

      // Enable middleware to server swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
      app.UseSwaggerUI(c => 
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Blog API V1");
      });

      app.UseDefaultFiles();
      app.UseStaticFiles();
      app.UseMvc();
    }
  }
}