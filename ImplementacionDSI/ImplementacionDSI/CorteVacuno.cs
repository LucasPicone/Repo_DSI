﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionDSI
{
    class CorteVacuno
    {
        private int nroSecuencia;
        private double peso;
        private DateTime fechaEnvasado;
        private DateTime fechaVencimiento;
        private TipoCorteVacuno tipoCorteVacuno;
        private string nombreCorteVacuno;

        public int NroSecuencia { get => nroSecuencia; set => nroSecuencia = value; }
        public double Peso { get => peso; set => peso = value; }
        public DateTime FechaEnvasado { get => fechaEnvasado; set => fechaEnvasado = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        internal TipoCorteVacuno TipoCorteVacuno { get => tipoCorteVacuno; set => tipoCorteVacuno = value; }
        public string NombreCorteVacuno { get => nombreCorteVacuno; set => nombreCorteVacuno = value; }

        public CorteVacuno(int secuencia, double pes, DateTime fechaEnv, DateTime fechaVen, TipoCorteVacuno tipo, string nomb)
        {
            NroSecuencia = secuencia;
            Peso = pes;
            FechaEnvasado = fechaEnv;
            FechaVencimiento = fechaVen;
            TipoCorteVacuno = tipo;
            NombreCorteVacuno = nomb;
        }
    }
}
