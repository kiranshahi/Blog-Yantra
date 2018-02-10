using System;

namespace Blog_Yantra.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public int status { get; set; }
    }
}