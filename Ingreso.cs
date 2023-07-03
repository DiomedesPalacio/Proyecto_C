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
    public partial class IngresoApp : Form
    {
        public IngresoApp()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MenuAplicaciones menu = new MenuAplicaciones();

            int contraseña = 123;

            if (Convert.ToInt32(txtContraseña.Text) == contraseña)
            {
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("La clave es erronea");
                Application.Exit();
            }
        }
    }
}
