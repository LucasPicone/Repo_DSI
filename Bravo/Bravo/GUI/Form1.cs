using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bravo.Entidades;

namespace Bravo.GUI
{
    public partial class Form1 : Form
    {
        private PantallaProgramacionGuardia pantalla;
        List<Bombero> bomberoActivo;

        public Form1(PantallaProgramacionGuardia pant)
        {
            this.pantalla = pant;
            InitializeComponent();
        }

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            pantalla.tomarFechaDesde(dtpFechaDesde.Value);
        }

        private void DtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            pantalla.tomarFechaHasta(dtpFechaHasta.Value);
        }

        public void llenarGrilla(List<Bombero> bomberoActivos)
        {
            dgvBomberos.Rows.Clear();
            this.bomberoActivo = bomberoActivos;

            foreach(Bombero bombero in bomberoActivos)
            {
                dgvBomberos.Rows.Add(false, bombero.getNombre(), bombero.getApellido());
            }
        }

        private void dgvBomberos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvBomberos.Columns["disponibilidad"].Index) return;

            pantalla.mostrarDisponibilidades(bomberoActivo[e.RowIndex]);
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            List<Bombero> bomberoSeleccionado = new List<Bombero>();
            foreach(DataGridViewRow row in dgvBomberos.Rows)
            {
                bool a = (bool) row.Cells[0].Value;
                if(a)
                {
                    bomberoSeleccionado.Add(bomberoActivo[row.Index]);
                }
            }

            pantalla.validarSeleccionBomberos(bomberoSeleccionado);
        }
    }
}
