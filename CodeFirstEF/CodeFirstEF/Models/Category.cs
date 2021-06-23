using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Category
    {
        public Category() {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation property
        public virtual ICollection<Product> Products { get; set; }
    }
}