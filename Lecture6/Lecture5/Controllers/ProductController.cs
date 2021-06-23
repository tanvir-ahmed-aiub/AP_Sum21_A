using Lecture5.Models;
using Lecture5.Models.Database;
using Lecture5.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lecture5.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.GetAll();
            return View(products);
        }

        public ActionResult Create() 
        {
            
            Product p = new Product();
            Database db = new Database();
            ProductCategory combodata = new ProductCategory();
            combodata.Product = p;
            combodata.Categories = db.Categories.GetAll();
            //dynamic combodata = new ExpandoObject();
            //combodata.Product = p;

            //combodata.Categories = db.Categories.GetAll();
            return View(combodata);
        }
        [HttpPost]
        public ActionResult Create(Product p) {
            //insert to db
            if (ModelState.IsValid) {
                Database db = new Database();
                db.Products.Insert(p);
                return RedirectToAction("Index");
            }
           
            Database database = new Database();
            ProductCategory combodata = new ProductCategory();
            combodata.Product = p;
            combodata.Categories = database.Categories.GetAll();
            return View(combodata);
           
        }
        public ActionResult Edit(int id) {

            Database db = new Database();
            var p = db.Products.Get(id);

            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            //update to db
            Database db = new Database();
            db.Products.Update(p);
            return RedirectToAction("Index");
            
        }
    }
}