using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ejercicios
{
    public class Ejercicio2
    {
        public static void Ejercicio2Division()
        {
            try
            {
                //Usuario ingresa el dividendo

                Console.WriteLine("Ejercicio 2. \nIngrese DIVIDENDO ENTERO: ");
                int dividendo = Int32.Parse(Console.ReadLine());

                //Usuario ingresa el divisor

                Console.WriteLine("Ingrese DIVISOR ENTERO: ");
                int divisor = Int32.Parse(Console.ReadLine());

                //Resultado de la división

                int resultado = dividendo/divisor;

                //Mostrar el resultado

                Console.WriteLine("El resultado es: " + resultado);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero! \n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
