using Microsoft.AspNetCore.Mvc;

namespace Blog_Yantra.Controllers
{
  [Route("api/[Controller]")]
  public class TestController: Controller
  {
    [HttpGet]
    public IActionResult Greetings()
    {
      return Ok("Hello from ASP.NET Core Web API.");
    }
  }
}
