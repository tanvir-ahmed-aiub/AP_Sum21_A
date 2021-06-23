using Lecture8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture8.Controllers
{
    public class ProductController : Controller
    {
        PMSEntities context = new PMSEntities();
        // GET: Product
        public ActionResult Index()
        {
            var d = context.Categories.FirstOrDefault(e => e.Id == 3).Products;
            var products = context.Products.ToList();
            return View(products);
        }
        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p) {
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id) {

            var p = context.Products.FirstOrDefault(e => e.Id == Id);
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p) {
            var oldp = context.Products.FirstOrDefault(e => e.Id == p.Id);
            /*oldp.Name = p.Name;
            //manually change
            context.Entry(oldp).State = System.Data.Entity.EntityState.Modified;*/
            context.Entry(oldp).CurrentValues.SetValues(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id) {
            var p = context.Products.FirstOrDefault(e => e.Id == Id);
            return View(p);
        }
        public ActionResult Delete(int Id) {
            var p = context.Products.FirstOrDefault(e => e.Id == Id);
            return View(p);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteP(int Id) {
            var pr = context.Products.FirstOrDefault(e => e.Id == Id);
            context.Products.Remove(pr);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}