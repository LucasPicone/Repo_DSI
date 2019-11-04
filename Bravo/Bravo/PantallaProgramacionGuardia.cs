using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravo
{
    public class PantallaProgramacionGuardia
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private GestorProgramacionGuardia gestor;
        public PantallaProgramacionGuardia(GestorProgramacionGuardia gestor)
        {
            this.gestor = gestor;
            Application.Run(new Form1(this));
        }

        public void tomarFechaDesde(DateTime fechaDesde)
        {
            this.fechaDesde = fechaDesde;
        }

        public void tomarFechaHasta(DateTime fechaHasta)
        {
            this.fechaHasta = fechaHasta;
        }

        public void validarPeriodo()
        {
            if (fechaDesde < fechaHasta)
            {
                gestor.tomarPeriodo(fechaDesde, fechaHasta);
            }
            else
            {
                //aeojnghaildf
            }
        }
    }
}
