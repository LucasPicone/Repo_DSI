using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    public class GuardiaBombero
    {
        private DateTime horaDesde;
        private DateTime horaHasta;
        private String motivoRechazo;
        private EstadoGuardiaBombero estado;


        public GuardiaBombero(DateTime desde, DateTime hasta)
        {
            this.horaDesde = desde;
            this.horaHasta = hasta;
            this.motivoRechazo = "";
        }

        public void setEstado(EstadoGuardiaBombero e)
        {
            this.estado = e;
        }
    }
}
