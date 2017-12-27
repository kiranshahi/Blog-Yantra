using Blog_Yantra.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Yantra.Controllers
{
  [Route("api/[controller]")]
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

    [HttpGet]
    public IEnumerable<TodoItem> GetAll()
    {
      return _context.TodoItems.ToList();
    }

    [HttpGet("{id}", Name = "GetTodo")]
    public IActionResult GetById(long id)
    {
      var item = _context.TodoItems.FirstOrDefault(t => t.Id == id);
      if (item == null)
      {
        return NotFound();
      }
      return new ObjectResult(item);
    }

    // CREATE
    [HttpPost]
    public IActionResult Create([FromBody] TodoItem item)
    {
      if (item == null)
      {
        return BadRequest();
      }
      _context.TodoItems.Add(item);
      _context.SaveChanges();
      return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
    }

    // Update
    [HttpPut("{id}")]
    public IActionResult Update(long id, [FromBody] TodoItem item)
    {
      if (item == null || item.Id != id)
      {
        return BadRequest();
      }
      var todo = _context.TodoItems.FirstOrDefault(t => t.Id == id);
      if (todo == null)
      {
        return NotFound();
      }
      todo.IsComplete = item.IsComplete;
      todo.Name = item.Name;

      _context.TodoItems.Update(todo);
      _context.SaveChanges();
      return new NoContentResult();
    }
  }
}
