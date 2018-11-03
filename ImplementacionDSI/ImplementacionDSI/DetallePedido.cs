using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class DetallePedido
    {
        private double _kilosCorte;
        private TipoCorteVacuno _tipoCorteVacuno;

        public double KilosCorte { get => _kilosCorte; set => _kilosCorte = value; }
        internal TipoCorteVacuno TipoCorteVacuno { get => _tipoCorteVacuno; set => _tipoCorteVacuno = value; }

        public DetallePedido(double kilos, TipoCorteVacuno tipoCorte)
        {
            KilosCorte = kilos;
            TipoCorteVacuno = tipoCorte;
        }
    }
}
