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
        public void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
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

                Console.WriteLine("Presione un botón para pasar al Ejercicio 2");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
            try
            {
                var productos = context.Products.Where(x => x.UnitsInStock == 0).ToList();

                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.ProductID} - PRODUCTO: {producto.ProductName} - STOCK: {producto.UnitsInStock}");
                }

                Console.WriteLine("Presione un botón para pasar al Ejercicio 3");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
