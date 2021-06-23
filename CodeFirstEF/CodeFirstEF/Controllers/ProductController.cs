using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class ProductController : Controller
    {
        PMSEntities context = new PMSEntities();
        // GET: Product
        public ActionResult Index()
        {
            var p = context.Products.ToList();
            return View(p);
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p) {
            p.CategoryId = 1;
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}