using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class TransporteOmnibus : TransportePublico
    {
        public TransporteOmnibus(int pasajeros) : base(pasajeros)
        {

        }

        public override int Avanzar()
        {
            throw new NotImplementedException();
        }

        public override int Detenerse()
        {
            throw new NotImplementedException();
        }       
        
    }
}
