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
        }
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
        public void refrescar()
        {
            String[] datos = { "id_empleados", "cedula" ,"nombre", "apellido1", "apellido2", "direccion", "telefono", "salario_horas" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("empleados", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnInsertarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO EMPLEADOS(ID_EMPLEADOS,CEDULA, NOMBRE, APELLIDO1, APELLIDO2, DIRECCION, TELEFONO, SALARIO_HORAS) " +
                        "VALUES('"+txtCodigoEmpleado.Text+"', "+txtCedula.Text+",'"+txtNombreEmpleado.Text+"', " +
                        "'"+txtPrimerApellidoEmpleado.Text+"', '"+txtSegundoApellidoEmpleado.Text+"', '"+txtDireccionEmpleado.Text+"'," +
                        " "+txtTelefonoEmpleado.Text+", "+txtSalarioHoras.Text+ ")";


                    CONEXION.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXION.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EL EMPLEADO: " + txtNombreEmpleado.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXION.desconectarPostgresSQL();

                    MessageBox.Show("Empleado insertado con exito");
                }
                else
                {
                    MessageBox.Show("Error, ingrese los datos correctos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error, el empleado no se a logrado guardar");
            }
        }

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
                MessageBox.Show("ERROR, NO SE LOGRO ELIMINAR EL MEDICAMENTO");
            }
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.conectarPostgresSQL();

                String modificar = "update empleados set id_empleados = "+ txtCodigoEmpleado.Text+", cedula = "+ txtCedula.Text+",nombre = '"+txtNombreEmpleado.Text +"', " +
                    " apellido1 = '" + txtPrimerApellidoEmpleado.Text + "', apellido2 = '" + txtSegundoApellidoEmpleado.Text + "'," +
                    "direccion = '" + txtDireccionEmpleado.Text + "', telefono = " + txtTelefonoEmpleado.Text + ", salario_horas = '" +txtSalarioHoras.Text+ "' where id_empleados = " + txtCodigoEmpleado.Text + "";
                NpgsqlCommand comando = new NpgsqlCommand(modificar, CONEXION.conexion);
                int cantidad;
                cantidad = comando.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("REGISTRO MODIFICADO");
                }

                limpiarDatos();

                CONEXION.desconectarPostgresSQL();
            }catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO MODIFICAR EL REGISTRO");
            }
            
        }

        private void CrudEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Mantenimiento oMantenimiento = new Mantenimiento();
            oMantenimiento.Show();
        }
    }
}
