﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravo
{
    public partial class Form1 : Form
    {
        private PantallaProgramacionGuardia pantalla;
        public Form1(PantallaProgramacionGuardia pant)
        {
            this.pantalla = pant;
            InitializeComponent();
        }

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            pantalla.tomarFechaDesde(dtpFechaDesde.Value);
        }

        private void DtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            pantalla.tomarFechaHasta(dtpFechaHasta.Value);
        }
    }
}
