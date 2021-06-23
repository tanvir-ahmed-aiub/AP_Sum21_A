using Lecture7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lecture7.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User u,string returnUrl) {
            if (u.Uname.Equals("tanvir") && u.Pass.Equals("1234"))
            {
                FormsAuthentication.SetAuthCookie("tanvir", false);

                return Redirect(returnUrl);
            }
            return View();

        }
        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            return Redirect("/Home");
        }
    }
}