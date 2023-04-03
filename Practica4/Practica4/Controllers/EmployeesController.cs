using Practica4.Entities;
using Practica4.Logic;
using Practica4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Practica4.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        EmployeesLogic logic = new EmployeesLogic();

        // GET api/employees
        [HttpGet]        
        public IHttpActionResult Get()
        {

            try
            {
                List<Employees> empleados = logic.GetAll();
                List<EmployeesViewApi> empleadosViews = empleados.Select(x => new EmployeesViewApi
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();
                return Ok(empleadosViews);

            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // GET api/employees/5
        [HttpGet]        
        public IHttpActionResult Get(int id)
        {
            try
            {
                Employees employees = logic.GetOne(id);
                var result = new EmployeesViewApi
                {
                    EmployeeID = employees.EmployeeID,
                    FirstName = employees.FirstName,
                    LastName = employees.LastName
                };
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST api/employees
        [HttpPost]
        public IHttpActionResult Post([FromBody] EmployeesViewApi employeesView)
        {
            try
            {
                var employeesEntity = new Employees
                {
                    FirstName = employeesView.FirstName,
                    LastName = employeesView.LastName
                };
                logic.Add(employeesEntity);
                return Ok("Creado Exito!");
            }
            catch (Exception)
            {
                return BadRequest("Error al Crear Empleado");
            }
        }

        // PUT api/employees/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] EmployeesViewApi employeesView)
        {
            try
            {
                Employees empleados = logic.GetOne(id);
                if(empleados != null && ModelState.IsValid)
                {
                    Employees employee = new Employees()
                    {          
                        EmployeeID = employeesView.EmployeeID,
                        FirstName = employeesView.FirstName,
                        LastName = employeesView.LastName
                    };
                    logic.Update(employee);
                }
                else
                {
                    return BadRequest("Datos inválidos");
                }
                return Ok("Empleado Actualizado");
            }
            catch 
            {
                return BadRequest("Error, No se Actualizó");
            }
        }

        [HttpDelete]
        // DELETE api/employees/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return Ok("Eliminación Exitosa!");
            }
            catch (Exception)
            {
                return BadRequest("Falló Eliminación");
            }
        }
    }
}
