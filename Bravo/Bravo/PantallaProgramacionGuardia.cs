using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bravo.GUI;

namespace Bravo
{
    public class PantallaProgramacionGuardia
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private GestorProgramacionGuardia gestor;
        private Form form1;
        private Form form2;


        public PantallaProgramacionGuardia(GestorProgramacionGuardia gestor)
        {
            this.gestor = gestor;
            form1 = new Form1(this);
            form2 = new Form2(this);
        }

        public void habilitarVentana()
        {
            Application.Run(form1);
        }

        public void tomarFechaDesde(DateTime fechaDesde)
        {
            this.fechaDesde = fechaDesde;
            validarPeriodo();
        }

        public void tomarFechaHasta(DateTime fechaHasta)
        {
            this.fechaHasta = fechaHasta;
            validarPeriodo();
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

        public void mostrarBomberosYDisponibilidad(List<object[]> bomberoActivos, Form1 form1)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("apellido");
            foreach (Object[] objeto in bomberoActivos)
            {
                DataRow fila = tabla.NewRow();
                fila["nombre"] = objeto[0];
                fila["apellido"] = objeto[1];
                tabla.Rows.Add(fila);
            }
            form1.llenarGrilla(tabla);
            
            //throw new NotImplementedException();
        }
    }
}
