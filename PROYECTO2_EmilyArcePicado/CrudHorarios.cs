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
    public partial class CrudHorarios : Form
    {
        public CrudHorarios()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        //Method that loads the dataGrid
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_HORARIOS"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["HORARIOS"];

            }
        }

        //Method that shows the dataGrid loaded with the data from the database
        public void refrescar()
        {
            String[] datos = { "id_horarios", "horarios" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("horarios", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        //button showing refresh method
        private void btnMostrarHorarios_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        //Method that cleans the txtBox
        public void limpiarDatos()
        {
            txtCodigoHorarios.Text = "";
            txtHorarios.Text = "";
            txtCodigoEliminar.Text = "";
            txtCodigoModificar.Text = "";

        }

        //Method that validates that the data is entered correctly
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoHorarios.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtHorarios.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            return datosCorrectos;
        }


        // button that is responsible for inserting information into the database
        private void btnInsertarHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO HORARIOS (ID_HORARIOS, HORARIOS) " +
                        "VALUES(" + txtCodigoHorarios.Text.ToUpper() + ", '" + txtHorarios.Text.ToUpper() + "')";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();

                    limpiarDatos();

                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("HORARIO INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LO DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR,ELHORARIO NO SE HA LOGRADO GUARDAR");
            }
        }

        // button that is responsible for deleting the records that the user wants
        private void btnEliminarHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from horarios where id_horarios = '" + txtCodigoEliminar.Text + "'";
                CONEXION.conectarPostgresSQL();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, CONEXION.conexion);
                comando.ExecuteNonQuery();
                limpiarDatos();
                refrescar();
                CONEXION.desconectarPostgresSQL();
                limpiarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, NO SE LOGRO ELIMINAR EL DEPARTAMENTO");
            }
        }

        //Button that is responsible for searching and loading the txtBox with the information that the user needs
        private void btnBuscarHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXION.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from horarios  where id_horarios = " + txtCodigoModificar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCodigoHorarios.Text = leer["id_horarios"].ToString();
                    txtHorarios.Text = leer["horarios"].ToString();

                }
                else
                {
                    MessageBox.Show("EL REGISTRO NO EXISTE");
                }

                CONEXION.desconectarPostgresSQL();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }

        //Button that is responsible for modifying the records
        private void btnModificarHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update horarios set id_horarios = " + txtCodigoHorarios.Text.ToUpper() + ", horarios= '" + txtHorarios.Text.ToUpper() + "' where id_horarios = " + txtCodigoHorarios.Text + "";
                NpgsqlCommand comando = new NpgsqlCommand(modificar, CONEXION.conexion);
                int cantidad;
                cantidad = comando.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("REGISTRO MODIFICADO");
                }

                limpiarDatos();

                CONEXION.desconectarPostgresSQL();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO MODIFICAR EL REGISTRO");
            }
        }

        private void CrudHorarios_Load(object sender, EventArgs e)
        {

        }

        private void CrudHorarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Mantenimiento oMantenimiento = new Mantenimiento();
            oMantenimiento.Show();
        }
    }
}
