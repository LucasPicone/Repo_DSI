﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravo.GUI
{
    public partial class Form2 : Form
    {
        private PantallaProgramacionGuardia pantalla;

        public Form2(PantallaProgramacionGuardia pantalla)
        {
            this.pantalla = pantalla;
            InitializeComponent();
        }
    }
}
