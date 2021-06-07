using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Demo()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult References()
        {
            return View();
        }
        public ActionResult Test() {
            Models.Person person = new Models.Person();
            person.Name = "Tanvir";
            person.Id = "4678";

            return View(person);
        }
        public ActionResult Create() {
            return View();
        }

    }
}