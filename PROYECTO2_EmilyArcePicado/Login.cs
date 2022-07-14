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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            loginAdministrativa();
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
