using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // Coleccion de la cantidad de pasajeros

            List<TransportePublico> transporte = new List<TransportePublico>
            {
               
            };
            
            
            //usuarios agrega pasajeros a Omnibus
            
            int entero;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese la cantidad de pasajeros para el Omnibus {i}: ");

                string cant = Console.ReadLine();
                while (!Int32.TryParse(cant, out entero))
                {
                    Console.WriteLine("Ingrese un número válido: ");
                    cant = Console.ReadLine();
                }

                transporte.Add( new TransporteOmnibus(int.Parse(cant)));
            }

            Console.WriteLine("\n");

            //usuarios agrega pasajeros a Taxi

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese la cantidad de pasajeros para el Taxi {i}: ");

                string cant = Console.ReadLine();
                while (!Int32.TryParse(cant, out entero))
                {
                    Console.WriteLine("Ingrese un número válido: ");
                    cant = Console.ReadLine();
                }
                transporte.Add(new TransporteTaxi(Int32.Parse(cant)));
            }

            Console.WriteLine("\n");

            // Mostrar lista 

            Console.WriteLine("LISTA DE LOS TRANSPORTES \n");

            for (int i = 0; i <= transporte.Count -6; i++)
            {
                Console.WriteLine($"Omnibus {i+1}: " + transporte[i].pasajeros);
            }

            Console.WriteLine("\n");
            
            for (int i = 5; i < transporte.Count ; i++)
            {
                Console.WriteLine($"Taxi {i-4}: " + transporte[i].pasajeros);
            }            

            Console.ReadKey();
        }
    }
}
