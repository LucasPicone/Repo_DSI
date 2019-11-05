using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    public class Estado
    {
        private String nombre;
        private String descripcion;

        public Estado(String nombre, String descripcion)
        {
            this.nombre = nombre.ToLower();
            this.descripcion = descripcion;
        }

        internal bool esEnCurso()
        {
            return (nombre=="encurso");
        }

        internal bool esProgramada()
        {
            return (nombre == "programada");
        }
    }
}
