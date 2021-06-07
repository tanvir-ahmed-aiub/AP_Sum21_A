using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture2.Models;

namespace Lecture2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Name = "Sabbir";
            ViewBag.Id = "1548";
            ViewBag.Fname = "Father";
            ViewBag.Mname = "Mother";
            ViewBag.Age = 12;

            //passing from 1 action to another action
            TempData["University"] = "AIUB";
            //return View();
            return RedirectToAction("Details");

        }
        /*public ActionResult Details() {
            ViewData["Name"] = "Tanvir";
            ViewData["Temp"] = "Temp data";
            //return View();
            return RedirectToAction("Create");
        }*/
        public ActionResult Details() {
            Person p = new Person();
            p.Name = "Tanvir Ahmed";
            p.Password = "12345";
            p.Username = "taanvir";

            return View(p);

        }
        public ActionResult Create() {
            return View();
        }

    }
}