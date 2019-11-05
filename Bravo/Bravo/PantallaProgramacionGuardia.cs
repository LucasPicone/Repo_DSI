using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bravo.Entidades;
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

        public void mostrarBomberosYDisponibilidad(List<Bombero> bomberoActivos)
        {
            
            Form1 form = (Form1) Application.OpenForms["Form1"];
            form.llenarGrilla(bomberoActivos);

        }

        public void mostrarDisponibilidades(Bombero bombero)
        {
            String nombre = bombero.getNombre() + " " + bombero.getApellido();
            DateTime fechaFinVigencia = bombero.getFinVigenciaDisponibilidadActual();
            List<String[]> disponibilidades = bombero.disponibilidadVigente();


            if(form2 == null)
            {
                form2 = new Form2(this);
            }
            form2.Show();
            Form2 form = (Form2)Application.OpenForms["Form2"];
            form.mostrarDisponibilidades(nombre, disponibilidades, fechaFinVigencia);
        }

        public void validarSeleccionBomberos(List<Bombero> bomberoSeleccionado)
        {
            if(bomberoSeleccionado.Count < 5)
            {
                MessageBox.Show("No selecciono 5 bomberos", "Validacion de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gestor.tomarBomberos(bomberoSeleccionado);
            }
        }

        public void solicitarConfirmacion()
        {
            if(MessageBox.Show("¿Desea crear la programacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestor.tomarConfirmacion();
            }
        }
    }
}
