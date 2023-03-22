using Practica4.Logic;
using Practica4.MVC.Models;
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
            List<Entities.Employees> empleados = logic.GetAll();
            List<EmployeesView> empleadosViews = empleados.Select(x => new EmployeesView
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
            return View(empleadosViews);
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