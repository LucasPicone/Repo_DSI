using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class Pedido
    {
        private int _numero;
        private DateTime _fechaPedido;
        private List<DetallePedido> _detalles;
        private Remito _remito;
        

        public Pedido(int nro, DateTime fecha, List<DetallePedido> det, Remito rem)
        {
            Numero = nro;
            FechaPedido = fecha;
            Detalles = det;
            Remito = rem;
        }

        public int Numero { get => _numero; set => _numero = value; }
        public DateTime FechaPedido { get => _fechaPedido; set => _fechaPedido = value; }
        internal List<DetallePedido> Detalles { get => _detalles; set => _detalles = value; }
        internal Remito Remito { get => _remito; set => _remito = value; }

        public bool tieneRemito()
        {
            if (this.Remito == null)
                return false;
            else
                return true;
        }

        public List<DetallePedido> buscarDatosTipoCorte()
        {
            List<DetallePedido> lista = new List<DetallePedido>();
            for (int i = 0; i< Detalles.Count; i++)
            {
                lista.Add(Detalles[i]);
            }
            return lista;
        }
    }
}
