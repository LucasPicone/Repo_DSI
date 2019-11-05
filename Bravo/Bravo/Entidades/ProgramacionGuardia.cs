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

        public ProgramacionGuardia(DateTime fechaDesde, DateTime fechaHasta, Estado estado, List<Bombero> bomberosSeleccionados, DateTime[][] horasDesde, DateTime[][] horasHasta, DiaSemana[][] diasSemana)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.estado = estado;

            EstadoGuardiaBombero pendiente = new PendienteConfirmacion("pendienteconfirmacion", "indica que esta pendiente de confirmacion");

            guardias = new List<GuardiaBombero>();

            for(int i = 0; i < bomberosSeleccionados.Count; i++)
            {
                for(int j = 0; j < diasSemana[i].Length; j++)
                {
                    guardias.Add(new GuardiaBombero(bomberosSeleccionados[i], diasSemana[i][j], horasDesde[i][j], horasHasta[i][j]));
                }
            }
        }

        public bool coincidePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if(this.fechaDesde >= fechaHasta || this.fechaHasta <= fechaDesde)
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