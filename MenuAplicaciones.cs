using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Final
{
    public partial class MenuAplicaciones : Form
    {
        public MenuAplicaciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFase2_Click(object sender, EventArgs e)
        {
            Fase2DiomedesPalacio.Consulta_Impuesto fase2 = new Fase2DiomedesPalacio.Consulta_Impuesto();
            fase2.Show();
        }

        private void btnFase3_Click(object sender, EventArgs e)
        {
            Fase3DiomedesPalacio.Ejercicios_Fase3 fase3 = new Fase3DiomedesPalacio.Ejercicios_Fase3();
            fase3.Show();
        }

        private void btnFase4_Click(object sender, EventArgs e)
        {
            Arboles_Binarios.accesos fase4 = new Arboles_Binarios.accesos();
            fase4.Show();
        }
    }
}
