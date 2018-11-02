using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionDSI
{
    class Main //Aca adentro vamos a crear los objetos
    {
        public Main()
        {
            IniciarForm();
        }

        private void IniciarForm()
        {
            frmGenerarRemito frm = new frmGenerarRemito();
            frm.ShowDialog();
        }
    }
}
