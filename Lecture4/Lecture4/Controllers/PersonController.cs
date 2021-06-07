using Lecture4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture4.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            Person p = new Person();
            return View(p);
        }

        public ActionResult CreatePerson(string Name, string Address, string Dob) {
            //traditional approach ; no parameter in ActionMethod
            /*ViewData["Name"] = Request["Name"].ToString();
            ViewData["Dob"] = Request["Dob"].ToString();
            ViewData["Address"] = Request["Address"].ToString();*/

            //formcollection ; parameter in action method FormCollection form
            /*ViewData["Name"] = form["Name"].ToString();
            ViewData["Dob"] = form["Dob"].ToString();
            ViewData["Address"] = form["Address"].ToString();*/

            //Paarameters ; 
            ViewData["Name"] = Name;
            ViewData["Dob"] = Dob;
            ViewData["Address"] = Address;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person p) {
            
            return View(p);
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
    }
}