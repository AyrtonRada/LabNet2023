using Practica4.Data;
using Practica4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.Logic
{
    public class EmployeesLogic : BaseLogic
    {        
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(Employees newEmployees)
        {
            context.Employees.Add(newEmployees);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var empleadoAEliminar = context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            context.Employees.Remove(empleadoAEliminar);
            context.SaveChanges();
                
        }

        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);
            employeeUpdate.FirstName = employee.FirstName;
            employeeUpdate.LastName = employee.LastName;
            context.SaveChanges();
        }

        public Employees GetOne(int id)
        {
            return context.Employees.First(x => x.EmployeeID.Equals(id));
        }
    }
}
