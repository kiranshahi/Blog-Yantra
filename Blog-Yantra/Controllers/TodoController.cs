using Blog_Yantra.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Yantra.Controllers
{
  [Route("api/[controlller]")]
  public class TodoController : Controller
  {
    private readonly TodoContext _context;
    public TodoController(TodoContext context)
    {
      _context = context;
      if (_context.TodoItems.Count() == 0)
      {
        _context.TodoItems.Add(new TodoItem { Name = "Item1" });
        _context.SaveChanges();
      }
    }
  }
}
