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

            Console.WriteLine("\n");


            // Mostrar la lista de clientes
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customers in customersLogic.GetAll())
            {
                Console.WriteLine($"{customers.ContactName} - {customers.CompanyName}");
            }

            Console.WriteLine("\n");


            //Insertar nuevo empleado

            try
            {
                Console.WriteLine("Ingrese el Nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el Apellido del empleado: ");
                string apellido = Console.ReadLine();                  
              
                employeesLogic.Add(new Employees
                {
                    FirstName = nombre,
                    LastName = apellido
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");
            Console.ReadKey();


        }
    }

}
