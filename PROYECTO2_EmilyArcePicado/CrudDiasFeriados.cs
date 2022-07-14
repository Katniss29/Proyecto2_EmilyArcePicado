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
    public partial class CrudDiasFeriados : Form
    {
        public CrudDiasFeriados()
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
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_DIAS_FERIADOS"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["DIAS_FERIADOS"];

            }
        }

        //Method that shows the dataGrid loaded with the data from the database
        public void refrescar()
        {
            String[] datos = { "id_dias_feriados", "dias_feriados" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("dias_feriados", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        //Method that cleans the txtBox
        public void limpiarDatos()
        {
            txtCodigoDiaFeriado.Text = "";
            txtDiasFeriados.Text = "";
            txtCodigoEliminar.Text = "";
            txtCodigoModificar.Text = "";

        }

        //Method that validates that the data is entered correctly
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoDiaFeriado.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtDiasFeriados.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            return datosCorrectos;
        }
       
        //Button that is responsible for executing the refresh method
        private void btnMostrarDiasFeriados_Click_1(object sender, EventArgs e)
        {
            refrescar();
        }

        //Boton que se encarga de insertar los dias feriados a la base de datos 
        private void btnInsertarDiasFeriados_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO DIAS_FERIADOS(ID_DIAS_FERIADOS, DIAS_FERIADOS) " +
                        "VALUES(" + txtCodigoDiaFeriado.Text.ToUpper() + ", '" + txtDiasFeriados.Text.ToUpper() + "')";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("DIA FERIADO: " + txtDiasFeriados.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("DIA FERIADO INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LO DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR,EL DIA FERIADO NO SE HA LOGRADO GUARDAR");
            }
        }

        //Button that is responsible for eliminating holidays
        private void btnEliminarDiasFeriados_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from dias_feriados where id_dias_feriados = '" + txtCodigoEliminar.Text + "'";
                CONEXION.conectarPostgresSQL();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, CONEXION.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("DIA " + txtDiasFeriados.Text + " ELIMINADO");
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

        //button that is responsible for modifying the holidays
        private void btnModificarDiasFeriados_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update dias_feriados set id_dias_feriados = " + txtCodigoDiaFeriado.Text.ToUpper() + ", dias_feriados = '" + txtDiasFeriados.Text.ToUpper() + "' where id_dias_feriados = " + txtCodigoDiaFeriado.Text + "";
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

        //button that is responsible for searching and loading the txtBox with the data that the user needs
        private void btnBuscarDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXION.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from dias_feriados  where id_dias_feriados = " + txtCodigoModificar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCodigoDiaFeriado.Text = leer["id_dias_feriados"].ToString();
                    txtDiasFeriados.Text = leer["dias_feriados"].ToString();

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
    }
}
