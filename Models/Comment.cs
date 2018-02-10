using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Yantra.Models 
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int ParentId { get; set; }
        public bool IsApproved { get; set; }
        [Column("PostId")]
        public Post Post { get; set; }
    }
}