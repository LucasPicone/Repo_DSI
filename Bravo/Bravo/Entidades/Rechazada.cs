using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class Rechazada : EstadoGuardiaBombero
    {
        public Rechazada()
        {
            this.nombre = "rechazada";
            this.descripcion = "indica que la guarda fue rechazada";
        }

        public bool esRechazada()
        {
            return true;
        }
    }
}
