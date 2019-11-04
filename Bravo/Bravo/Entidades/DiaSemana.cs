using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class DiaSemana
    {
        private String nombre;

        public DiaSemana(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }
    }
}
