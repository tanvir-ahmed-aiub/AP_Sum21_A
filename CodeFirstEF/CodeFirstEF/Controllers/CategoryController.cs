using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class CategoryController : Controller
    {
        
        // GET: Category
        public ActionResult Index()
        {
            PMSEntities context = new PMSEntities();
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public ActionResult Details(int Id) {
            PMSEntities context = new PMSEntities();
            var c = context.Categories.FirstOrDefault(e=>e.Id == Id);
            return View(c);
        }
    }
}