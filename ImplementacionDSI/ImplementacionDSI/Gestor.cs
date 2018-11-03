using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionDSI
{
    class Gestor //Aca adentro vamos a crear los objetos
    {
        TipoCorteVacuno lomito;
        DetallePedido detalle;
        List<DetallePedido> detalles = new List<DetallePedido>();
        Pedido pedido;
        List<Pedido> pedidos = new List<Pedido>();

        public Gestor()
        {
            Instanciar();
            IniciarForm();
        }

        private void IniciarForm()
        {
            frmGenerarRemito frm = new frmGenerarRemito();
            frm.Pedidos(pedidos);
            
            frm.ShowDialog();
        }
        
        private void Instanciar()
        {
            lomito = new TipoCorteVacuno("Lomito");
            detalle = new DetallePedido(20, lomito);
            detalles.Add(detalle);
            detalle = new DetallePedido(10, lomito);
            detalles.Add(detalle);
            pedido = new Pedido(1, new DateTime(2018, 11, 3), detalles);
            pedidos.Add(pedido);
            pedido = new Pedido(2, new DateTime(2018, 11, 1), detalles);
            pedidos.Add(pedido);
            pedido = new Pedido(3, new DateTime(2018, 10, 28), detalles);
            pedidos.Add(pedido);
        }

        public static List<DetallePedido> DetallesPedido(Pedido ped)
        {
            List<DetallePedido> lista = new List<DetallePedido>();
            lista = ped.Detalles;
            return lista;
        }
    }
}
