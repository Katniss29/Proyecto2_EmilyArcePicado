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
    public partial class RegistroDeMarcas : Form
    {
        public RegistroDeMarcas()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        //method that is responsible for closing the window and going to the exit login that can only be exited if it is an authorized user
        private void RegistroDeMarcas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LOGINSALIDA oLoginSalida = new LOGINSALIDA();
            oLoginSalida.Show();
        }

       
    }
}
