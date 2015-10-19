using System;
using System.Collections.Generic;

namespace Store.Common
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredDate { get; set; }
        public bool IsAdmin { get; set; }
        public IList<Order> Orders { get; set; } 
    }
}
