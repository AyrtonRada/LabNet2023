using Practica2.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            Ejercicio1.Ejercicio1DividirCero();

            Console.WriteLine("\n");

            // Ejercicio 2
            Ejercicio2.Ejercicio2Division();

            Console.WriteLine("\n");
            
            //Ejercicio 3
            try
            {
                Console.WriteLine("Ejercicio 3.");
                Logic.Ejercicio3Exception();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message + "\n" + "Tipo: " + ex.GetType().Name );
            }

            Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}
