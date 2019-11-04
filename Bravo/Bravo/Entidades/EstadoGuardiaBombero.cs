using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    public abstract class EstadoGuardiaBombero
    {

        protected String nombre;
        protected String descripcion;

        //metodos

        public EstadoGuardiaBombero cancelar() { return null; }
        public bool esAceptada() { return false; }
        public bool esCancelada() { return false; }
        public bool esDetenida() { return false; }

        public bool esEnCurso() { return false; }
        public bool esFinalizada() { return false; }
        public bool esPendienteConfirmacion() { return false; }
        public bool esRechazada() { return false; }

        public EstadoGuardiaBombero modificar() { return null; }

        public EstadoGuardiaBombero registrarDetencion() { return null; }

        public EstadoGuardiaBombero registrarRespuesta() { return null; }

        public EstadoGuardiaBombero validarFinalizacion() { return null; }

        public EstadoGuardiaBombero validarInicio() { return null; }

        public EstadoGuardiaBombero validarPeriodoDetencion() { return null; }



    }
}
