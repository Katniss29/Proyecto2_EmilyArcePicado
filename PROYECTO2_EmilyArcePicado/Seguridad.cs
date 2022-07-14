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
using capaNegocio;
using Npgsql;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
            Bitmap imge = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = imge;
        }

        public void limpiarDatos()
        {
            txtCodigoSeguridad.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombreUsuario.Text = "";
            txtFechaCreacion.Text = "";
            txtHoraCreacion.Text = "";

        }

        //Method that validates that the data is entered correctly
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoSeguridad.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtUsuario.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtContraseña.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtNombreUsuario.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtFechaCreacion.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtHoraCreacion.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            return datosCorrectos;
        }

        //button that is responsible for creating new users
        private void btnCreacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO USUARIOS(ID_USUARIOS, USUARIO, CONTRASENA,NOMBRE_USUARIO, FECHA_CREACION, HORA_CREACION) " +
                        "VALUES(" + txtCodigoSeguridad.Text + ", '" + txtUsuario.Text + "', '"+txtContraseña.Text+"', '"+txtNombreUsuario.Text+"', '"+txtFechaCreacion.Text+"', '"+txtHoraCreacion.Text+"')";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("USUARIO: " + txtNombreUsuario.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("USUARIO INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LO DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR,EL USUARIO NO SE HA LOGRADO GUARDAR");
            }
        }

        private void Seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Administrativa oAdministrativa = new Administrativa();
            oAdministrativa.Show();
        }
    }
}
