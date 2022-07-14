using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class Administrativa : Form
    {
        public Administrativa()
        {
            InitializeComponent();
            Bitmap imge = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = imge;
        }

      

        private void Administrativa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }

        private void Administrativa_Load(object sender, EventArgs e)
        {

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento oManteminiento = new Mantenimiento();
            oManteminiento.Show();
        }
    }
}
