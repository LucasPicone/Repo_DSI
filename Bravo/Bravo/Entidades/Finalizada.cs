using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class Finalizada : EstadoGuardiaBombero
    {
        public Finalizada()
        {
            this.nombre = "finalizada";
            this.descripcion = "indica que la guardia termino";
        }

        public bool esFinalizada()
        {
            return true;
        }
    }
}
