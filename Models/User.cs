using System;

namespace Blog_Yantra.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime RegisteredOn { get; set; }
        public int Status { get; set; }
        public string DisplayName { get; set; }
    }
}