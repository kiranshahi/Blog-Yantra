using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Blog_Yantra.Models;
using Microsoft.Extensions.Configuration;

namespace Blog_Yantra
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<BlogContext>(opt => opt.UseInMemoryDatabase("Blog"));
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc();
    }
  }
}
