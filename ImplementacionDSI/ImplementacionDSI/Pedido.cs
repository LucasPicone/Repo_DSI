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
        

        public Pedido(int nro, DateTime fecha, List<DetallePedido> det)
        {
            Numero = nro;
            FechaPedido = fecha;
            Detalles = det;
        }

        public int Numero { get => _numero; set => _numero = value; }
        public DateTime FechaPedido { get => _fechaPedido; set => _fechaPedido = value; }
        internal List<DetallePedido> Detalles { get => _detalles; set => _detalles = value; }
    }
}
