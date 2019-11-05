using System;
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

        public void mostrarDisponibilidades(String nombre, List<String[]> disp, DateTime fechaFinVigencia)
        {
            txtBomberoDisp.Text = nombre;
            txtFechaFinVigencia.Text = fechaFinVigencia.ToShortDateString();

            for (int i = 0; i < disp.Count; i++)
            {
                dgvDisponibilidades.Rows.Add(disp[i][2], disp[i][0], disp[i][1], disp[i][0], disp[i][1], disp[i][0], disp[i][1]);
            }
        }
    }
}
