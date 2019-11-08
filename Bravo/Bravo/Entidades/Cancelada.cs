using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class Cancelada : EstadoGuardiaBombero
    {
        public Cancelada()
        {
            this.nombre = "cancelada";
            this.descripcion = "indica que la programacion fue cancelada";
        }

        public bool esCancelada()
        {
            return true;
        }
    }
}
