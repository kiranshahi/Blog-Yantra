using System.Collections.Generic;
using System.Linq;
using Blog_Yantra.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Yantra.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly BlogContext _context;
        public UserController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }
        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(long id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return new ObjectResult(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtRoute("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] User user)
        {
            if (user == null || user.Id != id)
            {
                return BadRequest();
            }

            var oldUser = _context.Users.FirstOrDefault(t => t.Id == id);
            if (oldUser == null)
            {
                return NotFound();
            }

            oldUser.Id = user.Id;
            oldUser.Username = user.Username;
            oldUser.Password = user.Password;
            oldUser.Email = user.Email;
            oldUser.Url = user.Url;
            oldUser.DisplayName = user.DisplayName;

            _context.Users.Update(oldUser);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}