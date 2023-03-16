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
                Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} - {employee.LastName}");
            }

            Console.WriteLine("\n");


            // Mostrar la lista de clientes
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customers in customersLogic.GetAll())
            {
                Console.WriteLine($"{customers.CustomerID} - {customers.ContactName} - {customers.CompanyName}");
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
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");

            
            // Eliminar empleado

            try
            {
                Console.WriteLine("Ingrese el ID del Empleado a Eliminar: ");
                
                int id = Int32.Parse(Console.ReadLine());

                employeesLogic.Delete(id);

                Console.WriteLine("Empleado eliminado con exito!");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }       
          

            //Actualizando el nombre  y apellido de un empleado

            try
            {
                Console.WriteLine("Ingrese el ID  del Empleado a Modificar: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el Apellido del empleado: ");
                string apellido = Console.ReadLine();

                employeesLogic.Update(new Employees
                {
                    FirstName = nombre,
                    LastName = apellido,
                    EmployeeID = id
                });

                Console.WriteLine("Empleado Actualizado con Exito!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }

}
