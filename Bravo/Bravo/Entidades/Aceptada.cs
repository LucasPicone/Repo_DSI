using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class Aceptada : EstadoGuardiaBombero
    {
        public Aceptada(String nombre, String desc)
        {
            this.nombre = nombre;
            this.descripcion = desc;
        }

        public bool esAceptada()
        {
            return true;
        }

        public EstadoGuardiaBombero cancelar()
        {
            return new Cancelada();
        }

        public EstadoGuardiaBombero validarInicio()
        {
            
            return new EnCurso();
        }
    }
}
