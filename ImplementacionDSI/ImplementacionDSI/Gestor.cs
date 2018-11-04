using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class Gestor //Aca adentro vamos a crear los objetos
    {
        TipoCorteVacuno lomito;
        TipoCorteVacuno costillar;
        static List<CorteVacuno> cortes = new List<CorteVacuno>();
        List<DetallePedido> detalles = new List<DetallePedido>();
        List<Pedido> pedidos = new List<Pedido>();

        public Gestor()
        {
            Instanciar();
            IniciarForm();
        }

        private void IniciarForm()
        {
            frmGenerarRemito frm = new frmGenerarRemito();
            frm.mostrarPedidos(buscarPedidosSinRemito());
            frm.ShowDialog();
        }
        
        private void Instanciar()
        {
            lomito = new TipoCorteVacuno("Lomito");
            costillar = new TipoCorteVacuno("Costillar");
            Remito rem = new Remito(new DateTime(2018, 11, 4), 1, new DateTime());

            CorteVacuno corteLomito = new CorteVacuno(1, 2.3, new DateTime(2018, 10, 9), new DateTime(2018, 11, 20), lomito, lomito.Nombre);
            cortes.Add(corteLomito);
            corteLomito = new CorteVacuno(2, 2, new DateTime(2018, 10, 15), new DateTime(2018, 11, 5), lomito, lomito.Nombre);
            cortes.Add(corteLomito);
            corteLomito = new CorteVacuno(3, 1.5, new DateTime(2018, 10, 13), new DateTime(2018, 11, 11), lomito, lomito.Nombre);
            cortes.Add(corteLomito);

            DetallePedido detalle = new DetallePedido(20.5, lomito.Nombre, lomito);
            detalles.Add(detalle);
            detalle = new DetallePedido(10.69, costillar.Nombre, costillar);
            detalles.Add(detalle);

            Pedido pedido = new Pedido(1, new DateTime(2018, 11, 3), detalles, null);
            pedidos.Add(pedido);
            pedido = new Pedido(3, new DateTime(2018, 10, 28), detalles, null);
            pedidos.Add(pedido);
            pedido = new Pedido(2, new DateTime(2018, 11, 1), detalles, rem);
            pedidos.Add(pedido);
        }

        private List<Pedido> buscarPedidosSinRemito()
        {
            List<Pedido> pedidosSinRemito = new List<Pedido>();
            for (int i=0; i<pedidos.Count; i++)
            {
                if (!pedidos[i].tieneRemito())
                {
                    pedidosSinRemito.Add(pedidos[i]);
                }
            }
            List<Pedido> ordenados = pedidosSinRemito.OrderBy(o => o.FechaPedido).ToList();
            return ordenados;
        }

        public static List<DetallePedido> tomarPedido(Pedido ped)
        {
            List<DetallePedido> lista = new List<DetallePedido>();
            lista = ped.buscarDatosTipoCorte();
            return lista;
        }

        public static List<CorteVacuno> CortesVacuno(DetallePedido detalle)
        {
            List<CorteVacuno> lista = new List<CorteVacuno>();
            for (int i=0; i< cortes.Count; i++)
            {
                if (cortes[i].TipoCorteVacuno == detalle.TipoCorteVacuno)
                {
                    lista.Add(cortes[i]);
                }
            }
            return lista;
        }
    }
}
