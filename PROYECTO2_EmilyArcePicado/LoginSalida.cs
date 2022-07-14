using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using capaDatos;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class LOGINSALIDA : Form
    {
        public LOGINSALIDA()
        {
            InitializeComponent();
        }

        //button that is responsible for verifying that he is an authorized user to be able to go to the main screen
        private void btnVerificar_Click(object sender, EventArgs e)
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
                    VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
                    oVentanaPrincipal.Show();
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

        
    }
}
