using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{
    public class DetalleDisponibilidad
    {
        private DateTime horaDesde;
        private DateTime horaHasta;
        private DiaSemana dia;

        public DetalleDisponibilidad(DateTime desde, DateTime hasta, DiaSemana dia)
        {
            this.horaDesde = desde;
            this.horaHasta = hasta;
            this.dia = dia;
        }

        public String[] mostrarDatos()
        {
            String[] datos = new String[3];
            datos[0] = horaDesde.ToShortTimeString();
            datos[1] = horaHasta.ToShortTimeString();
            datos[2] = dia.getNombre();

            return datos;
        }

        public Object[] cargarDatos()
        {
            Object[] datos = new Object[3];
            datos[0] = horaDesde;
            datos[1] = horaHasta;
            datos[2] = dia;

            return datos;

        }
    }
}
