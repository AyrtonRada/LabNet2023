using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ejercicios
{
    public class Logic2
    {
        public class Ejercicio4CustomException : Exception
        {
            public Ejercicio4CustomException() : base("Excepción personalizada")
            {

            }
        }
    }
}
