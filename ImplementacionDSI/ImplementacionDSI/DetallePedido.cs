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
        private string _nombreCorte;

        public double KilosCorte { get => _kilosCorte; set => _kilosCorte = value; }
        internal TipoCorteVacuno TipoCorteVacuno { get => _tipoCorteVacuno; set => _tipoCorteVacuno = value; }
        public string NombreCorte { get => _nombreCorte; set => _nombreCorte = value; }

        public DetallePedido(double kilos, string nombre, TipoCorteVacuno tipoCorte)
        {
            KilosCorte = kilos;
            NombreCorte = nombre;
            TipoCorteVacuno = tipoCorte;
        }
    }
}
