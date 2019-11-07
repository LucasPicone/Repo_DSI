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

        public bool esPendienteDeConfirmacion()
        {
            return true;
        }

        public EstadoGuardiaBombero cancelar()
        {
            return new Cancelada();
        }

        //public EstadoGuardiaBombero validarInicio() { }

       /* public EstadoGuardiaBombero registrarRespuesta(String respuesta) {

            if (respuesta == "aceptar")
            {
                return new Aceptada("aceptada", "la guardia fue aceptada por el bombero");
            }
            else return new Rechazada();

        }*/
    }
}
