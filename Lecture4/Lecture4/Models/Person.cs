using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture4.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Please provide name")]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
        public string Address { get; set; }
    }
}