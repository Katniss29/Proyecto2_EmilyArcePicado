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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;
            if (usuario == "Emily" && contraseña == "12345")
            {
                this.Hide();
                Administrativa oAdministrativa = new Administrativa();
                oAdministrativa.Show();
            }


        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }
    }
}
