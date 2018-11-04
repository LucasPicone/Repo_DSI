using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class Remito
    {
        private DateTime _fechaEmision;
        private int _numero;
        private DateTime _fechaEntrega;

        public Remito(DateTime fechaE, int num, DateTime fechaEn)
        {
            FechaEmision = fechaE;
            Numero = num;
            FechaEntrega = fechaEn;
        }

        public DateTime FechaEmision { get => _fechaEmision; set => _fechaEmision = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public DateTime FechaEntrega { get => _fechaEntrega; set => _fechaEntrega = value; }
    }
}
