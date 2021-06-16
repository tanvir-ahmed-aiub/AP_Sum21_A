using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture5.Models.ViewModel
{
    public class ProductCategory
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public ProductCategory() {
            Categories = new List<Category>();
        }
    }
}