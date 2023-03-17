using System;
using Practica5.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5.Logic
{
    public class LinqLogic : BaseLogic
    {
        // EJERCICIO 1

        public void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1\n");
            try
            {
                var clientes = from Customers in context.Customers
                               select new
                               {
                                   ID = Customers.CustomerID,
                                   EMPRESA = Customers.CompanyName,
                                   NOMBRE = Customers.ContactName
                               };
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.ID} - EMPRESA: {cliente.EMPRESA} - NOMBRE CONTACTO: {cliente.NOMBRE}" );
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 2");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //EJERCICIO 2

        public void Ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2\n");
            try
            {
                var productos = context.Products.Where(x => x.UnitsInStock == 0).ToList();

                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.ProductID} - PRODUCTO: {producto.ProductName} - STOCK: {producto.UnitsInStock}");
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 3");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //EJERCICIO 3
        
        public void Ejercicio3()
        {
            Console.WriteLine("\nEjercicio 3\n");
            try
            {

                var stocks = context.Products.Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3).ToList();
                foreach (var stock  in stocks)
                {
                    Console.WriteLine($"ID: {stock.ProductID} - PRODUCTO: {stock.ProductName} - PRECIO: {stock.UnitPrice}");
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 4");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //EJERCICIO 4

        public void Ejercicio4()
        {
            Console.WriteLine("\nEjercicio 4\n");
            try
            {
                var clientesWA = context.Customers.Where(x => x.Region == "WA").ToList();
                foreach (var cliente in clientesWA)
                {
                    Console.WriteLine($"ID: {cliente.CustomerID} - NOMBRE: {cliente.ContactName} - REGION: {cliente.Region}");
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 5");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
