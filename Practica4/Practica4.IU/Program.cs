using Practica4.Entities;
using Practica4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.IU
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar la lista de empleados
            EmployeesLogic employeesLogic = new EmployeesLogic();

            foreach (Employees employee in employeesLogic.GetAll())
            {
                Console.WriteLine($"{employee.FirstName} - {employee.LastName}");
            }

            Console.ReadKey();


            // Mostrar la lista de clientes
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customers in customersLogic.GetAll())
            {
                Console.WriteLine($"{customers.ContactName} - {customers.CompanyName}");
            }

            Console.ReadKey();
        }
    }

}
