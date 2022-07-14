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
    public partial class CrudEmpleados : Form
    {
        public CrudEmpleados()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        //Method to load the datagrid with the employees table
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_EMPLEADOS"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["CEDULA"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["NOMBRE"];
                dataGridView1.Rows[indice].Cells[3].Value = informacionEstudiantes.Rows[i]["APELLIDO1"];
                dataGridView1.Rows[indice].Cells[4].Value = informacionEstudiantes.Rows[i]["APELlIDO2"];
                dataGridView1.Rows[indice].Cells[5].Value = informacionEstudiantes.Rows[i]["DIRECCION"];
                dataGridView1.Rows[indice].Cells[6].Value = informacionEstudiantes.Rows[i]["TELEFONO"];
                dataGridView1.Rows[indice].Cells[7].Value = informacionEstudiantes.Rows[i]["SALARIO_HORAS"];
            }
        }

        //Method to load the attributes of the table used and enter them in an array and thus load it to the dataGit
        public void refrescar()
        {
            String[] datos = { "id_empleados", "cedula" ,"nombre", "apellido1", "apellido2", "direccion", "telefono", "salario_horas" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("empleados", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        //button that is responsible for inserting new employees
        private void btnInsertarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO EMPLEADOS(ID_EMPLEADOS,CEDULA, NOMBRE, APELLIDO1, APELLIDO2, DIRECCION, TELEFONO, SALARIO_HORAS) " +
                        "VALUES('"+txtCodigoEmpleado.Text.ToUpper()+"', "+txtCedula.Text.ToUpper()+",'"+txtNombreEmpleado.Text.ToUpper()+"', " +
                        "'"+txtPrimerApellidoEmpleado.Text.ToUpper()+"', '"+txtSegundoApellidoEmpleado.Text.ToUpper()+"', '"+txtDireccionEmpleado.Text.ToUpper()+"'," +
                        " "+txtTelefonoEmpleado.Text.ToUpper()+", "+txtSalarioHoras.Text.ToUpper()+ ")";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EL EMPLEADO: " + txtNombreEmpleado.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("EMPLEADO INSERTADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR, INGRESE LOS DATOS CORRECTOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, EL EMPLEADO NO SE HA LOGRADO GUARDAR");
            }
        }

        //button that is responsible for cleaning the textBox
        public void limpiarDatos()

        {
            txtCodigoEmpleado.Text = "";
            txtCedula.Text = "";
            txtCedulaEliminar.Text = "";
            txtNombreEmpleado.Text = "";
            txtPrimerApellidoEmpleado.Text = "";
            txtSegundoApellidoEmpleado.Text = "";
            txtDireccionEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtSalarioHoras.Text = "";
        }

        //button that is responsible for validating that all the data were filled and correct
        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigoEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtCedula.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtNombreEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtPrimerApellidoEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtSegundoApellidoEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtDireccionEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtTelefonoEmpleado.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtSalarioHoras.Text == String.Empty)
            {
                datosCorrectos = false;
            }


            return datosCorrectos;
        }

        //button that is responsible for removing the desired employees
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from empleados where cedula = '" + txtCedulaEliminar.Text + "'";
                CONEXION.conectarPostgresSQL();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, CONEXION.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("EMPLEADO " + txtNombreEmpleado.Text + " ELIMINADO");
                limpiarDatos();
                refrescar();
                CONEXION.desconectarPostgresSQL();
                limpiarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, NO SE LOGRO ELIMINAR EL EMPLEADO");
            }
        }

        //button that is responsible for searching for the employee to be modified and loading the textBox with the data that corresponds to that employee
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXION.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from empleados  where id_empleados = " + txtCodigoModificar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCodigoEmpleado.Text = leer["id_empleados"].ToString();
                    txtCedula.Text = leer["cedula"].ToString();
                    txtNombreEmpleado.Text = leer["nombre"].ToString();
                    txtPrimerApellidoEmpleado.Text = leer["apellido1"].ToString();
                    txtSegundoApellidoEmpleado.Text = leer["apellido2"].ToString();
                    txtDireccionEmpleado.Text = leer["direccion"].ToString();
                    txtTelefonoEmpleado.Text = leer["telefono"].ToString();
                    txtSalarioHoras.Text = leer["salario_horas"].ToString();


                }
                else
                {
                    MessageBox.Show("El registro no existe");
                }

                CONEXION.desconectarPostgresSQL();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }

        //Method that is responsible for closing the screen and returning maintenance screen
        private void CrudEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Mantenimiento oMantenimiento = new Mantenimiento();
            oMantenimiento.Show();
        }

        //button where the refresh method is executed that helps to see the data in the database
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        //button that is responsible for modifying the employee
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update empleados set id_empleados = " + txtCodigoEmpleado.Text + ", cedula = " + txtCedula.Text + ",nombre = '" + txtNombreEmpleado.Text + "', " +
                    " apellido1 = '" + txtPrimerApellidoEmpleado.Text + "', apellido2 = '" + txtSegundoApellidoEmpleado.Text + "'," +
                    "direccion = '" + txtDireccionEmpleado.Text + "', telefono = " + txtTelefonoEmpleado.Text + ", salario_horas = '" + txtSalarioHoras.Text + "' where id_empleados = " + txtCodigoEmpleado.Text + "";
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

        private void CrudEmpleados_Load(object sender, EventArgs e)
        {

        }

    }
}
