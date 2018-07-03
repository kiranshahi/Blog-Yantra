using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        public string UserNiceName { get; set; }
        public string UserEmail { get; set; }
        public string UserUrl { get; set; }
        public DateTime UserRegistered { get; set; }
        public string UserActivationKey { get; set; }
        public int status { get; set; }
        public string DisplayName { get; set; }
    }
}
