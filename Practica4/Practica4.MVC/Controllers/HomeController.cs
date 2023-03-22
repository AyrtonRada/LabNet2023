using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica4.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var logic = new EmployeesLogic();
            List<Practica4.Entities.Employees> empleados = logic.GetAll();
            return View(empleados);
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