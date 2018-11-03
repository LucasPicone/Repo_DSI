using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class TipoCorteVacuno
    {
        private string _nombre;

        public TipoCorteVacuno(string nom)
        {
            Nombre = nom;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
