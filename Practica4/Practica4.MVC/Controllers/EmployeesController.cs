using Practica4.Entities;
using Practica4.Logic;
using Practica4.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica4.MVC.Controllers
{
    public class EmployeesController : Controller
    {
            EmployeesLogic logic = new EmployeesLogic();
        public ActionResult Index()
        {

            List<Employees> empleados = logic.GetAll();
            List<EmployeesView> empleadosViews = empleados.Select(x => new EmployeesView
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
            return View(empleadosViews);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeesView employeesView)
        {
            try
            {
                var employeesEntity = new Employees
                {
                    FirstName = employeesView.FirstName,
                    LastName = employeesView.LastName
                };
                logic.Add(employeesEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(EmployeesView employeesView)
        {           
            try
            {
                var empleadosUpdate = new Employees()
                {
                    EmployeeID = employeesView.EmployeeID,
                    FirstName = employeesView.FirstName,
                    LastName = employeesView.LastName
                };
                logic.Update(empleadosUpdate);
                return RedirectToAction("Index");                 
            }
            catch (Exception)
            {
                return RedirectToAction("index", "Error");
            }
        }             
    }
}