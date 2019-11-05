using System;
using System.Collections.Generic;

namespace Bravo.Entidades
{
    public class ProgramacionGuardia
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private List<GuardiaBombero> guardias;
        private Estado estado;
        

        public void setEstado(Estado e)
        {
            estado = e;
        }

        public ProgramacionGuardia(DateTime fechaDesde, DateTime fechaHasta, List<GuardiaBombero> guardias)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.guardias = guardias;
        }

        public bool coincidePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if(this.fechaDesde >= fechaHasta && this.fechaHasta <= fechaDesde)
            {
                //valida que este fuera del rango
                if (estado.esProgramada() || estado.esEnCurso())
                {
                    return true;
                    //todo mal flaque
                }
                else
                    return false;//?
            }
            else
            {
                return false;
            }
        }

    }
}