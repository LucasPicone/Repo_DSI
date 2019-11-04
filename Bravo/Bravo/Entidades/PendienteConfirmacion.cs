using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class PendienteConfirmacion : EstadoGuardiaBombero
    {
        public PendienteConfirmacion(String nom, String desc)
        {
            this.nombre = nom;
            this.descripcion = desc;
        }
    }
}
