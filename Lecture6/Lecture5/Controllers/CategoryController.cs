using Lecture5.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture5.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            Database db = new Database();
            var data = db.Categories.GetAll();
            return View(data);
        }
        
    }
}