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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        //Button that goes to the login and windows that only authorized users can enter
        private void btnAdministrativa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login oLogin = new Login();
            oLogin.Show();
        }

        //Button that goes to the brands of the employees
        private void btnRegistroDeMarcas_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDeMarcas oRegistroDeMarcas = new RegistroDeMarcas();
            oRegistroDeMarcas.Show();
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
