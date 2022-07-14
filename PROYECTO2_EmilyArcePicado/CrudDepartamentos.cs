using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaDatos;
using Npgsql;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class CrudDepartamentos : Form
    {
        public CrudDepartamentos()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        //Method that is responsible for closing the window and opening the maintenance window
        private void CrudDepartamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Mantenimiento oMantenimiento = new Mantenimiento();
            oMantenimiento.Show();
        }

        // method that is responsible for loading the dataGrit
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_DEPARTAMENTO"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["NOMBRE"];
                
            }
        }

        //Method that allows to visualize the database in the dataGrid
        public void refrescar()
        {
            String[] datos = { "id_departamento",  "nombre"};
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("departamentos", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        //Button that executes the refresh method, which is to display the data in the dataGrid
        private void btnMostrarDepartamentos_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        //button that is responsible for executing the code that inserts the departments
        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO DEPARTAMENTOS(ID_DEPARTAMENTO, NOMBRE) " +
                        "VALUES(" + txtCodigoDepartamento.Text.ToUpper() + ", '" + txtDepartamento.Text.ToUpper() + "')";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EL DEPARTAMENTO: " + txtDepartamento.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("DEPARTAMENTO INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LO DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR,EL DEPARTAMENTO NO SE HA LOGRADO GUARDAR");
            }
        }

        //method that cleans the txtBox
        public void limpiarDatos()

        {
            txtCodigoDepartamento.Text = "";
            txtDepartamento.Text = "";
            txtCodigoEliminar.Text = "";
            txtCodigoModificar.Text = "";
            
        }

        //Method that validates that the data is entered correctly
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoDepartamento.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtDepartamento.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            return datosCorrectos;
        }

        //Button that is responsible for modifying the departments
        private void btnModificarDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update departamentos set id_departamento = " + txtCodigoDepartamento.Text.ToUpper() + ", nombre = '"+ txtDepartamento.Text.ToUpper()+ "' where id_departamento = " + txtCodigoDepartamento.Text + "";
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


        //Button that is responsible for searching and loading the txtBox with the department that the user needs
        private void btnBuscarDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXION.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from departamentos  where id_departamento = " + txtCodigoModificar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCodigoDepartamento.Text = leer["id_departamento"].ToString();
                    txtDepartamento.Text = leer["nombre"].ToString();
                   

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

        //Button that is responsible for removing the department that the user needs
        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from departamentos where id_departamento = '" + txtCodigoEliminar.Text + "'";
                CONEXION.conectarPostgresSQL();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, CONEXION.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("DEPARTAMENTO " + txtDepartamento.Text + " ELIMINADO");
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
    }
}
