using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Entidades
{

    class Disponibilidad
    {
        private DateTime fechaInicioVigencia;
        private DateTime fechaFinVigencia;
        private List<DetalleDisponibilidad> detalles;

        public Disponibilidad(DateTime fechaInicio, DateTime fechaFin, List<DetalleDisponibilidad> det)
        {
            this.fechaInicioVigencia = fechaInicio;
            this.fechaFinVigencia = fechaFin;
            this.detalles = det;
        }

        public List<String[]> mostrarDisponibilidadCompleta()
        {
            List<String[]> datos = new List<String[]>();

            foreach(DetalleDisponibilidad detalle in detalles)
            {
                datos.Add(detalle.mostrarDatos());
                
            }
            return datos;
        }

        public bool sosVigente(DateTime fechaActual)
        {
            return (fechaFinVigencia > fechaActual);
        }
    }
}
