using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class User
    {
        public User() {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}