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
                    Console.WriteLine($"ID: {cliente.ID} - EMPRESA: {cliente.EMPRESA} - NOMBRE CONTACTO: {cliente.NOMBRE}");
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
                foreach (var stock in stocks)
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

        //EJERCICIO 5

        public void Ejercicio5()
        {
            Console.WriteLine("\n Ejercicio 5\n");
            try
            {
                var productosID = context.Products.FirstOrDefault(x => x.ProductID == 789);

                if (productosID == null)
                {
                    Console.WriteLine("No se encontró un Producto con el ID: 789");
                }
                else
                {
                    Console.WriteLine($"ID: {productosID.ProductID} - PRODUCTO: {productosID.ProductName} - STOCK: {productosID.UnitsInStock} - PRECIO: {productosID.UnitPrice}");
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 6");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //EJERCICIO 6

        public void Ejercicio6()
        {
            Console.WriteLine("\n Ejercicio 6\n");
            try
            {
                var nombresClientes = from Customers in context.Customers select Customers.ContactName;
                foreach (var nombre in nombresClientes)
                {
                    var mayus = nombre.ToUpper();
                    var minus = nombre.ToLower();

                    Console.WriteLine($"\n {mayus} - {minus}");
                }

                Console.WriteLine("\nPresione un botón para pasar al Ejercicio 7");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
