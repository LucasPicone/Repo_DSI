using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    class PendienteConfirmacion : EstadoGuardiaBombero
    {
        public PendienteConfirmacion()
        {
            this.nombre = "pendienteconfirmacion";
            this.descripcion = "indica que la guarda esta esperando la confimacion";
        }

        public bool esPendienteDeConfirmacion()
        {
            return true;
        }

        public EstadoGuardiaBombero cancelar()
        {
            return new Cancelada();
        }

        public EstadoGuardiaBombero validarInicio()
        {
            //reviso la fecha de inicio contra la actual, si no paso no hago nada, si paso paso a EnCurso
            return new EnCurso();
        }

        public EstadoGuardiaBombero registrarRespuesta(String respuesta) {

            if (respuesta == "aceptar")
            {
                return new Aceptada("aceptada", "la guardia fue aceptada por el bombero");
            }
            else return new Rechazada();

        }
    }
}
