using System.Collections.Generic;
using System.Linq;
using Blog_Yantra.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Yantra.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly BlogContext _context;
        public PostController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Post> GetAll() 
        { 
            return _context.Posts.ToList();
        }

        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetById(long id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return new ObjectResult(post);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Post post)
        {
            if (post == null)
            {
                return BadRequest();
            }

            _context.Posts.Add(post);
            _context.SaveChanges();
            return CreatedAtRoute("GetById", new {id = post.Id}, post);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Post post)
        {
            if (post == null || post.Id != id)
            {
                return BadRequest();
            }

            var oldPost = _context.Posts.FirstOrDefault(t => t.Id == id);
            if (oldPost == null)
            {
                return NotFound();
            }

            oldPost.Title = post.Title;
            oldPost.Content = post.Content;
            oldPost.Summary = post.Summary;
            oldPost.Date = post.Date;
            oldPost.status = post.status;

            _context.Posts.Update(oldPost);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (long id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}