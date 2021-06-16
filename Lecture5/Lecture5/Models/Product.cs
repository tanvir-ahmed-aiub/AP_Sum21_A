using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture5.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please put name")]
        [MaxLength(5,ErrorMessage ="Max Length 5")]
        public string Name { get; set; }
        [Required]
        [Range(100,200)]
        public int Price { get; set; }
        [Range(5,10)]
        public int Qty { get; set; }
        [Required]
        public string Description { get; set; }
    }
}