using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class OrderController : Controller
    {
        PMSEntities context = new PMSEntities();
        // GET: Order
        public ActionResult Index()
        {

            return View(context.Orders.ToList());
        }
        public ActionResult Details(int Id) {
            var order = context.Orders.FirstOrDefault(e => e.Id == Id);
            var orderDetails = order.OrderDetails;
            return View(orderDetails);
        }
    }
}