using Blog_Yantra.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Yantra.Controllers
{
    public class CommentController : Controller
    {
        private readonly BlogContext _context;
        public CommentController(BlogContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public IEnumerable<Comment> GetAll()
        // {

        // }
    }
}