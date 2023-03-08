using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ejercicios
{
    public class Ejercicio1
    {
           public static void Ejercicio1DividirCero()
        {
            try
            {
                Console.WriteLine("Ejercicio 1. \nIngrese un número: ");
                int numero = Int32.Parse(Console.ReadLine());
                int resultado = numero / 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La división terminó.");
            }
            
        }
    }
}
