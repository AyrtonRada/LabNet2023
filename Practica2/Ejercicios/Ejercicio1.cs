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
                //Usuario ingresa 1 numero

                Console.WriteLine("Ejercicio 1. \nIngrese un número: ");
                int numero = Int32.Parse(Console.ReadLine());
                
                //Resultado de la división
                int resultado = numero / 0;

                //Mostrar la division (cosa que no debe ser posible)
                Console.WriteLine("El resultado es: " + resultado);
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
