using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionDSI
{
    public partial class frmGenerarRemito : Form
    {
        DateTime fechaActual = System.DateTime.Now;
        
        public frmGenerarRemito()
        {
            InitializeComponent();
        }

        internal void mostrarPedidos(List<Pedido> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                pedidoBindingSource.Add(lista[i]);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            btnPedido.Enabled = false;
            btnCorte.Enabled = true;
            List<DetallePedido> lista = Gestor.tomarPedido(dataGridView1.CurrentRow.DataBoundItem as Pedido);
            for (int i = 0; i < lista.Count; i++)
            {
                detallePedidoBindingSource.Add(lista[i]);
            }
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            btnCorte.Enabled = false;
            btnAgregarCorte.Enabled = true;
            List<CorteVacuno> lista = Gestor.CortesVacuno(dgvCortesSolicitados.CurrentRow.DataBoundItem as DetallePedido);
            for (int i= 0; i< lista.Count;i++)
            {
                corteVacunoBindingSource.Add(lista[i]);
            }
            semaforoCortes();
        }

        private void semaforoCortes()
        {
            foreach (DataGridViewRow fila in dgvCortesCandidatos.Rows)
            {
                double dias = (Convert.ToDateTime(fila.Cells[4].Value) - fechaActual).TotalDays;
                if (0 < dias && dias < 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (5 < dias && dias < 10)
                {
                    fila.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (10 < dias)
                {
                    fila.DefaultCellStyle.BackColor = Color.Green;
                }
            }
            dgvCortesCandidatos.DefaultCellStyle.SelectionBackColor = Color.Transparent;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvCortesCandidatos.Rows.Clear();
            dgvCortesSeleccionados.Rows.Clear();
            dgvCortesSolicitados.Rows.Clear();
            btnAgregarCorte.Enabled = false;
            btnCorte.Enabled = false;
            btnPedido.Enabled = true;
            btnGenerarRemito.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
