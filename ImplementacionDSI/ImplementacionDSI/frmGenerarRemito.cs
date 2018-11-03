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
        public frmGenerarRemito()
        {
            InitializeComponent();
        }

        internal void Pedidos(List<Pedido> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                pedidoBindingSource.Add(lista[i]);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            btnCorte.Enabled = true;
            List<DetallePedido> lista = Gestor.DetallesPedido(dataGridView1.CurrentRow.DataBoundItem as Pedido);
            for (int i = 0; i< lista.Count;i++)
            {
                detallePedidoBindingSource.Add(lista[i]);
            }
        }
    }
}
