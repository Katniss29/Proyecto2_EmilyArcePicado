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
    public partial class CrudDeducciones : Form
    {
        public CrudDeducciones()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        // method that is responsible for loading the dataGrit
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_DEDUCCIONES"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["REBAJA_SALARIO"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["SALARIO_GANADO"];
                dataGridView1.Rows[indice].Cells[3].Value = informacionEstudiantes.Rows[i]["CCSS"];
                dataGridView1.Rows[indice].Cells[4].Value = informacionEstudiantes.Rows[i]["IVM"];
                dataGridView1.Rows[indice].Cells[5].Value = informacionEstudiantes.Rows[i]["JUNTA_AHORRO"];
                dataGridView1.Rows[indice].Cells[6].Value = informacionEstudiantes.Rows[i]["POLIZA"];
            }
        }

        //Method that allows to visualize the database in the dataGrid
        public void refrescar()
        {
            String[] datos = { "id_deducciones", "rebaja_salario", "salario_ganado", "ccss", "ivm", "junta_ahorro","poliza" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("deducciones", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        //button that executes the refresh method
        private void btnMostrarDEDUCCIONES_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        //button that is responsible for inserting data into the database
        private void btnInsertarDeducciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO DEDUCCIONES (ID_DEDUCCIONES, REBAJA_SALARIO, SALARIO_GANADO, CCSS, IVM, JUNTA_AHORRO, POLIZA) " +
                        "VALUES(" + txtCodigoDeducciones.Text + ", " + txtRebejasSalariales.Text + ", "+txtSalarioGanada.Text+", "+txtCCSS.Text+", "+txtIVM.Text+", "+txtJuntaAhorro.Text+", "+txtPoliza.Text+")";
                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    limpiarDatos();
                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("DEDUCCION INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LO DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR,LA DEDUCCION NO SE HA LOGRADO GUARDAR");
            }
        }

        //method that cleans the txtBox
        public void limpiarDatos()

        {
            txtCodigoDeducciones.Text = "";
            txtRebejasSalariales.Text = "";
            txtSalarioGanada.Text = "";
            txtCCSS.Text = "";
            txtIVM.Text = "";
            txtJuntaAhorro.Text = "";
            txtPoliza.Text = "";

        }

        //Method that validates that the data is entered correctly
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoDeducciones.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtRebejasSalariales.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtSalarioGanada.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtCCSS.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtIVM.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtJuntaAhorro.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtPoliza.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            return datosCorrectos;
        }

        //button that is responsible for searching and filling the txtBox with the information that the user needs
        private void btnBuscarDeduccion_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXION.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from deducciones  where id_deducciones = " + txtCodigoModificar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCodigoDeducciones.Text = leer["id_deducciones"].ToString();
                    txtRebejasSalariales.Text = leer["rebaja_salario"].ToString();
                    txtSalarioGanada.Text = leer["salario_ganado"].ToString();
                    txtCCSS.Text = leer["ccss"].ToString();
                    txtIVM.Text = leer["ivm"].ToString();
                    txtJuntaAhorro.Text = leer["junta_ahorro"].ToString();
                    txtPoliza.Text = leer["poliza"].ToString();
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

        //button that is responsible for modifying the database records
        private void btnModificarDeducciones_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update deducciones set id_deducciones = " + txtCodigoDeducciones.Text + ", rebaja_salario = " + txtRebejasSalariales.Text + ", salario_ganado = "+txtSalarioGanada.Text+", " +
                    " ccss = "+txtCCSS.Text+" , ivm = "+txtIVM.Text+" , junta_ahorro = "+txtJuntaAhorro.Text+", poliza = "+txtPoliza.Text+" where id_deducciones = " + txtCodigoDeducciones.Text + "";
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

        // button that is responsible for deleting the records from the database
        private void btnEliminarDeducciones_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from deducciones where id_deducciones = '" + txtCodigoEliminar.Text + "'";
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

        private void CrudDeducciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Mantenimiento oMantenimiento = new Mantenimiento();
            oMantenimiento.Show();

        }
    }
}
