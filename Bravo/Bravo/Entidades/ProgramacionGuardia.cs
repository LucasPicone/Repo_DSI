using System;

namespace Bravo.Entidades
{
    public class ProgramacionGuardia
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Estado estado;

        public ProgramacionGuardia(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
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