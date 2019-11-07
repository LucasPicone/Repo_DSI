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

        public ProgramacionGuardia(DateTime fechaDesde, DateTime fechaHasta, Estado estado, List<Bombero> bomberosSeleccionados, List<DateTime[]> horasDesde, List<DateTime[]> horasHasta, List<DiaSemana[]> diasSemana)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.estado = estado;

            EstadoGuardiaBombero pendiente = new PendienteConfirmacion("pendienteconfirmacion", "indica que esta pendiente de confirmacion");

            guardias = new List<GuardiaBombero>();

            //loop bomberos

            for(int i = 0; i < bomberosSeleccionados.Count; i++)
            {
                //loop dias
                DiaSemana[] dias = diasSemana[i]; //todos los DiaSemana del bombero i
                int diasDisponibles = dias.Length; //cantidad de dias que el bombero i tiene disponibles
                for(int j = 0; j < diasDisponibles; j++)
                {
                    guardias.Add(new GuardiaBombero(bomberosSeleccionados[i], dias[j], horasDesde[i][j], horasHasta[i][j], pendiente));

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
                    //el periodo esta ocupado 
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

    }
}