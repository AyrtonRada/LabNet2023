using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; set; }

        public TransportePublico( int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract int Avanzar();
        public abstract int Detenerse();

    }
}
