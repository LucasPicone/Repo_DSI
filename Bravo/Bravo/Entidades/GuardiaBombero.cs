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
        private Bombero bombero;
        private DiaSemana diaSemana;

        public GuardiaBombero(DateTime desde, DateTime hasta)
        {
            this.horaDesde = desde;
            this.horaHasta = hasta;
            this.motivoRechazo = "";
        }

        public GuardiaBombero(Bombero bombero, DiaSemana diaSemana, DateTime horaDesde, DateTime horaHasta, EstadoGuardiaBombero estado)
        {
            this.bombero = bombero;
            this.diaSemana = diaSemana;
            this.horaDesde = horaDesde;
            this.horaHasta = horaHasta;
            this.setEstado(estado);
        }

        public void setEstado(EstadoGuardiaBombero e)
        {
            this.estado = e;
        }
    }
}
