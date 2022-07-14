using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using Npgsql;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //method that is responsible for verifying that the user is registered in the database
        public void loginAdministrativa()
        {
            try
            {
                CONEXION.conectarPostgresSQL();
                String consulta = "select * from usuarios where usuario = '" + txtUsuario.Text + "' and contrasena = '" + txtContraseña.Text + "'";
                NpgsqlCommand comando = new NpgsqlCommand(consulta, CONEXION.conexion);
                NpgsqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    this.Hide();
                    Administrativa oAdministrativa = new Administrativa();
                    oAdministrativa.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
                CONEXION.desconectarPostgresSQL();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        //button that is responsible for executing the loginAdminsitrador method
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            loginAdministrativa();
            
        }

        //method that is responsible for closing the window and opening the main window
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }

       
    }
}
